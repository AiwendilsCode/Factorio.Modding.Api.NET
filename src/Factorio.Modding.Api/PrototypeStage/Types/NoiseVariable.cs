using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseVariable")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseVariable 
{
    [InLua("type")]
    public string Type { get; } = "variable";
	[InLua("variable_name")]
    public OneOf<NoiseVariableConstants, BaseNamedNoiseExpressions, string, VariableNameEnum> VariableName { get; set; }

    
    
    
    

    

    
}