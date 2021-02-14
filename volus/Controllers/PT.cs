using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace volus.Controllers
{
    public class PT : ControllerBase
    {
        private readonly ILogger<PT> _logger;


        public PT(ILogger<PT> logger)
        {
            _logger = logger;
        }

        [HttpGet("{path}")]
        public void DOPathTrav(String path)
        {
            System.IO.File.Delete(path);
        }


    }
}
