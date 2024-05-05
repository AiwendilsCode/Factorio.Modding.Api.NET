using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("WallPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WallPrototype : EntityWithOwnerPrototype
{
    [InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_point")]
    public WireConnectionPoint? CircuitWireConnectionPoint { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("connected_gate_visualization")]
    public Sprite? ConnectedGateVisualization { get; set; }
	[InLua("default_output_signal")]
    public SignalIDConnector? DefaultOutputSignal { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("pictures")]
    public WallPictures Pictures { get; set; }
	[InLua("visual_merge_group")]
    public uint? VisualMergeGroup { get; set; }
	[InLua("wall_diode_green")]
    public Sprite4Way? WallDiodeGreen { get; set; }
	[InLua("wall_diode_green_light_bottom")]
    public LightDefinition? WallDiodeGreenLightBottom { get; set; }
	[InLua("wall_diode_green_light_left")]
    public LightDefinition? WallDiodeGreenLightLeft { get; set; }
	[InLua("wall_diode_green_light_right")]
    public LightDefinition? WallDiodeGreenLightRight { get; set; }
	[InLua("wall_diode_green_light_top")]
    public LightDefinition? WallDiodeGreenLightTop { get; set; }
	[InLua("wall_diode_red")]
    public Sprite4Way? WallDiodeRed { get; set; }
	[InLua("wall_diode_red_light_bottom")]
    public LightDefinition? WallDiodeRedLightBottom { get; set; }
	[InLua("wall_diode_red_light_left")]
    public LightDefinition? WallDiodeRedLightLeft { get; set; }
	[InLua("wall_diode_red_light_right")]
    public LightDefinition? WallDiodeRedLightRight { get; set; }
	[InLua("wall_diode_red_light_top")]
    public LightDefinition? WallDiodeRedLightTop { get; set; }

    
    
    
    

    

    
}