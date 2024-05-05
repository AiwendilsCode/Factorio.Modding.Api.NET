using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ConstantCombinatorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ConstantCombinatorPrototype : EntityWithOwnerPrototype
{
    [InLua("activity_led_light")]
    public LightDefinition? ActivityLedLight { get; set; }
	[InLua("activity_led_light_offsets")]
    public (Vector, Vector, Vector, Vector) ActivityLedLightOffsets { get; set; }
	[InLua("activity_led_sprites")]
    public Sprite4Way? ActivityLedSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint) CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("item_slot_count")]
    public uint ItemSlotCount { get; set; }
	[InLua("sprites")]
    public Sprite4Way? Sprites { get; set; }

    
    
    
    

    

    
}