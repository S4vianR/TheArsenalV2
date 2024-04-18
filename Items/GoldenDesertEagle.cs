using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{
    public class GoldenDesertEagle : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Ranged";
        public override void SetDefaults()
        {
            Item.noMelee = true;
            Item.Size = new Vector2(40, 27);

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = false;

            Item.damage = 60;
            Item.crit = 50;
            Item.knockBack = 5;
            Item.useAmmo = AmmoID.Bullet;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 20f;
            Item.DamageType = DamageClass.Ranged;
        }
        
        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "Be careful with this one");
            tooltips.Add(line);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SoulofMight, 5)
                .AddIngredient(ItemID.SoulofNight, 5)
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.LeadBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
            
            CreateRecipe()
                .AddIngredient(ItemID.SoulofMight, 5)
                .AddIngredient(ItemID.SoulofNight, 5)
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.IronBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
