using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ItemPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemPrototype : PrototypeBase
{
    [InLua("burnt_result")]
    public ItemID? BurntResult { get; set; }
	[InLua("close_sound")]
    public Sound? CloseSound { get; set; }
	[InLua("dark_background_icon")]
    public FileName? DarkBackgroundIcon { get; set; }
	[InLua("dark_background_icons")]
    public IconData[]? DarkBackgroundIcons { get; set; }
	[InLua("default_request_amount")]
    public ItemCountType? DefaultRequestAmount { get; set; }
	[InLua("flags")]
    public ItemPrototypeFlags? Flags { get; set; }
	[InLua("fuel_acceleration_multiplier")]
    public double? FuelAccelerationMultiplier { get; set; }
	[InLua("fuel_category")]
    public FuelCategoryID? FuelCategory { get; set; }
	[InLua("fuel_emissions_multiplier")]
    public double? FuelEmissionsMultiplier { get; set; }
	[InLua("fuel_glow_color")]
    public Color? FuelGlowColor { get; set; }
	[InLua("fuel_top_speed_multiplier")]
    public double? FuelTopSpeedMultiplier { get; set; }
	[InLua("fuel_value")]
    public Energy? FuelValue { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("open_sound")]
    public Sound? OpenSound { get; set; }
	[InLua("pictures")]
    public SpriteVariations? Pictures { get; set; }
	[InLua("place_as_tile")]
    public PlaceAsTile? PlaceAsTile { get; set; }
	[InLua("place_result")]
    public EntityID? PlaceResult { get; set; }
	[InLua("placed_as_equipment_result")]
    public EquipmentID? PlacedAsEquipmentResult { get; set; }
	[InLua("rocket_launch_product")]
    public ItemProductPrototype? RocketLaunchProduct { get; set; }
	[InLua("rocket_launch_products")]
    public ItemProductPrototype[]? RocketLaunchProducts { get; set; }
	[InLua("stack_size")]
    public ItemCountType StackSize { get; set; }
	[InLua("subgroup")]
    public ItemSubGroupID? Subgroup { get; set; }
	[InLua("wire_count")]
    public ItemCountType? WireCount { get; set; }

    
    
    
    

    

    
}