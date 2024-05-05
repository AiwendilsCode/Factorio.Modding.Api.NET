using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionFactorioBasisNoise")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionFactorioBasisNoise 
{
    [InLua("arguments")]
    public FactorioBasisNoiseArguments Arguments { get; set; }
	[InLua("function_name")]
    public string FunctionName { get; } = "factorio-basis-noise";
	[InLua("type")]
    public string Type { get; } = "function-application";

    
    
    
    

    

    
}