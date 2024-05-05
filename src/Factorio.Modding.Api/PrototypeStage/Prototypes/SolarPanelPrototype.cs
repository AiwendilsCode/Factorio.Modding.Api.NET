using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SolarPanelPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SolarPanelPrototype : EntityWithOwnerPrototype
{
    [InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("overlay")]
    public SpriteVariations? Overlay { get; set; }
	[InLua("picture")]
    public SpriteVariations Picture { get; set; }
	[InLua("production")]
    public Energy Production { get; set; }

    
    
    
    

    

    
}