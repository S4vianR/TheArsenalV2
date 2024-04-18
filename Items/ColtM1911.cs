using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{
	public class ColtM1911 : ModItem, ILocalizedModType
	{
		public new string LocalizationCategory => "Items.Weapons.Ranged";
		public override void SetDefaults() 
		{
			Item.damage = 15;
			Item.noMelee = true;
			Item.Size = new Vector2(30,		19);
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = false;

			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileID.Bullet;
			Item.shootSpeed = 8f;
			Item.DamageType = DamageClass.Ranged;
		}
		
		// Modify tooltip 
		public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> tooltips)
		{
			TooltipLine line = new TooltipLine(Mod, "Description", "This is the unique M1911");
			tooltips.Add(line);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LeadBar, 10)
				.AddIngredient(ItemID.Wood, 5)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe()
				.AddIngredient(ItemID.IronBar, 10)
				.AddIngredient(ItemID.Wood, 5)
				.AddTile(TileID.Anvils)
				.Register();

		}
	}
}