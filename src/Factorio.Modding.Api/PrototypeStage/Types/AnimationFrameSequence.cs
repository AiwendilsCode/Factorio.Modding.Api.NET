using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimationFrameSequence")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationFrameSequence 
{
    
    public ushort[] Value { get; set; }

    
    
    
    private AnimationFrameSequence(ushort[] value)
    {
        Value = value;
    }

    public static implicit operator AnimationFrameSequence(ushort[] value) => new(value);

    
}