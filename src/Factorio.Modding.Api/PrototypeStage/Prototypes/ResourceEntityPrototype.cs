using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ResourceEntityPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ResourceEntityPrototype : EntityPrototype
{
    [InLua("category")]
    public ResourceCategoryID? Category { get; set; }
	[InLua("cliff_removal_probability")]
    public double? CliffRemovalProbability { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("effect_animation_period")]
    public float? EffectAnimationPeriod { get; set; }
	[InLua("effect_animation_period_deviation")]
    public float? EffectAnimationPeriodDeviation { get; set; }
	[InLua("effect_darkness_multiplier")]
    public float? EffectDarknessMultiplier { get; set; }
	[InLua("highlight")]
    public bool? Highlight { get; set; }
	[InLua("infinite")]
    public bool? Infinite { get; set; }
	[InLua("infinite_depletion_amount")]
    public uint? InfiniteDepletionAmount { get; set; }
	[InLua("map_grid")]
    public bool? MapGrid { get; set; }
	[InLua("max_effect_alpha")]
    public float? MaxEffectAlpha { get; set; }
	[InLua("min_effect_alpha")]
    public float? MinEffectAlpha { get; set; }
	[InLua("minimum")]
    public uint? Minimum { get; set; }
	[InLua("mining_visualisation_tint")]
    public Color? MiningVisualisationTint { get; set; }
	[InLua("normal")]
    public uint? Normal { get; set; }
	[InLua("randomize_visual_position")]
    public bool? RandomizeVisualPosition { get; set; }
	[InLua("resource_patch_search_radius")]
    public uint? ResourcePatchSearchRadius { get; set; }
	[InLua("stage_counts")]
    public uint[] StageCounts { get; set; }
	[InLua("stages")]
    public AnimationVariations Stages { get; set; }
	[InLua("stages_effect")]
    public AnimationVariations? StagesEffect { get; set; }
	[InLua("tree_removal_max_distance")]
    public double? TreeRemovalMaxDistance { get; set; }
	[InLua("tree_removal_probability")]
    public double? TreeRemovalProbability { get; set; }
	[InLua("walking_sound")]
    public Sound? WalkingSound { get; set; }

    
    
    
    

    

    
}