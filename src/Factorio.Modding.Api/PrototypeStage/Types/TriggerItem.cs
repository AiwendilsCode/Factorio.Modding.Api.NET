using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TriggerItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TriggerItem 
{
    [InLua("action_delivery")]
    public OneOf<TriggerDelivery, TriggerDelivery[]>? ActionDelivery { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("entity_flags")]
    public EntityPrototypeFlags? EntityFlags { get; set; }
	[InLua("force")]
    public ForceCondition? Force { get; set; }
	[InLua("ignore_collision_condition")]
    public bool? IgnoreCollisionCondition { get; set; }
	[InLua("probability")]
    public float? Probability { get; set; }
	[InLua("repeat_count")]
    public uint? RepeatCount { get; set; }
	[InLua("trigger_target_mask")]
    public TriggerTargetMask? TriggerTargetMask { get; set; }

    
    
    
    

    

    
}