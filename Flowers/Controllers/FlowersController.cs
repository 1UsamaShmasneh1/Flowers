using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flowers.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        public string Aster()
        {
            return "Aster";
        }
        public string Azalea()
        {
            return "Azalea";
        }
        public string Carnations()
        {
            return "Carnations";
        }
        public string Crocus()
        {
            return "Crocus";
        }
    }
}
