using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileBuildSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileBuildSound 
{
    [InLua("large")]
    public Sound? Large { get; set; }
	[InLua("medium")]
    public Sound? Medium { get; set; }
	[InLua("small")]
    public Sound? Small { get; set; }

    
    
    
    

    

    
}