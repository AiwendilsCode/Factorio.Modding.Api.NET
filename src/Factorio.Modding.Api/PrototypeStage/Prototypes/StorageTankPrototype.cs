using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("StorageTankPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StorageTankPrototype : EntityWithOwnerPrototype
{
    [InLua("circuit_connector_sprites")]
    public (CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites)? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint)? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("flow_length_in_ticks")]
    public uint FlowLengthInTicks { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("pictures")]
    public StorageTankPictures Pictures { get; set; }
	[InLua("scale_info_icons")]
    public bool? ScaleInfoIcons { get; set; }
	[InLua("show_fluid_icon")]
    public bool? ShowFluidIcon { get; set; }
	[InLua("two_direction_only")]
    public bool? TwoDirectionOnly { get; set; }
	[InLua("window_bounding_box")]
    public BoundingBox WindowBoundingBox { get; set; }

    
    
    
    

    

    
}