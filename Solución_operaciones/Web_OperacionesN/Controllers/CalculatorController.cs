﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_OperacionesN.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        public int suma(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        public int sumar([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }

    }
}
