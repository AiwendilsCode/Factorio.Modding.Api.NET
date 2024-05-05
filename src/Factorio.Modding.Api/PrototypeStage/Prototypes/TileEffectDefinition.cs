using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TileEffectDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileEffectDefinition 
{
    [InLua("animation_scale")]
    public OneOf<float, (float, float)> AnimationScale { get; set; }
	[InLua("animation_speed")]
    public float AnimationSpeed { get; set; }
	[InLua("dark_threshold")]
    public OneOf<float, (float, float)> DarkThreshold { get; set; }
	[InLua("far_zoom")]
    public float? FarZoom { get; set; }
	[InLua("foam_color")]
    public Color FoamColor { get; set; }
	[InLua("foam_color_multiplier")]
    public float FoamColorMultiplier { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("near_zoom")]
    public float? NearZoom { get; set; }
	[InLua("reflection_threshold")]
    public OneOf<float, (float, float)> ReflectionThreshold { get; set; }
	[InLua("specular_lightness")]
    public Color SpecularLightness { get; set; }
	[InLua("specular_threshold")]
    public OneOf<float, (float, float)> SpecularThreshold { get; set; }
	[InLua("texture")]
    public Sprite Texture { get; set; }
	[InLua("tick_scale")]
    public float TickScale { get; set; }
	[InLua("type")]
    public string Type { get; } = "tile-effect";

    
    
    
    

    

    
}