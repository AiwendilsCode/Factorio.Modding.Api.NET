using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EquipmentPrototype : PrototypeBase
{
    [InLua("background_border_color")]
    public Color? BackgroundBorderColor { get; set; }
	[InLua("background_color")]
    public Color? BackgroundColor { get; set; }
	[InLua("categories")]
    public EquipmentCategoryID[] Categories { get; set; }
	[InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("grabbed_background_color")]
    public Color? GrabbedBackgroundColor { get; set; }
	[InLua("shape")]
    public EquipmentShape Shape { get; set; }
	[InLua("sprite")]
    public Sprite Sprite { get; set; }
	[InLua("take_result")]
    public ItemID? TakeResult { get; set; }

    
    
    
    

    

    
}