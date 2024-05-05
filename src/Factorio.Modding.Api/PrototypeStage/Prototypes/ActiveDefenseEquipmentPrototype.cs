using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ActiveDefenseEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ActiveDefenseEquipmentPrototype : EquipmentPrototype
{
    [InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("automatic")]
    public bool Automatic { get; set; }

    
    
    
    

    

    
}