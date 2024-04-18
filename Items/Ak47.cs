using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{
    public class Ak47 : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Ranged";
        public override void SetDefaults()
        {
            Item.noMelee = true;
            Item.Size = new Vector2(50, 19);

            Item.useTime = 6;
            Item.useAnimation = 6;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item40;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.autoReuse = true;

            Item.damage = 35;
            Item.knockBack = 4;
            Item.crit = 25;
            Item.useAmmo = AmmoID.Bullet;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 10f;
            Item.DamageType = DamageClass.Ranged;
        }
        
        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "The mythical Avtomat Kalashnikova model 1947");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IllegalGunParts,1)
                .AddIngredient(ItemID.HallowedBar, 15)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient(ItemID.LeadBar, 15)
                .AddIngredient(ItemID.Wood,10)
                .AddTile(TileID.MythrilAnvil)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.IllegalGunParts,1)
                .AddIngredient(ItemID.HallowedBar,15)
                .AddIngredient(ItemID.SoulofMight,10)
                .AddIngredient(ItemID.IronBar,15)
                .AddIngredient(ItemID.Wood,10)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
   
}
