using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BurnerEnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BurnerEnergySource : BaseEnergySource
{
    [InLua("burnt_inventory_size")]
    public ItemStackIndex? BurntInventorySize { get; set; }
	[InLua("effectivity")]
    public double? Effectivity { get; set; }
	[InLua("fuel_categories")]
    public FuelCategoryID[]? FuelCategories { get; set; }
	[InLua("fuel_category")]
    public FuelCategoryID? FuelCategory { get; set; }
	[InLua("fuel_inventory_size")]
    public ItemStackIndex FuelInventorySize { get; set; }
	[InLua("light_flicker")]
    public LightFlickeringDefinition? LightFlicker { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("type")]
    public string? Type { get; } = "burner";

    
    
    
    

    

    
}