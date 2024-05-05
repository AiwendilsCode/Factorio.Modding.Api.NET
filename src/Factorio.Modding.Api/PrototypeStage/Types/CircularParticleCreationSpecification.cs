using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CircularParticleCreationSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CircularParticleCreationSpecification 
{
    [InLua("center")]
    public Vector? Center { get; set; }
	[InLua("creation_distance")]
    public double? CreationDistance { get; set; }
	[InLua("creation_distance_orientation")]
    public double? CreationDistanceOrientation { get; set; }
	[InLua("direction")]
    public float? Direction { get; set; }
	[InLua("direction_deviation")]
    public float? DirectionDeviation { get; set; }
	[InLua("height")]
    public float? Height { get; set; }
	[InLua("height_deviation")]
    public float? HeightDeviation { get; set; }
	[InLua("name")]
    public ParticleID Name { get; set; }
	[InLua("speed")]
    public float? Speed { get; set; }
	[InLua("speed_deviation")]
    public float? SpeedDeviation { get; set; }
	[InLua("starting_frame_speed")]
    public float StartingFrameSpeed { get; set; }
	[InLua("starting_frame_speed_deviation")]
    public float? StartingFrameSpeedDeviation { get; set; }
	[InLua("use_source_position")]
    public bool? UseSourcePosition { get; set; }
	[InLua("vertical_speed")]
    public float? VerticalSpeed { get; set; }
	[InLua("vertical_speed_deviation")]
    public float? VerticalSpeedDeviation { get; set; }

    
    
    
    

    

    
}