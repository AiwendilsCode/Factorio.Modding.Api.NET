using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseProcedureDelimiter")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseProcedureDelimiter 
{
    [InLua("expression")]
    public NoiseExpression Expression { get; set; }
	[InLua("type")]
    public string Type { get; } = "procedure-delimiter";

    
    
    
    

    

    
}