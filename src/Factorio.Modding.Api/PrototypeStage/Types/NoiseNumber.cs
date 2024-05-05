using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseNumber")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseNumber 
{
    
    public NoiseNumberTypes Value { get; set; }

    
    
    
    private NoiseNumber(NoiseNumberTypes value)
    {
        Value = value;
    }

    public static implicit operator NoiseNumber(NoiseNumberTypes value) => new(value);

    
}