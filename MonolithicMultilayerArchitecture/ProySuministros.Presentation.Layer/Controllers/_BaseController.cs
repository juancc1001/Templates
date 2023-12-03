using Microsoft.AspNetCore.Mvc;

namespace ProySuministros.Presentation.Layer.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    public abstract class _BaseController : ControllerBase
    {
        protected const string BasePath = "ProySuministros";
    }
}
