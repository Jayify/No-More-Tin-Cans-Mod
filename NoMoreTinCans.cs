using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace NoMoreTinCans;

public class NoMoreTinCans : Mod
{
    public override void AddRecipes()
    {
        // Remove all recipes for metal armours
        foreach (var recipe in Main.recipe.Where(r =>
            r != null && (
            r.createItem.type == ItemID.CopperHelmet || r.createItem.type == ItemID.CopperChainmail || r.createItem.type == ItemID.CopperGreaves || // Copper
            r.createItem.type == ItemID.TinHelmet || r.createItem.type == ItemID.TinChainmail || r.createItem.type == ItemID.TinGreaves || // Tin
            r.createItem.type == ItemID.IronHelmet || r.createItem.type == ItemID.IronChainmail || r.createItem.type == ItemID.IronGreaves || // Iron
            r.createItem.type == ItemID.LeadHelmet || r.createItem.type == ItemID.LeadChainmail || r.createItem.type == ItemID.LeadGreaves || // Lead
            r.createItem.type == ItemID.SilverHelmet || r.createItem.type == ItemID.SilverChainmail || r.createItem.type == ItemID.SilverGreaves || // Silver
            r.createItem.type == ItemID.TungstenHelmet || r.createItem.type == ItemID.TungstenChainmail || r.createItem.type == ItemID.TungstenGreaves || // Tungsten
            r.createItem.type == ItemID.GoldHelmet || r.createItem.type == ItemID.GoldChainmail || r.createItem.type == ItemID.GoldGreaves || // Gold
            r.createItem.type == ItemID.PlatinumHelmet || r.createItem.type == ItemID.PlatinumChainmail || r.createItem.type == ItemID.PlatinumGreaves // Platinum
            )
        ))
        {
            recipe.DisableRecipe();
        }
    }
}
