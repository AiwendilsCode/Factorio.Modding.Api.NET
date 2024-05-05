using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateFireTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateFireTriggerEffectItem : CreateEntityTriggerEffectItem
{
    [InLua("initial_ground_flame_count")]
    public byte? InitialGroundFlameCount { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-fire";

    
    
    
    

    

    
}