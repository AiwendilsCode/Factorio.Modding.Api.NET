using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionApplication")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionApplication 
{
    
    public NoiseFunctionApplicationTypes Value { get; set; }

    
    
    
    private NoiseFunctionApplication(NoiseFunctionApplicationTypes value)
    {
        Value = value;
    }

    public static implicit operator NoiseFunctionApplication(NoiseFunctionApplicationTypes value) => new(value);

    
}