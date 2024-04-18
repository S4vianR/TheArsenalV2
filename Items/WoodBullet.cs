using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheArsenalV2.Items
{
    public class WoodBullet : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Ammo";
        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.width = 10;
            Item.height = 10;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.rare = ItemRarityID.Blue;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 15f;
            Item.ammo = AmmoID.Bullet;
            Item.DamageType = DamageClass.Ranged;
        }

        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "Wood Bullet");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            CreateRecipe(25)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.WorkBenches)
                .Register();

        }
    }
}