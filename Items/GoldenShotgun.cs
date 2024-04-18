using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace TheArsenalV2.Items
{
    public class GoldenShotgun : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Ranged";
        public override void SetDefaults()
        {
            Item.noMelee = true;
            Item.Size = new Vector2(60, 25);

            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item36;
            Item.value = 10000;
            Item.rare = ItemRarityID.LightRed;

            Item.damage = 30;
            Item.knockBack = 6;
            Item.useAmmo = AmmoID.Bullet;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 5f;
            Item.DamageType = DamageClass.Ranged;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int numberProjectiles = Main.rand.Next(2, 4);
            for (int i = 0; i < numberProjectiles; i++)
            {
                float speedX = velocity.X;
                float speedY = velocity.Y;
                
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));

                //Projectile.NewProjectile(new EntitySource_Parent(player), position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        // Modify tooltip 
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(Mod, "Description", "Look, a shiny golden shotgun");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 15)
                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
            
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 15)
                .AddIngredient(ItemID.LeadBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
