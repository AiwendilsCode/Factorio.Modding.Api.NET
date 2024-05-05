using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CombinatorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CombinatorPrototype : EntityWithOwnerPrototype
{
    [InLua("active_energy_usage")]
    public Energy ActiveEnergyUsage { get; set; }
	[InLua("activity_led_hold_time")]
    public byte? ActivityLedHoldTime { get; set; }
	[InLua("activity_led_light")]
    public LightDefinition? ActivityLedLight { get; set; }
	[InLua("activity_led_light_offsets")]
    public (Vector, Vector, Vector, Vector) ActivityLedLightOffsets { get; set; }
	[InLua("activity_led_sprites")]
    public Sprite4Way? ActivityLedSprites { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("input_connection_bounding_box")]
    public BoundingBox InputConnectionBoundingBox { get; set; }
	[InLua("input_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint) InputConnectionPoints { get; set; }
	[InLua("output_connection_bounding_box")]
    public BoundingBox OutputConnectionBoundingBox { get; set; }
	[InLua("output_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint) OutputConnectionPoints { get; set; }
	[InLua("screen_light")]
    public LightDefinition? ScreenLight { get; set; }
	[InLua("screen_light_offsets")]
    public (Vector, Vector, Vector, Vector) ScreenLightOffsets { get; set; }
	[InLua("sprites")]
    public Sprite4Way? Sprites { get; set; }

    
    
    
    

    

    
}