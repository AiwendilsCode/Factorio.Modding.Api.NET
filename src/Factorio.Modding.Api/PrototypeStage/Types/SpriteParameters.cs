using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpriteParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpriteParameters 
{
    [InLua("apply_runtime_tint")]
    public bool? ApplyRuntimeTint { get; set; }
	[InLua("blend_mode")]
    public BlendMode? BlendMode { get; set; }
	[InLua("draw_as_glow")]
    public bool? DrawAsGlow { get; set; }
	[InLua("draw_as_light")]
    public bool? DrawAsLight { get; set; }
	[InLua("draw_as_shadow")]
    public bool? DrawAsShadow { get; set; }
	[InLua("filename")]
    public FileName Filename { get; set; }
	[InLua("flags")]
    public SpriteFlags? Flags { get; set; }
	[InLua("generate_sdf")]
    public bool? GenerateSdf { get; set; }
	[InLua("height")]
    public SpriteSizeType? Height { get; set; }
	[InLua("load_in_minimal_mode")]
    public bool? LoadInMinimalMode { get; set; }
	[InLua("mipmap_count")]
    public byte? MipmapCount { get; set; }
	[InLua("position")]
    public (SpriteSizeType, SpriteSizeType)? Position { get; set; }
	[InLua("premul_alpha")]
    public bool? PremulAlpha { get; set; }
	[InLua("priority")]
    public SpritePriority? Priority { get; set; }
	[InLua("scale")]
    public double? Scale { get; set; }
	[InLua("shift")]
    public Vector? Shift { get; set; }
	[InLua("size")]
    public OneOf<SpriteSizeType, (SpriteSizeType, SpriteSizeType)>? Size { get; set; }
	[InLua("tint")]
    public Color? Tint { get; set; }
	[InLua("width")]
    public SpriteSizeType? Width { get; set; }
	[InLua("x")]
    public SpriteSizeType? X { get; set; }
	[InLua("y")]
    public SpriteSizeType? Y { get; set; }

    
    
    
    

    

    
}