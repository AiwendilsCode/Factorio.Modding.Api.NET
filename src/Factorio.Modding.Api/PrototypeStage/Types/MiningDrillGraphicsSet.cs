using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MiningDrillGraphicsSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MiningDrillGraphicsSet 
{
    [InLua("always_draw_idle_animation")]
    public bool? AlwaysDrawIdleAnimation { get; set; }
	[InLua("animation")]
    public Animation4Way? Animation { get; set; }
	[InLua("animation_progress")]
    public float? AnimationProgress { get; set; }
	[InLua("circuit_connector_layer")]
    public OneOf<RenderLayer, CircuitConnectorLayer>? CircuitConnectorLayer { get; set; }
	[InLua("circuit_connector_secondary_draw_order")]
    public OneOf<sbyte, CircuitConnectorSecondaryDrawOrder>? CircuitConnectorSecondaryDrawOrder { get; set; }
	[InLua("default_recipe_tint")]
    public DefaultRecipeTint? DefaultRecipeTint { get; set; }
	[InLua("drilling_vertical_movement_duration")]
    public ushort? DrillingVerticalMovementDuration { get; set; }
	[InLua("idle_animation")]
    public Animation4Way? IdleAnimation { get; set; }
	[InLua("max_animation_progress")]
    public float? MaxAnimationProgress { get; set; }
	[InLua("min_animation_progress")]
    public float? MinAnimationProgress { get; set; }
	[InLua("shift_animation_transition_duration")]
    public ushort? ShiftAnimationTransitionDuration { get; set; }
	[InLua("shift_animation_waypoint_stop_duration")]
    public ushort? ShiftAnimationWaypointStopDuration { get; set; }
	[InLua("shift_animation_waypoints")]
    public ShiftAnimationWaypoints? ShiftAnimationWaypoints { get; set; }
	[InLua("status_colors")]
    public StatusColors? StatusColors { get; set; }
	[InLua("working_visualisations")]
    public WorkingVisualisation[]? WorkingVisualisations { get; set; }

    
    
    
    

    

    
}