using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CarPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CarPrototype : VehiclePrototype
{
    [InLua("animation")]
    public RotatedAnimation Animation { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("consumption")]
    public Energy Consumption { get; set; }
	[InLua("darkness_to_render_light_animation")]
    public float? DarknessToRenderLightAnimation { get; set; }
	[InLua("effectivity")]
    public double Effectivity { get; set; }
	[InLua("energy_source")]
    public OneOf<BurnerEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("guns")]
    public ItemID[]? Guns { get; set; }
	[InLua("has_belt_immunity")]
    public bool? HasBeltImmunity { get; set; }
	[InLua("immune_to_cliff_impacts")]
    public bool? ImmuneToCliffImpacts { get; set; }
	[InLua("immune_to_rock_impacts")]
    public bool? ImmuneToRockImpacts { get; set; }
	[InLua("immune_to_tree_impacts")]
    public bool? ImmuneToTreeImpacts { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("light_animation")]
    public RotatedAnimation? LightAnimation { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("rotation_speed")]
    public double RotationSpeed { get; set; }
	[InLua("sound_no_fuel")]
    public Sound? SoundNoFuel { get; set; }
	[InLua("tank_driving")]
    public bool? TankDriving { get; set; }
	[InLua("track_particle_triggers")]
    public FootstepTriggerEffectList? TrackParticleTriggers { get; set; }
	[InLua("turret_animation")]
    public RotatedAnimation? TurretAnimation { get; set; }
	[InLua("turret_return_timeout")]
    public uint? TurretReturnTimeout { get; set; }
	[InLua("turret_rotation_speed")]
    public float? TurretRotationSpeed { get; set; }

    
    
    
    

    

    
}