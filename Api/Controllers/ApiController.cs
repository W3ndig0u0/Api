using Microsoft.AspNetCore.Mvc;
using System;

namespace Api
{
  public class ApiController
  {

    [Route("api/[controller]")]
    [ApiController]
    public class SomethingController : ControllerBase
    {
      [HttpGet]
      public ActionResult Get()
      {
        return Ok("Hej");
      }
    }
  }
}