using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AmbientSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmbientSound 
{
    [InLua("name")]
    public string Name { get; set; }
	[InLua("sound")]
    public Sound Sound { get; set; }
	[InLua("track_type")]
    public TrackTypeEnum TrackType { get; set; }
	[InLua("type")]
    public string Type { get; } = "ambient-sound";
	[InLua("weight")]
    public double? Weight { get; set; }

    
    
    
    

    

    
}