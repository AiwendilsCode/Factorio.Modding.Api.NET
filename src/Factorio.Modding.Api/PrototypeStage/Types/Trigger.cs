using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Trigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Trigger 
{
    
    public OneOf<OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem>, OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem>[]> Value { get; set; }

    
    
    
    private Trigger(OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem> value)
    {
        Value = value;
    }

	private Trigger(OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem>[] value)
    {
        Value = value;
    }

    public static implicit operator Trigger(OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem> value) => new(value);

	public static implicit operator Trigger(OneOf<DirectTriggerItem, AreaTriggerItem, LineTriggerItem, ClusterTriggerItem>[] value) => new(value);

    
}