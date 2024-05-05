using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("DecorativePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DecorativePrototype : PrototypeBase
{
    [InLua("autoplace")]
    public AutoplaceSpecification? Autoplace { get; set; }
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("decal_overdraw_priority")]
    public ushort? DecalOverdrawPriority { get; set; }
	[InLua("grows_through_rail_path")]
    public bool? GrowsThroughRailPath { get; set; }
	[InLua("pictures")]
    public SpriteVariations Pictures { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("tile_layer")]
    public short? TileLayer { get; set; }
	[InLua("trigger_effect")]
    public TriggerEffect? TriggerEffect { get; set; }
	[InLua("walking_sound")]
    public Sound? WalkingSound { get; set; }

    
    
    
    

    

    
}