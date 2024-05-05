using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpriteSizeType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpriteSizeType 
{
    
    public short Value { get; set; }

    
    
    
    private SpriteSizeType(short value)
    {
        Value = value;
    }

    public static implicit operator SpriteSizeType(short value) => new(value);

    
}