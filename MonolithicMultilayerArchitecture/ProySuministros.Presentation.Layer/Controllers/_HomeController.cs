using Microsoft.AspNetCore.Mvc;

namespace ProySuministros.Presentation.Layer.Controllers
{
    public class _HomeController : _BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Hand Held web api net 6.0 v1";
    }
}
