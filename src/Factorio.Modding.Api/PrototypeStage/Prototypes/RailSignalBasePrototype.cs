using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RailSignalBasePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailSignalBasePrototype : EntityWithOwnerPrototype
{
    [InLua("animation")]
    public RotatedAnimation Animation { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites[]? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public WireConnectionPoint[]? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("default_green_output_signal")]
    public SignalIDConnector? DefaultGreenOutputSignal { get; set; }
	[InLua("default_orange_output_signal")]
    public SignalIDConnector? DefaultOrangeOutputSignal { get; set; }
	[InLua("default_red_output_signal")]
    public SignalIDConnector? DefaultRedOutputSignal { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("flags")]
    public EntityPrototypeFlags? Flags { get; set; }
	[InLua("green_light")]
    public LightDefinition? GreenLight { get; set; }
	[InLua("orange_light")]
    public LightDefinition? OrangeLight { get; set; }
	[InLua("rail_piece")]
    public Animation? RailPiece { get; set; }
	[InLua("red_light")]
    public LightDefinition? RedLight { get; set; }

    
    
    
    

    

    
}