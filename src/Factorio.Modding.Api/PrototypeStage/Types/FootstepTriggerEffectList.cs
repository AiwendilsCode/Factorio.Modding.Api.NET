using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FootstepTriggerEffectList")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FootstepTriggerEffectList 
{
    
    public FootstepTriggerEffectItem[] Value { get; set; }

    
    
    
    private FootstepTriggerEffectList(FootstepTriggerEffectItem[] value)
    {
        Value = value;
    }

    public static implicit operator FootstepTriggerEffectList(FootstepTriggerEffectItem[] value) => new(value);

    
}