using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Management.Domain.Factories;
using Management.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Management.Application.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public ICityService CityService { get; set; }

        public INotificationFactory NotificationFactory { get; set; }

        public CityController(ICityService cityService, INotificationFactory notificationFactory)
        {
            this.CityService = cityService;
            this.NotificationFactory = notificationFactory;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = this.CityService.GetAll();

            return this.Ok(this.NotificationFactory.Success(list));
        }
    }
}