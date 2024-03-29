﻿using System;
using DemoWriteApi.Services;
using DemoWriteApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWriteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriteController : ControllerBase
    {
        protected IWriteService writeService;
        public WriteController(IWriteService writeService)
        {
            this.writeService = writeService;
        }

        // POST api/write
        [HttpPost]
        public void Post(WriteRequest request)
        {
            writeService.WriteData(request);
        }
    }
}
