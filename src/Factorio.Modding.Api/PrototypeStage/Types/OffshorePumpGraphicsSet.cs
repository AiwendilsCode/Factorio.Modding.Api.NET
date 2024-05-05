using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("OffshorePumpGraphicsSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class OffshorePumpGraphicsSet 
{
    [InLua("animation")]
    public Animation4Way Animation { get; set; }
	[InLua("base_pictures")]
    public Sprite4Way? BasePictures { get; set; }
	[InLua("base_render_layer")]
    public RenderLayer? BaseRenderLayer { get; set; }
	[InLua("fluid_animation")]
    public Animation4Way? FluidAnimation { get; set; }
	[InLua("glass_pictures")]
    public Sprite4Way? GlassPictures { get; set; }
	[InLua("underwater_layer_offset")]
    public sbyte? UnderwaterLayerOffset { get; set; }
	[InLua("underwater_pictures")]
    public Sprite4Way? UnderwaterPictures { get; set; }

    
    
    
    

    

    
}