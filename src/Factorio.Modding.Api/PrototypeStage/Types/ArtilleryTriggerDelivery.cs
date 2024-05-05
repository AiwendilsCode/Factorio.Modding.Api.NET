using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ArtilleryTriggerDelivery")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArtilleryTriggerDelivery : TriggerDeliveryItem
{
    [InLua("direction_deviation")]
    public float? DirectionDeviation { get; set; }
	[InLua("projectile")]
    public EntityID Projectile { get; set; }
	[InLua("range_deviation")]
    public float? RangeDeviation { get; set; }
	[InLua("starting_speed")]
    public float StartingSpeed { get; set; }
	[InLua("starting_speed_deviation")]
    public float? StartingSpeedDeviation { get; set; }
	[InLua("trigger_fired_artillery")]
    public bool? TriggerFiredArtillery { get; set; }
	[InLua("type")]
    public string Type { get; } = "artillery";

    
    
    
    

    

    
}