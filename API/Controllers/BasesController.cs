using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Base>> GetBase()
        {
            ResourceItem item1 = new ResourceItem("Cement", "Resource used for building and upgrading buildings.", 0, 100, 1);
            ResourceItem item2 = new ResourceItem("Metal", "Resource used for building and upgrading buildings, and units.", 0, 100, 2);
            ResourceItem item3 = new ResourceItem("Lumber", "Resource used for building and upgrading buildings.", 0, 100, 3);
            ResourceItem item4 = new ResourceItem("Water", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 0, 4);
            ResourceItem item5 = new ResourceItem("Food", "Resource used to keep players alive.", 0, 100, 5);
            ResourceItem item6 = new ResourceItem("Oxygen", "Resource used for building and upgrading buildings.", 0, 100, 6);
            ResourceItem item7 = new ResourceItem("Crystal_Blue", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 100, 7);
            ResourceItem item8 = new ResourceItem("Crystal_Red", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 100, 8);

            ResourceStore resourceStore = new ResourceStore();

            var base1 = new Base("MyBase")
            {
                ResourceBuildings = new List<ResourceItem>()
                {
                    item1, item2, item3, item4, item5, item6, item7, item8
                },
                Resources = resourceStore
            };

            return Ok(base1);
        }
    }
}
