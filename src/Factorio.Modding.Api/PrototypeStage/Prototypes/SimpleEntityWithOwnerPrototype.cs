using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SimpleEntityWithOwnerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SimpleEntityWithOwnerPrototype : EntityWithOwnerPrototype
{
    [InLua("animations")]
    public AnimationVariations? Animations { get; set; }
	[InLua("force_visibility")]
    public ForceCondition? ForceVisibility { get; set; }
	[InLua("picture")]
    public Sprite4Way? Picture { get; set; }
	[InLua("pictures")]
    public SpriteVariations? Pictures { get; set; }
	[InLua("random_animation_offset")]
    public bool? RandomAnimationOffset { get; set; }
	[InLua("random_variation_on_create")]
    public bool? RandomVariationOnCreate { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_draw_order")]
    public sbyte? SecondaryDrawOrder { get; set; }

    
    
    
    

    

    
}