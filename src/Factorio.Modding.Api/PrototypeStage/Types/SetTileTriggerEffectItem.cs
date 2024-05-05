using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SetTileTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SetTileTriggerEffectItem : TriggerEffectItem
{
    [InLua("apply_projection")]
    public bool? ApplyProjection { get; set; }
	[InLua("radius")]
    public float Radius { get; set; }
	[InLua("tile_collision_mask")]
    public CollisionMask? TileCollisionMask { get; set; }
	[InLua("tile_name")]
    public TileID TileName { get; set; }
	[InLua("type")]
    public string Type { get; } = "set-tile";

    
    
    
    

    

    
}