using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheArsenalV2.Items;

namespace TheArsenalV2.Items
{
    public class IceBullet : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Ammo";
        public override void SetDefaults()
        {
            Item.damage = 6;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.crit = 5;
            Item.rare = ItemRarityID.Blue;
            Item.shoot = ModContent.ProjectileType<IceBulletMain>();
            Item.shootSpeed = 20f;
            Item.ammo = AmmoID.Bullet;
        }
        
        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "Ice Bullet");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            CreateRecipe(25)
                .AddIngredient(ItemID.SnowBlock, 10)
                .AddIngredient(ItemID.IceBlock, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
            
            CreateRecipe(25)
                .AddIngredient(ItemID.SnowBlock, 10)
                .AddIngredient(ItemID.PinkIceBlock, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
            
            CreateRecipe(25)
                .AddIngredient(ItemID.SnowBlock, 10)
                .AddIngredient(ItemID.PurpleIceBlock, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
            
            CreateRecipe(25)
                .AddIngredient(ItemID.SnowBlock, 10)
                .AddIngredient(ItemID.RedIceBlock, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}