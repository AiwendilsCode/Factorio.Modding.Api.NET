using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SoundType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SoundType 
{
    
    public SoundTypeEnum Value { get; set; }

    
    
    
    private SoundType(SoundTypeEnum value)
    {
        Value = value;
    }

    public static implicit operator SoundType(SoundTypeEnum value) => new(value);

    
}