using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CombatRobotPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CombatRobotPrototype : FlyingRobotPrototype
{
    [InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("destroy_action")]
    public Trigger? DestroyAction { get; set; }
	[InLua("follows_player")]
    public bool? FollowsPlayer { get; set; }
	[InLua("friction")]
    public double? Friction { get; set; }
	[InLua("idle")]
    public RotatedAnimation Idle { get; set; }
	[InLua("in_motion")]
    public RotatedAnimation InMotion { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("range_from_player")]
    public double? RangeFromPlayer { get; set; }
	[InLua("shadow_idle")]
    public RotatedAnimation ShadowIdle { get; set; }
	[InLua("shadow_in_motion")]
    public RotatedAnimation ShadowInMotion { get; set; }
	[InLua("time_to_live")]
    public uint TimeToLive { get; set; }

    
    
    
    

    

    
}