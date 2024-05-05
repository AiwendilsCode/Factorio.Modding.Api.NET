using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("GeneratorEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GeneratorEquipmentPrototype : EquipmentPrototype
{
    [InLua("burner")]
    public BurnerEnergySource? Burner { get; set; }
	[InLua("power")]
    public Energy Power { get; set; }

    
    
    
    

    

    
}