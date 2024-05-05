using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimationElement")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationElement 
{
    [InLua("always_draw")]
    public bool? AlwaysDraw { get; set; }
	[InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("apply_tint")]
    public bool? ApplyTint { get; set; }
	[InLua("draw_as_light")]
    public bool? DrawAsLight { get; set; }
	[InLua("draw_as_sprite")]
    public bool? DrawAsSprite { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_draw_order")]
    public sbyte? SecondaryDrawOrder { get; set; }

    
    
    
    

    

    
}