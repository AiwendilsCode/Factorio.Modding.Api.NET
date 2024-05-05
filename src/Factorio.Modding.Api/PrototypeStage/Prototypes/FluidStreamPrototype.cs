using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FluidStreamPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidStreamPrototype : EntityPrototype
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("ground_light")]
    public LightDefinition? GroundLight { get; set; }
	[InLua("initial_action")]
    public Trigger? InitialAction { get; set; }
	[InLua("oriented_particle")]
    public bool? OrientedParticle { get; set; }
	[InLua("particle")]
    public Animation? Particle { get; set; }
	[InLua("particle_alpha_per_part")]
    public float? ParticleAlphaPerPart { get; set; }
	[InLua("particle_buffer_size")]
    public uint? ParticleBufferSize { get; set; }
	[InLua("particle_end_alpha")]
    public float? ParticleEndAlpha { get; set; }
	[InLua("particle_fade_out_duration")]
    public ushort? ParticleFadeOutDuration { get; set; }
	[InLua("particle_fade_out_threshold")]
    public float? ParticleFadeOutThreshold { get; set; }
	[InLua("particle_horizontal_speed")]
    public float ParticleHorizontalSpeed { get; set; }
	[InLua("particle_horizontal_speed_deviation")]
    public float ParticleHorizontalSpeedDeviation { get; set; }
	[InLua("particle_loop_exit_threshold")]
    public float? ParticleLoopExitThreshold { get; set; }
	[InLua("particle_loop_frame_count")]
    public ushort? ParticleLoopFrameCount { get; set; }
	[InLua("particle_scale_per_part")]
    public float? ParticleScalePerPart { get; set; }
	[InLua("particle_spawn_interval")]
    public ushort ParticleSpawnInterval { get; set; }
	[InLua("particle_spawn_timeout")]
    public ushort? ParticleSpawnTimeout { get; set; }
	[InLua("particle_start_alpha")]
    public float? ParticleStartAlpha { get; set; }
	[InLua("particle_start_scale")]
    public float? ParticleStartScale { get; set; }
	[InLua("particle_vertical_acceleration")]
    public float ParticleVerticalAcceleration { get; set; }
	[InLua("progress_to_create_smoke")]
    public float? ProgressToCreateSmoke { get; set; }
	[InLua("shadow")]
    public Animation? Shadow { get; set; }
	[InLua("shadow_scale_enabled")]
    public bool? ShadowScaleEnabled { get; set; }
	[InLua("smoke_sources")]
    public SmokeSource[]? SmokeSources { get; set; }
	[InLua("special_neutral_target_damage")]
    public DamagePrototype? SpecialNeutralTargetDamage { get; set; }
	[InLua("spine_animation")]
    public Animation? SpineAnimation { get; set; }
	[InLua("stream_light")]
    public LightDefinition? StreamLight { get; set; }
	[InLua("target_position_deviation")]
    public double? TargetPositionDeviation { get; set; }
	[InLua("width")]
    public float? Width { get; set; }

    
    
    
    

    

    
}