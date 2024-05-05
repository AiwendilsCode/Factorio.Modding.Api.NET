using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeaconVisualizationTints")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeaconVisualizationTints 
{
    [InLua("primary")]
    public Color? Primary { get; set; }
	[InLua("quaternary")]
    public Color? Quaternary { get; set; }
	[InLua("secondary")]
    public Color? Secondary { get; set; }
	[InLua("tertiary")]
    public Color? Tertiary { get; set; }

    
    
    
    

    

    
}