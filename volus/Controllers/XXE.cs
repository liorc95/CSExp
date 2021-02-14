using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml;

namespace volus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XXE : ControllerBase
    {

        [HttpGet("{xmlString}")]
        public void Xxe(String xmlString)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
        }
    }
}
