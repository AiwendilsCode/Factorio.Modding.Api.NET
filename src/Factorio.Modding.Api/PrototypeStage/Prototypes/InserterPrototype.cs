using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("InserterPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class InserterPrototype : EntityWithOwnerPrototype
{
    [InLua("allow_burner_leech")]
    public bool? AllowBurnerLeech { get; set; }
	[InLua("allow_custom_vectors")]
    public bool? AllowCustomVectors { get; set; }
	[InLua("chases_belt_items")]
    public bool? ChasesBeltItems { get; set; }
	[InLua("circuit_connector_sprites")]
    public (CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites)? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint)? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("default_stack_control_input_signal")]
    public SignalIDConnector? DefaultStackControlInputSignal { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("draw_held_item")]
    public bool? DrawHeldItem { get; set; }
	[InLua("draw_inserter_arrow")]
    public bool? DrawInserterArrow { get; set; }
	[InLua("energy_per_movement")]
    public Energy? EnergyPerMovement { get; set; }
	[InLua("energy_per_rotation")]
    public Energy? EnergyPerRotation { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("extension_speed")]
    public double ExtensionSpeed { get; set; }
	[InLua("filter_count")]
    public byte? FilterCount { get; set; }
	[InLua("hand_base_picture")]
    public Sprite HandBasePicture { get; set; }
	[InLua("hand_base_shadow")]
    public Sprite HandBaseShadow { get; set; }
	[InLua("hand_closed_picture")]
    public Sprite HandClosedPicture { get; set; }
	[InLua("hand_closed_shadow")]
    public Sprite HandClosedShadow { get; set; }
	[InLua("hand_open_picture")]
    public Sprite HandOpenPicture { get; set; }
	[InLua("hand_open_shadow")]
    public Sprite HandOpenShadow { get; set; }
	[InLua("hand_size")]
    public double? HandSize { get; set; }
	[InLua("insert_position")]
    public Vector InsertPosition { get; set; }
	[InLua("pickup_position")]
    public Vector PickupPosition { get; set; }
	[InLua("platform_picture")]
    public Sprite4Way PlatformPicture { get; set; }
	[InLua("rotation_speed")]
    public double RotationSpeed { get; set; }
	[InLua("stack")]
    public bool? Stack { get; set; }
	[InLua("stack_size_bonus")]
    public byte? StackSizeBonus { get; set; }
	[InLua("use_easter_egg")]
    public bool? UseEasterEgg { get; set; }

    
    
    
    

    

    
}