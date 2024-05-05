using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("IconMipMapType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class IconMipMapType 
{
    
    public byte Value { get; set; }

    
    
    
    private IconMipMapType(byte value)
    {
        Value = value;
    }

    public static implicit operator IconMipMapType(byte value) => new(value);

    
}