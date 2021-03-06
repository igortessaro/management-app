﻿using Management.Domain.Dtos.Customer;
using Management.Domain.Factories;
using Management.Domain.Services;
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

        [HttpPost]
        public IActionResult Find(CustomerFilterDto customerFilter)
        {
            var list = this.CustomerService.Find(customerFilter);

            return this.Ok(this.NotificationFactory.Success(list));
        }
    }
}