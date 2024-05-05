using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("MovementBonusEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MovementBonusEquipmentPrototype : EquipmentPrototype
{
    [InLua("energy_consumption")]
    public Energy EnergyConsumption { get; set; }
	[InLua("movement_bonus")]
    public double MovementBonus { get; set; }

    
    
    
    

    

    
}