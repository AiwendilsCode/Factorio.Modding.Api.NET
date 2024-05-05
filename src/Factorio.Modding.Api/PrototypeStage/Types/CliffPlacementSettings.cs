using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CliffPlacementSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CliffPlacementSettings 
{
    [InLua("cliff_elevation_0")]
    public float? CliffElevation0 { get; set; }
	[InLua("cliff_elevation_interval")]
    public float? CliffElevationInterval { get; set; }
	[InLua("name")]
    public EntityID? Name { get; set; }
	[InLua("richness")]
    public MapGenSize? Richness { get; set; }

    
    
    
    

    

    
}