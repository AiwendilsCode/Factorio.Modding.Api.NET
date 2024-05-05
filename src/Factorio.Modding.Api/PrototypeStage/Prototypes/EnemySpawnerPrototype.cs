using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EnemySpawnerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EnemySpawnerPrototype : EntityWithOwnerPrototype
{
    [InLua("allow_run_time_change_of_is_military_target")]
    public bool? AllowRunTimeChangeOfIsMilitaryTarget { get; } = false;
	[InLua("animations")]
    public AnimationVariations Animations { get; set; }
	[InLua("call_for_help_radius")]
    public double CallForHelpRadius { get; set; }
	[InLua("dying_sound")]
    public Sound? DyingSound { get; set; }
	[InLua("integration")]
    public SpriteVariations? Integration { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; } = true;
	[InLua("max_count_of_owned_units")]
    public uint MaxCountOfOwnedUnits { get; set; }
	[InLua("max_darkness_to_spawn")]
    public float? MaxDarknessToSpawn { get; set; }
	[InLua("max_friends_around_to_spawn")]
    public uint MaxFriendsAroundToSpawn { get; set; }
	[InLua("max_richness_for_spawn_shift")]
    public double MaxRichnessForSpawnShift { get; set; }
	[InLua("max_spawn_shift")]
    public double MaxSpawnShift { get; set; }
	[InLua("min_darkness_to_spawn")]
    public float? MinDarknessToSpawn { get; set; }
	[InLua("pollution_absorption_absolute")]
    public double PollutionAbsorptionAbsolute { get; set; }
	[InLua("pollution_absorption_proportional")]
    public double PollutionAbsorptionProportional { get; set; }
	[InLua("random_animation_offset")]
    public bool? RandomAnimationOffset { get; set; }
	[InLua("result_units")]
    public UnitSpawnDefinition[] ResultUnits { get; set; }
	[InLua("spawn_decoration")]
    public OneOf<CreateDecorativesTriggerEffectItem, CreateDecorativesTriggerEffectItem[]>? SpawnDecoration { get; set; }
	[InLua("spawn_decorations_on_expansion")]
    public bool? SpawnDecorationsOnExpansion { get; set; }
	[InLua("spawning_cooldown")]
    public (double, double) SpawningCooldown { get; set; }
	[InLua("spawning_radius")]
    public double SpawningRadius { get; set; }
	[InLua("spawning_spacing")]
    public double SpawningSpacing { get; set; }

    
    
    
    

    

    
}