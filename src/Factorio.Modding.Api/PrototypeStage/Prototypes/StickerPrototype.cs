using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("StickerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StickerPrototype : EntityPrototype
{
    [InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("damage_interval")]
    public uint? DamageInterval { get; set; }
	[InLua("damage_per_tick")]
    public DamagePrototype? DamagePerTick { get; set; }
	[InLua("duration_in_ticks")]
    public uint DurationInTicks { get; set; }
	[InLua("fire_spread_cooldown")]
    public byte? FireSpreadCooldown { get; set; }
	[InLua("fire_spread_radius")]
    public float? FireSpreadRadius { get; set; }
	[InLua("force_visibility")]
    public ForceCondition? ForceVisibility { get; set; }
	[InLua("selection_box_type")]
    public CursorBoxType? SelectionBoxType { get; set; }
	[InLua("single_particle")]
    public bool? SingleParticle { get; set; }
	[InLua("spread_fire_entity")]
    public EntityID? SpreadFireEntity { get; set; }
	[InLua("stickers_per_square_meter")]
    public float? StickersPerSquareMeter { get; set; }
	[InLua("target_movement_modifier")]
    public float? TargetMovementModifier { get; set; }
	[InLua("target_movement_modifier_from")]
    public float? TargetMovementModifierFrom { get; set; }
	[InLua("target_movement_modifier_to")]
    public float? TargetMovementModifierTo { get; set; }
	[InLua("vehicle_friction_modifier")]
    public float? VehicleFrictionModifier { get; set; }
	[InLua("vehicle_friction_modifier_from")]
    public float? VehicleFrictionModifierFrom { get; set; }
	[InLua("vehicle_friction_modifier_to")]
    public float? VehicleFrictionModifierTo { get; set; }
	[InLua("vehicle_speed_modifier")]
    public float? VehicleSpeedModifier { get; set; }
	[InLua("vehicle_speed_modifier_from")]
    public float? VehicleSpeedModifierFrom { get; set; }
	[InLua("vehicle_speed_modifier_to")]
    public float? VehicleSpeedModifierTo { get; set; }

    
    
    
    

    

    
}