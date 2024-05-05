using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FlameThrowerExplosionTriggerDelivery")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FlameThrowerExplosionTriggerDelivery : TriggerDeliveryItem
{
    [InLua("direction_deviation")]
    public double? DirectionDeviation { get; set; }
	[InLua("explosion")]
    public EntityID Explosion { get; set; }
	[InLua("projectile_starting_speed")]
    public double? ProjectileStartingSpeed { get; set; }
	[InLua("speed_deviation")]
    public double? SpeedDeviation { get; set; }
	[InLua("starting_distance")]
    public double StartingDistance { get; set; }
	[InLua("starting_frame_fraciton_deviation")]
    public double? StartingFrameFracitonDeviation { get; set; }
	[InLua("type")]
    public string Type { get; } = "flame-thrower";

    
    
    
    

    

    
}