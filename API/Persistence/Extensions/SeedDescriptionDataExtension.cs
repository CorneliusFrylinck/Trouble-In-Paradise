using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Extensions
{
    public static class SeedDescriptionDataExtension
    {
        public static ModelBuilder SeedDescriptionData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Description>().HasData(
                new Description(TargetTypeEnum.Resource, "cement", "Resource used for building and upgrading buildings.", 1),
                new Description(TargetTypeEnum.Resource, "metal", "Resource used for building and upgrading buildings, and units.", 2),
                new Description(TargetTypeEnum.Resource, "lumber", "Resource used for building and upgrading buildings.", 3),
                new Description(TargetTypeEnum.Resource, "water", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 4),
                new Description(TargetTypeEnum.Resource, "food", "Resource used to keep units and workers alive.", 5),
                new Description(TargetTypeEnum.Resource, "oxygen", "Resource used for building and upgrading buildings.", 6),
                new Description(TargetTypeEnum.Resource, "blue_crystal", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 7),
                new Description(TargetTypeEnum.Resource, "red_crystal", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional. This resource is poweful but difficult to find and mine.", 8),
                new Description(TargetTypeEnum.Resource, "gold", "Resource rarely found in mines. Used to queue building and unit upgrades", 9),
                new Description(TargetTypeEnum.Building, "command centre", "This is your center of communication. Upgrading this building can also unlock new options on other buildings.", 10),
                new Description(TargetTypeEnum.Building, "guild hub", "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.", 11),
                new Description(TargetTypeEnum.Building, "barracks", "This is where you build your army. Build units and assign them to squads.", 12),
                new Description(TargetTypeEnum.Building, "warroom", "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.", 13),
                new Description(TargetTypeEnum.Building, "navigational unit", "This building is used to view the area around you.", 14),
                new Description(TargetTypeEnum.Building, "radar", "This building picks up enemy attacks and any troop movement to your base.", 15),
                new Description(TargetTypeEnum.Building, "medical facility", "This building is used to heal your troops after they get hurt.", 16),
                new Description(TargetTypeEnum.Building, "research facility", "This building is used to unlock new units and abilities.", 17),
                new Description(TargetTypeEnum.Building, "tradepost", "This building is used to send resources to other players.", 18),
                new Description(TargetTypeEnum.Building, "market", "This building is used to trade resources with locals of the new planet.", 19),
                new Description(TargetTypeEnum.Building, "silos", "Upgrade these buildings to increase your resource storage capabilities.", 20),
                new Description(TargetTypeEnum.Building, "vaults", "These buildings are used to protect your resources from raiders.", 21),
                new Description(TargetTypeEnum.Building, "bunkers", "These buildings offer protection to your ranged units when defending.", 22),
                new Description(TargetTypeEnum.Building, "shield", "Your shield offers all units and buildings protection when you are being attacked.", 23)
            );

            return modelBuilder;
        }
    }
}
