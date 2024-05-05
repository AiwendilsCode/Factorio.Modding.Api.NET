using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpiderVehicleGraphicsSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderVehicleGraphicsSet 
{
    [InLua("animation")]
    public RotatedAnimation? Animation { get; set; }
	[InLua("autopilot_destination_on_map_visualisation")]
    public Animation? AutopilotDestinationOnMapVisualisation { get; set; }
	[InLua("autopilot_destination_queue_on_map_visualisation")]
    public Animation? AutopilotDestinationQueueOnMapVisualisation { get; set; }
	[InLua("autopilot_destination_queue_visualisation")]
    public Animation? AutopilotDestinationQueueVisualisation { get; set; }
	[InLua("autopilot_destination_visualisation")]
    public Animation? AutopilotDestinationVisualisation { get; set; }
	[InLua("autopilot_destination_visualisation_render_layer")]
    public RenderLayer? AutopilotDestinationVisualisationRenderLayer { get; set; }
	[InLua("autopilot_path_visualisation_line_width")]
    public float? AutopilotPathVisualisationLineWidth { get; set; }
	[InLua("autopilot_path_visualisation_on_map_line_width")]
    public float? AutopilotPathVisualisationOnMapLineWidth { get; set; }
	[InLua("base_animation")]
    public RotatedAnimation? BaseAnimation { get; set; }
	[InLua("base_render_layer")]
    public RenderLayer? BaseRenderLayer { get; set; }
	[InLua("eye_light")]
    public LightDefinition? EyeLight { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("light_positions")]
    public Vector[][]? LightPositions { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("shadow_animation")]
    public RotatedAnimation? ShadowAnimation { get; set; }
	[InLua("shadow_base_animation")]
    public RotatedAnimation? ShadowBaseAnimation { get; set; }

    
    
    
    

    

    
}