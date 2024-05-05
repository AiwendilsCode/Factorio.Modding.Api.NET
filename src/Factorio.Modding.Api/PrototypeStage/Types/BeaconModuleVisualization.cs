using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeaconModuleVisualization")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeaconModuleVisualization 
{
    [InLua("apply_module_tint")]
    public ModuleTint? ApplyModuleTint { get; set; }
	[InLua("draw_as_light")]
    public bool? DrawAsLight { get; set; }
	[InLua("draw_as_sprite")]
    public bool? DrawAsSprite { get; set; }
	[InLua("has_empty_slot")]
    public bool? HasEmptySlot { get; set; }
	[InLua("pictures")]
    public SpriteVariations? Pictures { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_draw_order")]
    public sbyte? SecondaryDrawOrder { get; set; }

    
    
    
    

    

    
}