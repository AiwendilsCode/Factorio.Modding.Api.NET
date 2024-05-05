using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("PowerSwitchPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PowerSwitchPrototype : EntityWithOwnerPrototype
{
    [InLua("circuit_wire_connection_point")]
    public WireConnectionPoint CircuitWireConnectionPoint { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("led_off")]
    public Sprite LedOff { get; set; }
	[InLua("led_on")]
    public Sprite LedOn { get; set; }
	[InLua("left_wire_connection_point")]
    public WireConnectionPoint LeftWireConnectionPoint { get; set; }
	[InLua("overlay_loop")]
    public Animation OverlayLoop { get; set; }
	[InLua("overlay_start")]
    public Animation OverlayStart { get; set; }
	[InLua("overlay_start_delay")]
    public byte OverlayStartDelay { get; set; }
	[InLua("power_on_animation")]
    public Animation PowerOnAnimation { get; set; }
	[InLua("right_wire_connection_point")]
    public WireConnectionPoint RightWireConnectionPoint { get; set; }
	[InLua("wire_max_distance")]
    public double? WireMaxDistance { get; set; }

    
    
    
    

    

    
}