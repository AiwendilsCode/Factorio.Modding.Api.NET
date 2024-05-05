using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseVariableConstants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseVariableConstants 
{
    
    public OneOf<string, NoiseVariableConstantsEnum> Value { get; set; }

    
    
    
    private NoiseVariableConstants(string value)
    {
        Value = value;
    }

	private NoiseVariableConstants(NoiseVariableConstantsEnum value)
    {
        Value = value;
    }

    public static implicit operator NoiseVariableConstants(string value) => new(value);

	public static implicit operator NoiseVariableConstants(NoiseVariableConstantsEnum value) => new(value);

    
}