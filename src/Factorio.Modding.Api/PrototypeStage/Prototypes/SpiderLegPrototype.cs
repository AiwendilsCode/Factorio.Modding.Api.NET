using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SpiderLegPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderLegPrototype : EntityWithHealthPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("graphics_set")]
    public SpiderLegGraphicsSet GraphicsSet { get; set; }
	[InLua("initial_movement_speed")]
    public double InitialMovementSpeed { get; set; }
	[InLua("minimal_step_size")]
    public double MinimalStepSize { get; set; }
	[InLua("movement_acceleration")]
    public double MovementAcceleration { get; set; }
	[InLua("movement_based_position_selection_distance")]
    public double MovementBasedPositionSelectionDistance { get; set; }
	[InLua("part_length")]
    public double PartLength { get; set; }
	[InLua("target_position_randomisation_distance")]
    public double TargetPositionRandomisationDistance { get; set; }
	[InLua("walking_sound_volume_modifier")]
    public double? WalkingSoundVolumeModifier { get; set; }

    
    
    
    

    

    
}