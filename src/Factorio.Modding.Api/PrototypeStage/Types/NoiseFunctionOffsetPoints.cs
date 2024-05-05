using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionOffsetPoints")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionOffsetPoints 
{
    [InLua("arguments")]
    public (NoiseArrayConstruction, NoiseArrayConstruction) Arguments { get; set; }
	[InLua("function_name")]
    public string FunctionName { get; } = "offset-points";
	[InLua("type")]
    public string Type { get; } = "function-application";

    
    
    
    

    

    
}