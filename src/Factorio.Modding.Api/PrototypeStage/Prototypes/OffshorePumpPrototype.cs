using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("OffshorePumpPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class OffshorePumpPrototype : EntityWithOwnerPrototype
{
    [InLua("adjacent_tile_collision_box")]
    public BoundingBox? AdjacentTileCollisionBox { get; set; }
	[InLua("adjacent_tile_collision_mask")]
    public CollisionMask? AdjacentTileCollisionMask { get; set; }
	[InLua("adjacent_tile_collision_test")]
    public CollisionMask? AdjacentTileCollisionTest { get; set; }
	[InLua("always_draw_fluid")]
    public bool? AlwaysDrawFluid { get; set; }
	[InLua("center_collision_mask")]
    public CollisionMask? CenterCollisionMask { get; set; }
	[InLua("check_bounding_box_collides_with_tiles")]
    public bool? CheckBoundingBoxCollidesWithTiles { get; set; }
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
	[InLua("fluid")]
    public FluidID Fluid { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("fluid_box_tile_collision_test")]
    public CollisionMask? FluidBoxTileCollisionTest { get; set; }
	[InLua("graphics_set")]
    public OffshorePumpGraphicsSet? GraphicsSet { get; set; }
	[InLua("min_perceived_performance")]
    public float? MinPerceivedPerformance { get; set; }
	[InLua("picture")]
    public Animation4Way? Picture { get; set; }
	[InLua("placeable_position_visualization")]
    public Sprite? PlaceablePositionVisualization { get; set; }
	[InLua("pumping_speed")]
    public float PumpingSpeed { get; set; }
	[InLua("remove_on_tile_collision")]
    public bool? RemoveOnTileCollision { get; set; }

    
    
    
    

    

    
}