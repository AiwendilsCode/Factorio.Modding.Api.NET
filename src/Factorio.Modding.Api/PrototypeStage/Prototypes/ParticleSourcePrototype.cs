using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ParticleSourcePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ParticleSourcePrototype : EntityPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("height")]
    public float Height { get; set; }
	[InLua("height_deviation")]
    public float? HeightDeviation { get; set; }
	[InLua("horizontal_speed")]
    public float HorizontalSpeed { get; set; }
	[InLua("horizontal_speed_deviation")]
    public float? HorizontalSpeedDeviation { get; set; }
	[InLua("particle")]
    public ParticleID? Particle { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("time_before_start")]
    public float TimeBeforeStart { get; set; }
	[InLua("time_before_start_deviation")]
    public float? TimeBeforeStartDeviation { get; set; }
	[InLua("time_to_live")]
    public float TimeToLive { get; set; }
	[InLua("time_to_live_deviation")]
    public float? TimeToLiveDeviation { get; set; }
	[InLua("vertical_speed")]
    public float VerticalSpeed { get; set; }
	[InLua("vertical_speed_deviation")]
    public float? VerticalSpeedDeviation { get; set; }

    
    
    
    

    

    
}