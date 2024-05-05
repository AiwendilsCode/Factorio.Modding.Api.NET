using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("WirePosition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WirePosition 
{
    [InLua("copper")]
    public Vector? Copper { get; set; }
	[InLua("green")]
    public Vector? Green { get; set; }
	[InLua("red")]
    public Vector? Red { get; set; }

    
    
    
    

    

    
}