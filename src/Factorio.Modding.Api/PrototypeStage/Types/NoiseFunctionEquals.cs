using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionEquals")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionEquals 
{
    [InLua("arguments")]
    public (NoiseNumber, NoiseNumber) Arguments { get; set; }
	[InLua("function_name")]
    public string FunctionName { get; } = "equals";
	[InLua("type")]
    public string Type { get; } = "function-application";

    
    
    
    

    

    
}