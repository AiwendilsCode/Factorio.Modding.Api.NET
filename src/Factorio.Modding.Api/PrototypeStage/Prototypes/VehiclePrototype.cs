using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("VehiclePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class VehiclePrototype : EntityWithOwnerPrototype
{
    [InLua("allow_passengers")]
    public bool? AllowPassengers { get; set; }
	[InLua("braking_power")]
    public OneOf<Energy, double> BrakingPower { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("crash_trigger")]
    public TriggerEffect? CrashTrigger { get; set; }
	[InLua("energy_per_hit_point")]
    public double EnergyPerHitPoint { get; set; }
	[InLua("equipment_grid")]
    public EquipmentGridID? EquipmentGrid { get; set; }
	[InLua("friction")]
    public double Friction { get; set; }
	[InLua("minimap_representation")]
    public Sprite? MinimapRepresentation { get; set; }
	[InLua("selected_minimap_representation")]
    public Sprite? SelectedMinimapRepresentation { get; set; }
	[InLua("sound_minimum_speed")]
    public double? SoundMinimumSpeed { get; set; }
	[InLua("sound_scaling_ratio")]
    public double? SoundScalingRatio { get; set; }
	[InLua("stop_trigger")]
    public TriggerEffect? StopTrigger { get; set; }
	[InLua("stop_trigger_speed")]
    public double? StopTriggerSpeed { get; set; }
	[InLua("terrain_friction_modifier")]
    public float? TerrainFrictionModifier { get; set; }
	[InLua("weight")]
    public double Weight { get; set; }

    
    
    
    

    

    
}