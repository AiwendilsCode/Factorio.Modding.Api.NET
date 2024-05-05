using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ForceCondition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ForceCondition 
{
    
    public ForceConditionEnum Value { get; set; }

    
    
    
    private ForceCondition(ForceConditionEnum value)
    {
        Value = value;
    }

    public static implicit operator ForceCondition(ForceConditionEnum value) => new(value);

    
}