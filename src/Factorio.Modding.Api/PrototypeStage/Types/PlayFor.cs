using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PlayFor")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlayFor 
{
    
    public PlayForEnum Value { get; set; }

    
    
    
    private PlayFor(PlayForEnum value)
    {
        Value = value;
    }

    public static implicit operator PlayFor(PlayForEnum value) => new(value);

    
}