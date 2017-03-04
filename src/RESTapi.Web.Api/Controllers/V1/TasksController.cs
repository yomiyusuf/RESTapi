﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTapi.Web.Common.Routing;
using RESTapi.Web.Api.Models;

namespace RESTapi.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        [Route("", Name = "AddTaskRoute")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage requestMessage, Task newTask)
        {
            return  new Task
            {
                Subject = "In v1, newTask.Subject = " + newTask.Subject
            };
        }
    }
}
