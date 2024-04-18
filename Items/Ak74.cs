using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{
    public class Ak74 : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Ranged";
        public override void SetDefaults()
        {
            Item.noMelee = true;
            Item.Size = new Vector2(40, 21);

            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item40;
            Item.value = 10000;
            Item.rare = ItemRarityID.Lime;
            Item.autoReuse = true;

            Item.damage = 10;
            Item.knockBack = 3;
            Item.useAmmo = AmmoID.Bullet;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 7f;
            Item.DamageType = DamageClass.Ranged;

        }

        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "The Avtomat Kalashnikova model 1974");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            /*
             * CreateRecipe()
               .AddIngredient(ItemID.IllegalGunParts)
               .AddIngredient(ItemID.HallowedBar, 15)
               .AddIngredient(ItemID.SoulofMight, 10)
               .AddIngredient(ItemID.LeadBar, 15)
               .AddIngredient(ItemID.Wood,10)
               .AddTile(ItemID.MythrilAnvil)
               .Register();
             */

            CreateRecipe()
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.IronBar, 15)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.IronBar, 15)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();

        }
    }

}
