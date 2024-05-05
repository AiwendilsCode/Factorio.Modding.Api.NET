using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TrainStopPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TrainStopPrototype : EntityWithOwnerPrototype
{
    [InLua("animation_ticks_per_frame")]
    public uint AnimationTicksPerFrame { get; set; }
	[InLua("animations")]
    public Animation4Way? Animations { get; set; }
	[InLua("build_grid_size")]
    public double? BuildGridSize { get; } = 2;
	[InLua("chart_name")]
    public bool? ChartName { get; set; }
	[InLua("circuit_connector_sprites")]
    public (CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites)? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint)? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("default_train_stopped_signal")]
    public SignalIDConnector? DefaultTrainStoppedSignal { get; set; }
	[InLua("default_trains_count_signal")]
    public SignalIDConnector? DefaultTrainsCountSignal { get; set; }
	[InLua("default_trains_limit_signal")]
    public SignalIDConnector? DefaultTrainsLimitSignal { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("drawing_boxes")]
    public TrainStopDrawingBoxes? DrawingBoxes { get; set; }
	[InLua("light1")]
    public TrainStopLight? Light1 { get; set; }
	[InLua("light2")]
    public TrainStopLight? Light2 { get; set; }
	[InLua("rail_overlay_animations")]
    public Animation4Way? RailOverlayAnimations { get; set; }
	[InLua("top_animations")]
    public Animation4Way? TopAnimations { get; set; }

    
    
    
    

    

    
}