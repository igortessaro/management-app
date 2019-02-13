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
    public class CustomerController : ControllerBase
    {
        public ICustomerService CustomerService { get; set; }

        public INotificationFactory NotificationFactory { get; set; }

        public CustomerController(ICustomerService cityService, INotificationFactory notificationFactory)
        {
            this.CustomerService = cityService;
            this.NotificationFactory = notificationFactory;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = this.CustomerService.Find();

            return this.Ok(this.NotificationFactory.Success(list));
        }
    }
}