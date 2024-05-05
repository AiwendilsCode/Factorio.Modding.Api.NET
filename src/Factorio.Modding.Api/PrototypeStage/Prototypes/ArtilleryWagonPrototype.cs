using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArtilleryWagonPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArtilleryWagonPrototype : RollingStockPrototype
{
    [InLua("ammo_stack_limit")]
    public ItemCountType AmmoStackLimit { get; set; }
	[InLua("cannon_barrel_light_direction")]
    public Vector3D? CannonBarrelLightDirection { get; set; }
	[InLua("cannon_barrel_pictures")]
    public RotatedSprite? CannonBarrelPictures { get; set; }
	[InLua("cannon_barrel_recoil_shiftings")]
    public Vector3D[]? CannonBarrelRecoilShiftings { get; set; }
	[InLua("cannon_barrel_recoil_shiftings_load_correction_matrix")]
    public Vector3D[]? CannonBarrelRecoilShiftingsLoadCorrectionMatrix { get; set; }
	[InLua("cannon_base_pictures")]
    public RotatedSprite? CannonBasePictures { get; set; }
	[InLua("cannon_base_shiftings")]
    public Vector[]? CannonBaseShiftings { get; set; }
	[InLua("cannon_parking_frame_count")]
    public ushort? CannonParkingFrameCount { get; set; }
	[InLua("cannon_parking_speed")]
    public float? CannonParkingSpeed { get; set; }
	[InLua("disable_automatic_firing")]
    public bool? DisableAutomaticFiring { get; set; }
	[InLua("gun")]
    public ItemID Gun { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("manual_range_modifier")]
    public double ManualRangeModifier { get; set; }
	[InLua("rotating_sound")]
    public InterruptibleSound? RotatingSound { get; set; }
	[InLua("rotating_stopped_sound")]
    public Sound? RotatingStoppedSound { get; set; }
	[InLua("turn_after_shooting_cooldown")]
    public ushort? TurnAfterShootingCooldown { get; set; }
	[InLua("turret_rotation_speed")]
    public double TurretRotationSpeed { get; set; }

    
    
    
    

    

    
}