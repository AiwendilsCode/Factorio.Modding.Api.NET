using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateTrivialSmokeEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateTrivialSmokeEffectItem : TriggerEffectItem
{
    [InLua("initial_height")]
    public float? InitialHeight { get; set; }
	[InLua("max_radius")]
    public float? MaxRadius { get; set; }
	[InLua("offset_deviation")]
    public BoundingBox? OffsetDeviation { get; set; }
	[InLua("offsets")]
    public OneOf<Vector, Vector[]>? Offsets { get; set; }
	[InLua("smoke_name")]
    public TrivialSmokeID SmokeName { get; set; }
	[InLua("speed")]
    public Vector? Speed { get; set; }
	[InLua("speed_from_center")]
    public float? SpeedFromCenter { get; set; }
	[InLua("speed_from_center_deviation")]
    public float? SpeedFromCenterDeviation { get; set; }
	[InLua("speed_multiplier")]
    public float? SpeedMultiplier { get; set; }
	[InLua("speed_multiplier_deviation")]
    public float? SpeedMultiplierDeviation { get; set; }
	[InLua("starting_frame")]
    public float? StartingFrame { get; set; }
	[InLua("starting_frame_deviation")]
    public float? StartingFrameDeviation { get; set; }
	[InLua("starting_frame_speed")]
    public float? StartingFrameSpeed { get; set; }
	[InLua("starting_frame_speed_deviation")]
    public float? StartingFrameSpeedDeviation { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-trivial-smoke";

    
    
    
    

    

    
}