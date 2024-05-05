using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("GuiStyle")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GuiStyle : PrototypeBase
{
    [InLua("default_sprite_priority")]
    public SpritePriority? DefaultSpritePriority { get; set; }
	[InLua("default_sprite_scale")]
    public double? DefaultSpriteScale { get; set; }
	[InLua("default_tileset")]
    public FileName? DefaultTileset { get; set; }

    
    
    
    

    

    
}