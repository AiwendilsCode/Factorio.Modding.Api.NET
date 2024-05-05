using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EnergyShieldEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EnergyShieldEquipmentPrototype : EquipmentPrototype
{
    [InLua("energy_per_shield")]
    public Energy EnergyPerShield { get; set; }
	[InLua("max_shield_value")]
    public float MaxShieldValue { get; set; }

    
    
    
    

    

    
}