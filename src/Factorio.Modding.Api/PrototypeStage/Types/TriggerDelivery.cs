using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TriggerDelivery")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TriggerDelivery 
{
    
    public OneOf<InstantTriggerDelivery, ProjectileTriggerDelivery, FlameThrowerExplosionTriggerDelivery, BeamTriggerDelivery, StreamTriggerDelivery, ArtilleryTriggerDelivery> Value { get; set; }

    
    
    
    private TriggerDelivery(InstantTriggerDelivery value)
    {
        Value = value;
    }

	private TriggerDelivery(ProjectileTriggerDelivery value)
    {
        Value = value;
    }

	private TriggerDelivery(FlameThrowerExplosionTriggerDelivery value)
    {
        Value = value;
    }

	private TriggerDelivery(BeamTriggerDelivery value)
    {
        Value = value;
    }

	private TriggerDelivery(StreamTriggerDelivery value)
    {
        Value = value;
    }

	private TriggerDelivery(ArtilleryTriggerDelivery value)
    {
        Value = value;
    }

    public static implicit operator TriggerDelivery(InstantTriggerDelivery value) => new(value);

	public static implicit operator TriggerDelivery(ProjectileTriggerDelivery value) => new(value);

	public static implicit operator TriggerDelivery(FlameThrowerExplosionTriggerDelivery value) => new(value);

	public static implicit operator TriggerDelivery(BeamTriggerDelivery value) => new(value);

	public static implicit operator TriggerDelivery(StreamTriggerDelivery value) => new(value);

	public static implicit operator TriggerDelivery(ArtilleryTriggerDelivery value) => new(value);

    
}