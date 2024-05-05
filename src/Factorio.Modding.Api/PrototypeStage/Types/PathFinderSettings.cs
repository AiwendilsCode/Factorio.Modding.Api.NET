using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PathFinderSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PathFinderSettings 
{
    [InLua("cache_accept_path_end_distance_ratio")]
    public double CacheAcceptPathEndDistanceRatio { get; set; }
	[InLua("cache_accept_path_start_distance_ratio")]
    public double CacheAcceptPathStartDistanceRatio { get; set; }
	[InLua("cache_max_connect_to_cache_steps_multiplier")]
    public uint CacheMaxConnectToCacheStepsMultiplier { get; set; }
	[InLua("cache_path_end_distance_rating_multiplier")]
    public double CachePathEndDistanceRatingMultiplier { get; set; }
	[InLua("cache_path_start_distance_rating_multiplier")]
    public double CachePathStartDistanceRatingMultiplier { get; set; }
	[InLua("direct_distance_to_consider_short_request")]
    public uint DirectDistanceToConsiderShortRequest { get; set; }
	[InLua("enemy_with_different_destination_collision_penalty")]
    public double EnemyWithDifferentDestinationCollisionPenalty { get; set; }
	[InLua("extended_collision_penalty")]
    public double ExtendedCollisionPenalty { get; set; }
	[InLua("fwd2bwd_ratio")]
    public uint Fwd2bwdRatio { get; set; }
	[InLua("general_entity_collision_penalty")]
    public double GeneralEntityCollisionPenalty { get; set; }
	[InLua("general_entity_subsequent_collision_penalty")]
    public double GeneralEntitySubsequentCollisionPenalty { get; set; }
	[InLua("goal_pressure_ratio")]
    public double GoalPressureRatio { get; set; }
	[InLua("ignore_moving_enemy_collision_distance")]
    public double IgnoreMovingEnemyCollisionDistance { get; set; }
	[InLua("long_cache_min_cacheable_distance")]
    public double LongCacheMinCacheableDistance { get; set; }
	[InLua("long_cache_size")]
    public uint LongCacheSize { get; set; }
	[InLua("max_clients_to_accept_any_new_request")]
    public uint MaxClientsToAcceptAnyNewRequest { get; set; }
	[InLua("max_clients_to_accept_short_new_request")]
    public uint MaxClientsToAcceptShortNewRequest { get; set; }
	[InLua("max_steps_worked_per_tick")]
    public double MaxStepsWorkedPerTick { get; set; }
	[InLua("max_work_done_per_tick")]
    public uint MaxWorkDonePerTick { get; set; }
	[InLua("min_steps_to_check_path_find_termination")]
    public uint MinStepsToCheckPathFindTermination { get; set; }
	[InLua("negative_cache_accept_path_end_distance_ratio")]
    public double NegativeCacheAcceptPathEndDistanceRatio { get; set; }
	[InLua("negative_cache_accept_path_start_distance_ratio")]
    public double NegativeCacheAcceptPathStartDistanceRatio { get; set; }
	[InLua("overload_levels")]
    public uint[] OverloadLevels { get; set; }
	[InLua("overload_multipliers")]
    public double[] OverloadMultipliers { get; set; }
	[InLua("short_cache_min_algo_steps_to_cache")]
    public uint ShortCacheMinAlgoStepsToCache { get; set; }
	[InLua("short_cache_min_cacheable_distance")]
    public double ShortCacheMinCacheableDistance { get; set; }
	[InLua("short_cache_size")]
    public uint ShortCacheSize { get; set; }
	[InLua("short_request_max_steps")]
    public uint ShortRequestMaxSteps { get; set; }
	[InLua("short_request_ratio")]
    public double ShortRequestRatio { get; set; }
	[InLua("stale_enemy_with_same_destination_collision_penalty")]
    public double StaleEnemyWithSameDestinationCollisionPenalty { get; set; }
	[InLua("start_to_goal_cost_multiplier_to_terminate_path_find")]
    public double StartToGoalCostMultiplierToTerminatePathFind { get; set; }
	[InLua("use_path_cache")]
    public bool UsePathCache { get; set; }

    
    
    
    

    

    
}