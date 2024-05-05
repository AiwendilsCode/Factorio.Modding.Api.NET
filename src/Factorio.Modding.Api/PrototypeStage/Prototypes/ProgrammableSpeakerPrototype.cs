using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ProgrammableSpeakerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProgrammableSpeakerPrototype : EntityWithOwnerPrototype
{
    [InLua("audible_distance_modifier")]
    public float? AudibleDistanceModifier { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_point")]
    public WireConnectionPoint? CircuitWireConnectionPoint { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("energy_usage_per_tick")]
    public Energy EnergyUsagePerTick { get; set; }
	[InLua("instruments")]
    public ProgrammableSpeakerInstrument[] Instruments { get; set; }
	[InLua("maximum_polyphony")]
    public uint MaximumPolyphony { get; set; }
	[InLua("sprite")]
    public Sprite Sprite { get; set; }

    
    
    
    

    

    
}