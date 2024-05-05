using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseArrayConstruction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseArrayConstruction 
{
    [InLua("type")]
    public string Type { get; } = "array-construction";
	[InLua("value_expressions")]
    public NoiseExpression[] ValueExpressions { get; set; }

    
    
    
    

    

    
}