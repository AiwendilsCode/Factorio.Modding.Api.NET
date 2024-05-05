using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SmokeWithTriggerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SmokeWithTriggerPrototype : SmokePrototype
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("action_cooldown")]
    public uint? ActionCooldown { get; set; }
	[InLua("particle_count")]
    public byte? ParticleCount { get; set; }
	[InLua("particle_distance_scale_factor")]
    public float? ParticleDistanceScaleFactor { get; set; }
	[InLua("particle_duration_variation")]
    public uint? ParticleDurationVariation { get; set; }
	[InLua("particle_scale_factor")]
    public Vector? ParticleScaleFactor { get; set; }
	[InLua("particle_spread")]
    public Vector? ParticleSpread { get; set; }
	[InLua("spread_duration_variation")]
    public uint? SpreadDurationVariation { get; set; }
	[InLua("wave_distance")]
    public Vector? WaveDistance { get; set; }
	[InLua("wave_speed")]
    public Vector? WaveSpeed { get; set; }

    
    
    
    

    

    
}