using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CapsuleAction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CapsuleAction 
{
    
    public OneOf<ThrowCapsuleAction, ActivateEquipmentCapsuleAction, UseOnSelfCapsuleAction, DestroyCliffsCapsuleAction, ArtilleryRemoteCapsuleAction> Value { get; set; }

    
    
    
    private CapsuleAction(ThrowCapsuleAction value)
    {
        Value = value;
    }

	private CapsuleAction(ActivateEquipmentCapsuleAction value)
    {
        Value = value;
    }

	private CapsuleAction(UseOnSelfCapsuleAction value)
    {
        Value = value;
    }

	private CapsuleAction(DestroyCliffsCapsuleAction value)
    {
        Value = value;
    }

	private CapsuleAction(ArtilleryRemoteCapsuleAction value)
    {
        Value = value;
    }

    public static implicit operator CapsuleAction(ThrowCapsuleAction value) => new(value);

	public static implicit operator CapsuleAction(ActivateEquipmentCapsuleAction value) => new(value);

	public static implicit operator CapsuleAction(UseOnSelfCapsuleAction value) => new(value);

	public static implicit operator CapsuleAction(DestroyCliffsCapsuleAction value) => new(value);

	public static implicit operator CapsuleAction(ArtilleryRemoteCapsuleAction value) => new(value);

    
}