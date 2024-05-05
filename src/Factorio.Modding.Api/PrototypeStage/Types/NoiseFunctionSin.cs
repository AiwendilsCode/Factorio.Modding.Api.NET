using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionSin")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionSin 
{
    [InLua("arguments")]
    public NoiseNumber Arguments { get; set; }
	[InLua("function_name")]
    public string FunctionName { get; } = "sin";
	[InLua("type")]
    public string Type { get; } = "function-application";

    
    
    
    

    

    
}