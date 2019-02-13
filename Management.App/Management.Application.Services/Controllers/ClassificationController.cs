﻿using Management.Domain.Factories;
using Management.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Management.Application.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificationController : ControllerBase
    {
        public IClassificationService service { get; set; }

        public INotificationFactory NotificationFactory { get; set; }

        public ClassificationController(IClassificationService cityService, INotificationFactory notificationFactory)
        {
            this.service = cityService;
            this.NotificationFactory = notificationFactory;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = this.service.GetAll();

            return this.Ok(this.NotificationFactory.Success(list));
        }
    }
}