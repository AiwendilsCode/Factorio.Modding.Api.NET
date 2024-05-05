using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpriteFlags")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpriteFlags 
{
    
    public SpriteFlagsEnum[] Value { get; set; }

    
    
    
    private SpriteFlags(SpriteFlagsEnum[] value)
    {
        Value = value;
    }

    public static implicit operator SpriteFlags(SpriteFlagsEnum[] value) => new(value);

    
}