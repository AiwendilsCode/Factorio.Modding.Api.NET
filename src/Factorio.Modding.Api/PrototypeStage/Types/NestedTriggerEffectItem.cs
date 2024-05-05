using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NestedTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NestedTriggerEffectItem : TriggerEffectItem
{
    [InLua("action")]
    public Trigger Action { get; set; }
	[InLua("type")]
    public string Type { get; } = "nested-result";

    
    
    
    

    

    
}