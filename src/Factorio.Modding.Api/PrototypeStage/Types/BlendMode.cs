using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BlendMode")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BlendMode 
{
    
    public BlendModeEnum Value { get; set; }

    
    
    
    private BlendMode(BlendModeEnum value)
    {
        Value = value;
    }

    public static implicit operator BlendMode(BlendModeEnum value) => new(value);

    
}