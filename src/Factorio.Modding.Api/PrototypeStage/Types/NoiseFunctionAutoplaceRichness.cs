using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseFunctionAutoplaceRichness")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionAutoplaceRichness 
{
    [InLua("arguments")]
    public NoiseLiteralObject Arguments { get; set; }
	[InLua("function_name")]
    public string FunctionName { get; } = "autoplace-richness";
	[InLua("type")]
    public string Type { get; } = "function-application";

    
    
    
    

    

    
}