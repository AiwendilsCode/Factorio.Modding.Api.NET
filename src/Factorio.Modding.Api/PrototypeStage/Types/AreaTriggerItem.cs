using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AreaTriggerItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AreaTriggerItem : TriggerItem
{
    [InLua("collision_mode")]
    public CollisionModeEnum? CollisionMode { get; set; }
	[InLua("radius")]
    public double Radius { get; set; }
	[InLua("show_in_tooltip")]
    public bool? ShowInTooltip { get; set; }
	[InLua("target_entities")]
    public bool? TargetEntities { get; set; }
	[InLua("trigger_from_target")]
    public bool? TriggerFromTarget { get; set; }
	[InLua("type")]
    public string Type { get; } = "area";

    
    
    
    

    

    
}