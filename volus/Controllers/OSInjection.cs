using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace volus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OSInjection : ControllerBase
    {
        [HttpGet("{binFile}")]
        public string os(string binFile)
        {
            Process p = new Process();
            p.StartInfo.FileName = binFile; // Noncompliant
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.Dispose();
            return output;
        }
    }
}
