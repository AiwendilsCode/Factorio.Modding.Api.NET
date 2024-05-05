using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StretchRule")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StretchRule 
{
    
    public StretchRuleEnum Value { get; set; }

    
    
    
    private StretchRule(StretchRuleEnum value)
    {
        Value = value;
    }

    public static implicit operator StretchRule(StretchRuleEnum value) => new(value);

    
}