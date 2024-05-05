using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpritePriority")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpritePriority 
{
    
    public SpritePriorityEnum Value { get; set; }

    
    
    
    private SpritePriority(SpritePriorityEnum value)
    {
        Value = value;
    }

    public static implicit operator SpritePriority(SpritePriorityEnum value) => new(value);

    
}