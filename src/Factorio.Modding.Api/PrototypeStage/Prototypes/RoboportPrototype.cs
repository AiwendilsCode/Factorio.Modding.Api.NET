using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RoboportPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RoboportPrototype : EntityWithOwnerPrototype
{
    [InLua("base")]
    public Sprite Base { get; set; }
	[InLua("base_animation")]
    public Animation BaseAnimation { get; set; }
	[InLua("base_patch")]
    public Sprite BasePatch { get; set; }
	[InLua("charge_approach_distance")]
    public float ChargeApproachDistance { get; set; }
	[InLua("charging_distance")]
    public float? ChargingDistance { get; set; }
	[InLua("charging_energy")]
    public Energy ChargingEnergy { get; set; }
	[InLua("charging_offsets")]
    public Vector[]? ChargingOffsets { get; set; }
	[InLua("charging_station_count")]
    public uint? ChargingStationCount { get; set; }
	[InLua("charging_station_shift")]
    public Vector? ChargingStationShift { get; set; }
	[InLua("charging_threshold_distance")]
    public float? ChargingThresholdDistance { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_point")]
    public WireConnectionPoint? CircuitWireConnectionPoint { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("close_door_trigger_effect")]
    public TriggerEffect? CloseDoorTriggerEffect { get; set; }
	[InLua("construction_radius")]
    public float ConstructionRadius { get; set; }
	[InLua("default_available_construction_output_signal")]
    public SignalIDConnector? DefaultAvailableConstructionOutputSignal { get; set; }
	[InLua("default_available_logistic_output_signal")]
    public SignalIDConnector? DefaultAvailableLogisticOutputSignal { get; set; }
	[InLua("default_total_construction_output_signal")]
    public SignalIDConnector? DefaultTotalConstructionOutputSignal { get; set; }
	[InLua("default_total_logistic_output_signal")]
    public SignalIDConnector? DefaultTotalLogisticOutputSignal { get; set; }
	[InLua("door_animation_down")]
    public Animation DoorAnimationDown { get; set; }
	[InLua("door_animation_up")]
    public Animation DoorAnimationUp { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_construction_radius_visualization")]
    public bool? DrawConstructionRadiusVisualization { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("draw_logistic_radius_visualization")]
    public bool? DrawLogisticRadiusVisualization { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("logistics_connection_distance")]
    public float? LogisticsConnectionDistance { get; set; }
	[InLua("logistics_radius")]
    public float LogisticsRadius { get; set; }
	[InLua("material_slots_count")]
    public ItemStackIndex MaterialSlotsCount { get; set; }
	[InLua("open_door_trigger_effect")]
    public TriggerEffect? OpenDoorTriggerEffect { get; set; }
	[InLua("recharge_minimum")]
    public Energy RechargeMinimum { get; set; }
	[InLua("recharging_animation")]
    public Animation RechargingAnimation { get; set; }
	[InLua("recharging_light")]
    public LightDefinition? RechargingLight { get; set; }
	[InLua("request_to_open_door_timeout")]
    public uint RequestToOpenDoorTimeout { get; set; }
	[InLua("robot_limit")]
    public ItemCountType? RobotLimit { get; set; }
	[InLua("robot_slots_count")]
    public ItemStackIndex RobotSlotsCount { get; set; }
	[InLua("robot_vertical_acceleration")]
    public float? RobotVerticalAcceleration { get; set; }
	[InLua("robots_shrink_when_entering_and_exiting")]
    public bool? RobotsShrinkWhenEnteringAndExiting { get; set; }
	[InLua("spawn_and_station_height")]
    public float SpawnAndStationHeight { get; set; }
	[InLua("spawn_and_station_shadow_height_offset")]
    public float? SpawnAndStationShadowHeightOffset { get; set; }
	[InLua("stationing_offset")]
    public Vector? StationingOffset { get; set; }

    
    
    
    

    

    
}