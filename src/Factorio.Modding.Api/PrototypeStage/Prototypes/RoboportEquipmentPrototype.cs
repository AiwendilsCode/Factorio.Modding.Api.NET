using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RoboportEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RoboportEquipmentPrototype : EquipmentPrototype
{
    [InLua("burner")]
    public BurnerEnergySource? Burner { get; set; }
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
	[InLua("construction_radius")]
    public float ConstructionRadius { get; set; }
	[InLua("draw_construction_radius_visualization")]
    public bool? DrawConstructionRadiusVisualization { get; set; }
	[InLua("draw_logistic_radius_visualization")]
    public bool? DrawLogisticRadiusVisualization { get; set; }
	[InLua("power")]
    public Energy? Power { get; set; }
	[InLua("recharging_animation")]
    public Animation RechargingAnimation { get; set; }
	[InLua("recharging_light")]
    public LightDefinition? RechargingLight { get; set; }
	[InLua("robot_limit")]
    public ItemCountType? RobotLimit { get; set; }
	[InLua("robot_vertical_acceleration")]
    public float? RobotVerticalAcceleration { get; set; }
	[InLua("robots_shrink_when_entering_and_exiting")]
    public bool? RobotsShrinkWhenEnteringAndExiting { get; set; }
	[InLua("spawn_and_station_height")]
    public float SpawnAndStationHeight { get; set; }
	[InLua("spawn_and_station_shadow_height_offset")]
    public float? SpawnAndStationShadowHeightOffset { get; set; }
	[InLua("spawn_minimum")]
    public Energy? SpawnMinimum { get; set; }
	[InLua("stationing_offset")]
    public Vector? StationingOffset { get; set; }

    
    
    
    

    

    
}