using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Management.Domain.Dtos.Login;
using Management.Domain.Factories;
using Management.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Management.Application.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IAuthenticationService AuthenticationService { get; set; }

        private INotificationFactory NotificationFactory { get; set; }

        public LoginController(
            INotificationFactory notificationFactory,
            IAuthenticationService authenticationService)
        {
            this.NotificationFactory = notificationFactory;
            this.AuthenticationService = authenticationService;
        }

        [HttpPost]
        public IActionResult Authentication([FromBody] AuthenticateUserDto userAuthentication)
        {
            if (userAuthentication == null)
            {
                return this.BadRequest(this.NotificationFactory.Error($"{nameof(userAuthentication)} not found."));
            }

            AuthenticatedUserDto authenticatedUserDto = this.AuthenticationService.AuthenticateUser(userAuthentication);


            if (!authenticatedUserDto.Authenticated)
            {
                return this.BadRequest(this.NotificationFactory.Error(authenticatedUserDto.Error));
            }

            return this.Ok(this.NotificationFactory.Success(authenticatedUserDto.UserSystem));
        }
    }
}