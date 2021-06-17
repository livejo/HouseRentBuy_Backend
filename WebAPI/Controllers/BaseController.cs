using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] // this lines are always repeated in our controllers so we create a class and drive it from here
    [ApiController]

    public class BaseController : ControllerBase
    {

    }
}
