using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ModifierTypes 
{
    
    public object Value { get; private set; }

    
    
    
    private ModifierTypes(object value)
    {
        Value = value;
    }

    public static implicit operator ModifierTypes(InserterStackSizeBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(StackInserterCapacityBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(LaboratorySpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(LaboratoryProductivityModifier value) => new(value);

	public static implicit operator ModifierTypes(MaximumFollowingRobotsCountModifier value) => new(value);

	public static implicit operator ModifierTypes(WorkerRobotSpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(WorkerRobotStorageModifier value) => new(value);

	public static implicit operator ModifierTypes(WorkerRobotBatteryModifier value) => new(value);

	public static implicit operator ModifierTypes(FollowerRobotLifetimeModifier value) => new(value);

	public static implicit operator ModifierTypes(GhostTimeToLiveModifier value) => new(value);

	public static implicit operator ModifierTypes(DeconstructionTimeToLiveModifier value) => new(value);

	public static implicit operator ModifierTypes(TurretAttackModifier value) => new(value);

	public static implicit operator ModifierTypes(AmmoDamageModifier value) => new(value);

	public static implicit operator ModifierTypes(ArtilleryRangeModifier value) => new(value);

	public static implicit operator ModifierTypes(GiveItemModifier value) => new(value);

	public static implicit operator ModifierTypes(GunSpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(UnlockRecipeModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterCraftingSpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterMiningSpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterRunningSpeedModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterBuildDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterItemDropDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterReachDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterResourceReachDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterItemPickupDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterLootPickupDistanceModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterInventorySlotsBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterHealthBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterLogisticRequestsModifier value) => new(value);

	public static implicit operator ModifierTypes(CharacterLogisticTrashSlotsModifier value) => new(value);

	public static implicit operator ModifierTypes(MaxFailedAttemptsPerTickPerConstructionQueueModifier value) => new(value);

	public static implicit operator ModifierTypes(MaxSuccessfulAttemptsPerTickPerConstructionQueueModifier value) => new(value);

	public static implicit operator ModifierTypes(MiningDrillProductivityBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(TrainBrakingForceBonusModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldGhostBuildingEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldBlueprintEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldDeconstructionPlannerEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldUpgradePlannerEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(ZoomToWorldSelectionToolEnabledModifier value) => new(value);

	public static implicit operator ModifierTypes(NothingModifier value) => new(value);

    
}