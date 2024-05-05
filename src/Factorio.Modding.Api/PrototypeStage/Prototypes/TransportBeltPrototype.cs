using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TransportBeltPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TransportBeltPrototype : TransportBeltConnectablePrototype
{
    [InLua("animations")]
    public RotatedAnimation? Animations { get; set; }
	[InLua("belt_animation_set")]
    public TransportBeltAnimationSetWithCorners? BeltAnimationSet { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites[]? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public WireConnectionPoint[]? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("connector_frame_sprites")]
    public TransportBeltConnectorFrame ConnectorFrameSprites { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("related_underground_belt")]
    public EntityID? RelatedUndergroundBelt { get; set; }

    
    
    
    

    

    
}