using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ContainerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ContainerPrototype : EntityWithOwnerPrototype
{
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
	[InLua("enable_inventory_bar")]
    public bool? EnableInventoryBar { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("inventory_type")]
    public InventoryTypeEnum? InventoryType { get; set; }
	[InLua("picture")]
    public Sprite Picture { get; set; }
	[InLua("scale_info_icons")]
    public bool? ScaleInfoIcons { get; set; }

    
    
    
    

    

    
}