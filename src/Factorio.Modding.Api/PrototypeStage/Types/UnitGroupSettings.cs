using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UnitGroupSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnitGroupSettings 
{
    [InLua("max_gathering_unit_groups")]
    public uint MaxGatheringUnitGroups { get; set; }
	[InLua("max_group_gathering_time")]
    public uint MaxGroupGatheringTime { get; set; }
	[InLua("max_group_member_fallback_factor")]
    public double MaxGroupMemberFallbackFactor { get; set; }
	[InLua("max_group_radius")]
    public double MaxGroupRadius { get; set; }
	[InLua("max_group_slowdown_factor")]
    public double MaxGroupSlowdownFactor { get; set; }
	[InLua("max_member_slowdown_when_ahead")]
    public double MaxMemberSlowdownWhenAhead { get; set; }
	[InLua("max_member_speedup_when_behind")]
    public double MaxMemberSpeedupWhenBehind { get; set; }
	[InLua("max_unit_group_size")]
    public uint MaxUnitGroupSize { get; set; }
	[InLua("max_wait_time_for_late_members")]
    public uint MaxWaitTimeForLateMembers { get; set; }
	[InLua("member_disown_distance")]
    public double MemberDisownDistance { get; set; }
	[InLua("min_group_gathering_time")]
    public uint MinGroupGatheringTime { get; set; }
	[InLua("min_group_radius")]
    public double MinGroupRadius { get; set; }
	[InLua("tick_tolerance_when_member_arrives")]
    public uint TickToleranceWhenMemberArrives { get; set; }

    
    
    
    

    

    
}