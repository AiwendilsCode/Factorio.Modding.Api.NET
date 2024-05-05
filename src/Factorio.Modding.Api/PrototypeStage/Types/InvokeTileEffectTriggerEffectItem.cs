using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("InvokeTileEffectTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class InvokeTileEffectTriggerEffectItem : TriggerEffectItem
{
    [InLua("tile_collision_mask")]
    public CollisionMask? TileCollisionMask { get; set; }
	[InLua("type")]
    public string Type { get; } = "invoke-tile-trigger";

    
    
    
    

    

    
}