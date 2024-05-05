using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CharacterCorpsePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterCorpsePrototype : EntityPrototype
{
    [InLua("armor_picture_mapping")]
    public Dictionary<ItemID, int>? ArmorPictureMapping { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("picture")]
    public Animation? Picture { get; set; }
	[InLua("pictures")]
    public AnimationVariations? Pictures { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("time_to_live")]
    public uint TimeToLive { get; set; }

    
    
    
    

    

    
}