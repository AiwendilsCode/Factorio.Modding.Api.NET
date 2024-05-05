using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("PumpPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PumpPrototype : EntityWithOwnerPrototype
{
    [InLua("animations")]
    public Animation4Way Animations { get; set; }
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
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("fluid_animation")]
    public Animation4Way? FluidAnimation { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("fluid_wagon_connector_alignment_tolerance")]
    public double? FluidWagonConnectorAlignmentTolerance { get; set; }
	[InLua("fluid_wagon_connector_frame_count")]
    public byte? FluidWagonConnectorFrameCount { get; set; }
	[InLua("fluid_wagon_connector_graphics")]
    public FluidWagonConnectorGraphics? FluidWagonConnectorGraphics { get; set; }
	[InLua("fluid_wagon_connector_speed")]
    public double? FluidWagonConnectorSpeed { get; set; }
	[InLua("glass_pictures")]
    public Sprite4Way? GlassPictures { get; set; }
	[InLua("pumping_speed")]
    public double PumpingSpeed { get; set; }

    
    
    
    

    

    
}