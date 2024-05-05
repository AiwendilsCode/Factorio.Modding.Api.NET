using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateParticleTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateParticleTriggerEffectItem : TriggerEffectItem
{
    [InLua("frame_speed")]
    public float? FrameSpeed { get; set; }
	[InLua("frame_speed_deviation")]
    public float? FrameSpeedDeviation { get; set; }
	[InLua("initial_height")]
    public float InitialHeight { get; set; }
	[InLua("initial_height_deviation")]
    public float? InitialHeightDeviation { get; set; }
	[InLua("initial_vertical_speed")]
    public float? InitialVerticalSpeed { get; set; }
	[InLua("initial_vertical_speed_deviation")]
    public float? InitialVerticalSpeedDeviation { get; set; }
	[InLua("offset_deviation")]
    public BoundingBox? OffsetDeviation { get; set; }
	[InLua("offsets")]
    public OneOf<Vector, Vector[]>? Offsets { get; set; }
	[InLua("particle_name")]
    public ParticleID ParticleName { get; set; }
	[InLua("rotate_offsets")]
    public bool? RotateOffsets { get; set; }
	[InLua("show_in_tooltip")]
    public bool? ShowInTooltip { get; set; }
	[InLua("speed_from_center")]
    public float? SpeedFromCenter { get; set; }
	[InLua("speed_from_center_deviation")]
    public float? SpeedFromCenterDeviation { get; set; }
	[InLua("tail_length")]
    public byte? TailLength { get; set; }
	[InLua("tail_length_deviation")]
    public byte? TailLengthDeviation { get; set; }
	[InLua("tail_width")]
    public float? TailWidth { get; set; }
	[InLua("tile_collision_mask")]
    public CollisionMask? TileCollisionMask { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-particle";

    
    
    
    

    

    
}