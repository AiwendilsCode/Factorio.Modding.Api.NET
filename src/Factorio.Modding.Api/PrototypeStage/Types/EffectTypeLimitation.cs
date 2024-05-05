using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EffectTypeLimitation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EffectTypeLimitation 
{
    
    public OneOf<EffectTypeLimitationEnum, EffectTypeLimitationEnum[]> Value { get; set; }

    
    
    
    private EffectTypeLimitation(EffectTypeLimitationEnum value)
    {
        Value = value;
    }

	private EffectTypeLimitation(EffectTypeLimitationEnum[] value)
    {
        Value = value;
    }

    public static implicit operator EffectTypeLimitation(EffectTypeLimitationEnum value) => new(value);

	public static implicit operator EffectTypeLimitation(EffectTypeLimitationEnum[] value) => new(value);

    
}