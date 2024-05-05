using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AccumulatorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AccumulatorPrototype : EntityWithOwnerPrototype
{
    [InLua("charge_animation")]
    public Animation? ChargeAnimation { get; set; }
	[InLua("charge_cooldown")]
    public ushort ChargeCooldown { get; set; }
	[InLua("charge_light")]
    public LightDefinition? ChargeLight { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_point")]
    public WireConnectionPoint? CircuitWireConnectionPoint { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("default_output_signal")]
    public SignalIDConnector? DefaultOutputSignal { get; set; }
	[InLua("discharge_animation")]
    public Animation? DischargeAnimation { get; set; }
	[InLua("discharge_cooldown")]
    public ushort DischargeCooldown { get; set; }
	[InLua("discharge_light")]
    public LightDefinition? DischargeLight { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }

    
    
    
    

    

    
}