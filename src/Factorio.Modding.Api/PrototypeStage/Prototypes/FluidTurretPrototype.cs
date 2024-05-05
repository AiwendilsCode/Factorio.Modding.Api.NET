using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FluidTurretPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidTurretPrototype : TurretPrototype
{
    [InLua("activation_buffer_ratio")]
    public float ActivationBufferRatio { get; set; }
	[InLua("attack_parameters")]
    public StreamAttackParameters AttackParameters { get; set; }
	[InLua("attacking_muzzle_animation_shift")]
    public AnimatedVector? AttackingMuzzleAnimationShift { get; set; }
	[InLua("ending_attack_muzzle_animation_shift")]
    public AnimatedVector? EndingAttackMuzzleAnimationShift { get; set; }
	[InLua("enough_fuel_indicator_light")]
    public LightDefinition? EnoughFuelIndicatorLight { get; set; }
	[InLua("enough_fuel_indicator_picture")]
    public Sprite4Way? EnoughFuelIndicatorPicture { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("fluid_buffer_input_flow")]
    public float FluidBufferInputFlow { get; set; }
	[InLua("fluid_buffer_size")]
    public float FluidBufferSize { get; set; }
	[InLua("folded_muzzle_animation_shift")]
    public AnimatedVector? FoldedMuzzleAnimationShift { get; set; }
	[InLua("folding_muzzle_animation_shift")]
    public AnimatedVector? FoldingMuzzleAnimationShift { get; set; }
	[InLua("muzzle_animation")]
    public Animation? MuzzleAnimation { get; set; }
	[InLua("muzzle_light")]
    public LightDefinition? MuzzleLight { get; set; }
	[InLua("not_enough_fuel_indicator_light")]
    public LightDefinition? NotEnoughFuelIndicatorLight { get; set; }
	[InLua("not_enough_fuel_indicator_picture")]
    public Sprite4Way? NotEnoughFuelIndicatorPicture { get; set; }
	[InLua("out_of_ammo_alert_icon")]
    public Sprite? OutOfAmmoAlertIcon { get; set; }
	[InLua("prepared_muzzle_animation_shift")]
    public AnimatedVector? PreparedMuzzleAnimationShift { get; set; }
	[InLua("preparing_muzzle_animation_shift")]
    public AnimatedVector? PreparingMuzzleAnimationShift { get; set; }
	[InLua("starting_attack_muzzle_animation_shift")]
    public AnimatedVector? StartingAttackMuzzleAnimationShift { get; set; }
	[InLua("turret_base_has_direction")]
    public bool TurretBaseHasDirection { get; } = true;

    
    
    
    

    

    
}