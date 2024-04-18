using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{

    public class GoldenSMG : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Ranged";
        public override void SetDefaults()
        {
            Item.noMelee = true;
            Item.autoReuse = true;

            Item.Size = new Vector2(40, 25);
            Item.useTime = 7;
            Item.useAnimation = 7;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item31;
            Item.rare = ItemRarityID.LightPurple;

            Item.damage = 25;
            Item.knockBack = 3;
        	Item.useAmmo = AmmoID.Bullet;
        	Item.shoot = ProjectileID.Bullet;
        	Item.shootSpeed = 8f;
	        Item.DamageType = DamageClass.Ranged;
        }
        
        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
	        TooltipLine line = new TooltipLine(Mod, "Description", "This is an expensive SMG");
	        tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
	        CreateRecipe()
		        .AddIngredient(ItemID.SoulofLight, 10)
		        .AddIngredient(ItemID.GoldBar, 15)
		        .AddIngredient(ItemID.LeadBar, 7)
		        .AddTile(TileID.Anvils)
		        .Register();
        	
	        CreateRecipe()
		        .AddIngredient(ItemID.SoulofLight, 10)
		        .AddIngredient(ItemID.GoldBar, 15)
		        .AddIngredient(ItemID.IronBar, 7)
		        .AddTile(TileID.Anvils)
		        .Register();
        }

    }
}