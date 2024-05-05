using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ChartUtilityConstants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ChartUtilityConstants 
{
    [InLua("artillery_range_color")]
    public Color ArtilleryRangeColor { get; set; }
	[InLua("blue_signal_color")]
    public Color BlueSignalColor { get; set; }
	[InLua("chart_construction_robot_color")]
    public Color ChartConstructionRobotColor { get; set; }
	[InLua("chart_deconstruct_tint")]
    public Color ChartDeconstructTint { get; set; }
	[InLua("chart_logistic_robot_color")]
    public Color ChartLogisticRobotColor { get; set; }
	[InLua("chart_mobile_construction_robot_color")]
    public Color ChartMobileConstructionRobotColor { get; set; }
	[InLua("chart_personal_construction_robot_color")]
    public Color ChartPersonalConstructionRobotColor { get; set; }
	[InLua("chart_train_stop_disabled_text_color")]
    public Color ChartTrainStopDisabledTextColor { get; set; }
	[InLua("chart_train_stop_full_text_color")]
    public Color ChartTrainStopFullTextColor { get; set; }
	[InLua("chart_train_stop_text_color")]
    public Color ChartTrainStopTextColor { get; set; }
	[InLua("custom_tag_scale")]
    public float? CustomTagScale { get; set; }
	[InLua("custom_tag_selected_overlay_tint")]
    public Color CustomTagSelectedOverlayTint { get; set; }
	[InLua("default_color_by_type")]
    public Dictionary<string, Color>? DefaultColorByType { get; set; }
	[InLua("default_enemy_color")]
    public Color DefaultEnemyColor { get; set; }
	[InLua("default_friendly_color")]
    public Color DefaultFriendlyColor { get; set; }
	[InLua("default_friendly_color_by_type")]
    public Dictionary<string, Color>? DefaultFriendlyColorByType { get; set; }
	[InLua("electric_line_minimum_absolute_width")]
    public float ElectricLineMinimumAbsoluteWidth { get; set; }
	[InLua("electric_line_width")]
    public float ElectricLineWidth { get; set; }
	[InLua("electric_lines_color")]
    public Color ElectricLinesColor { get; set; }
	[InLua("electric_lines_color_switch_disabled")]
    public Color ElectricLinesColorSwitchDisabled { get; set; }
	[InLua("electric_lines_color_switch_enabled")]
    public Color ElectricLinesColorSwitchEnabled { get; set; }
	[InLua("electric_power_pole_color")]
    public Color ElectricPowerPoleColor { get; set; }
	[InLua("entity_ghost_color")]
    public Color EntityGhostColor { get; set; }
	[InLua("explosion_visualization_duration")]
    public uint ExplosionVisualizationDuration { get; set; }
	[InLua("green_signal_color")]
    public Color GreenSignalColor { get; set; }
	[InLua("pollution_color")]
    public Color PollutionColor { get; set; }
	[InLua("rail_color")]
    public Color RailColor { get; set; }
	[InLua("red_signal_color")]
    public Color RedSignalColor { get; set; }
	[InLua("resource_outline_selection_color")]
    public Color ResourceOutlineSelectionColor { get; set; }
	[InLua("switch_color")]
    public Color SwitchColor { get; set; }
	[InLua("train_current_path_outline_color")]
    public Color TrainCurrentPathOutlineColor { get; set; }
	[InLua("train_path_color")]
    public Color TrainPathColor { get; set; }
	[InLua("train_preview_path_outline_color")]
    public Color TrainPreviewPathOutlineColor { get; set; }
	[InLua("turret_range_color")]
    public Color TurretRangeColor { get; set; }
	[InLua("vehicle_inner_color")]
    public Color VehicleInnerColor { get; set; }
	[InLua("vehicle_outer_color")]
    public Color VehicleOuterColor { get; set; }
	[InLua("vehicle_outer_color_selected")]
    public Color VehicleOuterColorSelected { get; set; }
	[InLua("vehicle_wagon_connection_color")]
    public Color VehicleWagonConnectionColor { get; set; }
	[InLua("yellow_signal_color")]
    public Color YellowSignalColor { get; set; }
	[InLua("zoom_threshold_to_draw_spider_path")]
    public double? ZoomThresholdToDrawSpiderPath { get; set; }

    
    
    
    

    

    
}