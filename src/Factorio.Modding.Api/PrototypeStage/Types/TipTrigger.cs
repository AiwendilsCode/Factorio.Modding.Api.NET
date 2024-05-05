using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TipTrigger 
{
    
    public OneOf<OrTipTrigger, AndTipTrigger, SequenceTipTrigger, DependenciesMetTipTrigger, TimeElapsedTipTrigger, ResearchTechnologyTipTrigger, UnlockRecipeTipTrigger, CraftItemTipTrigger, BuildEntityTipTrigger, ManualTransferTipTrigger, StackTransferTipTrigger, EntityTransferTipTrigger, SetRecipeTipTrigger, SetFilterTipTrigger, LimitChestTipTrigger, UsePipetteTipTrigger, SetLogisticRequestTipTrigger, UseConfirmTipTrigger, LowPowerTipTrigger, PasteEntitySettingsTipTrigger, FastReplaceTipTrigger, GroupAttackTipTrigger, FastBeltBendTipTrigger, BeltTraverseTipTrigger, PlaceEquipmentTipTrigger, ClearCursorTipTrigger, ShiftBuildTipTrigger, GateOverRailBuildTipTrigger, ManualWireDragTipTrigger> Value { get; set; }

    
    
    
    private TipTrigger(OrTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(AndTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(SequenceTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(DependenciesMetTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(TimeElapsedTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(ResearchTechnologyTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(UnlockRecipeTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(CraftItemTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(BuildEntityTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(ManualTransferTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(StackTransferTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(EntityTransferTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(SetRecipeTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(SetFilterTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(LimitChestTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(UsePipetteTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(SetLogisticRequestTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(UseConfirmTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(LowPowerTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(PasteEntitySettingsTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(FastReplaceTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(GroupAttackTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(FastBeltBendTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(BeltTraverseTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(PlaceEquipmentTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(ClearCursorTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(ShiftBuildTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(GateOverRailBuildTipTrigger value)
    {
        Value = value;
    }

	private TipTrigger(ManualWireDragTipTrigger value)
    {
        Value = value;
    }

    public static implicit operator TipTrigger(OrTipTrigger value) => new(value);

	public static implicit operator TipTrigger(AndTipTrigger value) => new(value);

	public static implicit operator TipTrigger(SequenceTipTrigger value) => new(value);

	public static implicit operator TipTrigger(DependenciesMetTipTrigger value) => new(value);

	public static implicit operator TipTrigger(TimeElapsedTipTrigger value) => new(value);

	public static implicit operator TipTrigger(ResearchTechnologyTipTrigger value) => new(value);

	public static implicit operator TipTrigger(UnlockRecipeTipTrigger value) => new(value);

	public static implicit operator TipTrigger(CraftItemTipTrigger value) => new(value);

	public static implicit operator TipTrigger(BuildEntityTipTrigger value) => new(value);

	public static implicit operator TipTrigger(ManualTransferTipTrigger value) => new(value);

	public static implicit operator TipTrigger(StackTransferTipTrigger value) => new(value);

	public static implicit operator TipTrigger(EntityTransferTipTrigger value) => new(value);

	public static implicit operator TipTrigger(SetRecipeTipTrigger value) => new(value);

	public static implicit operator TipTrigger(SetFilterTipTrigger value) => new(value);

	public static implicit operator TipTrigger(LimitChestTipTrigger value) => new(value);

	public static implicit operator TipTrigger(UsePipetteTipTrigger value) => new(value);

	public static implicit operator TipTrigger(SetLogisticRequestTipTrigger value) => new(value);

	public static implicit operator TipTrigger(UseConfirmTipTrigger value) => new(value);

	public static implicit operator TipTrigger(LowPowerTipTrigger value) => new(value);

	public static implicit operator TipTrigger(PasteEntitySettingsTipTrigger value) => new(value);

	public static implicit operator TipTrigger(FastReplaceTipTrigger value) => new(value);

	public static implicit operator TipTrigger(GroupAttackTipTrigger value) => new(value);

	public static implicit operator TipTrigger(FastBeltBendTipTrigger value) => new(value);

	public static implicit operator TipTrigger(BeltTraverseTipTrigger value) => new(value);

	public static implicit operator TipTrigger(PlaceEquipmentTipTrigger value) => new(value);

	public static implicit operator TipTrigger(ClearCursorTipTrigger value) => new(value);

	public static implicit operator TipTrigger(ShiftBuildTipTrigger value) => new(value);

	public static implicit operator TipTrigger(GateOverRailBuildTipTrigger value) => new(value);

	public static implicit operator TipTrigger(ManualWireDragTipTrigger value) => new(value);

    
}