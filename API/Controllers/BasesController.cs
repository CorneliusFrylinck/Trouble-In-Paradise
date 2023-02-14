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

            Building b1 = new Building("Command Centre", "This is your center of communication. Upgrading this building can also unlock new options on other buildings.", 1, 1);
            Building b2 = new Building("Guild Hub", "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.", 1, 2);
            Building b4 = new Building("Barracks", "This is where you build your army. Build units and assign them to squads.", 1, 4);
            Building b13 = new Building("Warroom", "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.", 1, 13);
            Building b14 = new Building("Navigational Unit", "This building is used to view the area around you.", 1, 14);
            Building b3 = new Building("Radar", "This building picks up enemy attacks and any troop movement to your base.", 1, 3);
            Building b5 = new Building("Medical Facility", "This building is used to heal your troops after they get hurt.", 1, 5);
            Building b6 = new Building("Research Facility", "This building is used to unlock new units and abilities.", 1, 6);
            Building b7 = new Building("Tradepost", "This building is used to send resources to other players.", 1, 7);
            Building b8 = new Building("Market", "This building is used to trade resources with locals of the new planet.", 1, 8);
            Building b9 = new Building("Silos", "Upgrade these buildings to increase your resource storage capabilities.", 1, 9);
            Building b10 = new Building("Vaults", "These buildings are used to protect your resources from raiders.", 1, 10);
            Building b11 = new Building("Bunkers", "These buildings offer protection to your ranged units when defending.", 1, 11);
            Building b12 = new Building("Shield", "Your shield offers all units and buildings protection when you are being attacked.", 1, 12);

            ICollection<Building> buildings = new List<Building>() { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14 };

            var base1 = new Base("MyBase")
            {
                ResourceBuildings = new List<ResourceItem>()
                {
                    item1, item2, item3, item4, item5, item6, item7, item8
                },
                Resources = resourceStore,
                Buildings = buildings
            };

            return Ok(base1);
        }
    }
}
