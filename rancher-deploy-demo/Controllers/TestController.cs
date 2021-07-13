using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rancher_deploy_demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {     
        private readonly ILogger<TestController> _logger;
        private readonly AppSetting _appSetting;

        public TestController(ILogger<TestController> logger,IOptions<AppSetting> appSetting)
        {
            _logger = logger;
            _appSetting = appSetting.Value;
        }

        [HttpGet]
        public string Get()
        {
            if (_appSetting == null)
                return "appSetting is null";
            return $"Env:{ _appSetting.Env}";
        }
    }
}
