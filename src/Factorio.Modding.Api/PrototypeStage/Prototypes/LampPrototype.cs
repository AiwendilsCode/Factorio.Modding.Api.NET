using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LampPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LampPrototype : EntityWithOwnerPrototype
{
    [InLua("always_on")]
    public bool? AlwaysOn { get; set; }
	[InLua("circuit_connector_sprites")]
    public CircuitConnectorSprites? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_point")]
    public WireConnectionPoint? CircuitWireConnectionPoint { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("darkness_for_all_lamps_off")]
    public float? DarknessForAllLampsOff { get; set; }
	[InLua("darkness_for_all_lamps_on")]
    public float? DarknessForAllLampsOn { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("energy_usage_per_tick")]
    public Energy EnergyUsagePerTick { get; set; }
	[InLua("glow_color_intensity")]
    public float? GlowColorIntensity { get; set; }
	[InLua("glow_render_mode")]
    public GlowRenderModeEnum? GlowRenderMode { get; set; }
	[InLua("glow_size")]
    public float? GlowSize { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("light_when_colored")]
    public LightDefinition? LightWhenColored { get; set; }
	[InLua("picture_off")]
    public Sprite PictureOff { get; set; }
	[InLua("picture_on")]
    public Sprite PictureOn { get; set; }
	[InLua("signal_to_color_mapping")]
    public SignalColorMapping[]? SignalToColorMapping { get; set; }

    
    
    
    

    

    
}