using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AnimationPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationPrototype 
{
    [InLua("animation_speed")]
    public float? AnimationSpeed { get; set; }
	[InLua("apply_runtime_tint")]
    public bool? ApplyRuntimeTint { get; set; }
	[InLua("blend_mode")]
    public BlendMode? BlendMode { get; set; }
	[InLua("dice")]
    public byte? Dice { get; set; }
	[InLua("dice_x")]
    public byte? DiceX { get; set; }
	[InLua("dice_y")]
    public byte? DiceY { get; set; }
	[InLua("draw_as_glow")]
    public bool? DrawAsGlow { get; set; }
	[InLua("draw_as_light")]
    public bool? DrawAsLight { get; set; }
	[InLua("draw_as_shadow")]
    public bool? DrawAsShadow { get; set; }
	[InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("flags")]
    public SpriteFlags? Flags { get; set; }
	[InLua("frame_count")]
    public uint? FrameCount { get; set; }
	[InLua("frame_sequence")]
    public AnimationFrameSequence? FrameSequence { get; set; }
	[InLua("generate_sdf")]
    public bool? GenerateSdf { get; set; }
	[InLua("height")]
    public SpriteSizeType? Height { get; set; }
	[InLua("hr_version")]
    public Animation? HrVersion { get; set; }
	[InLua("layers")]
    public Animation[]? Layers { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("load_in_minimal_mode")]
    public bool? LoadInMinimalMode { get; set; }
	[InLua("max_advance")]
    public float? MaxAdvance { get; set; }
	[InLua("mipmap_count")]
    public byte? MipmapCount { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("position")]
    public (SpriteSizeType, SpriteSizeType)? Position { get; set; }
	[InLua("premul_alpha")]
    public bool? PremulAlpha { get; set; }
	[InLua("priority")]
    public SpritePriority? Priority { get; set; }
	[InLua("repeat_count")]
    public byte? RepeatCount { get; set; }
	[InLua("run_mode")]
    public RunModeEnum? RunMode { get; set; }
	[InLua("scale")]
    public double? Scale { get; set; }
	[InLua("shift")]
    public Vector? Shift { get; set; }
	[InLua("size")]
    public OneOf<SpriteSizeType, (SpriteSizeType, SpriteSizeType)>? Size { get; set; }
	[InLua("stripes")]
    public Stripe[]? Stripes { get; set; }
	[InLua("tint")]
    public Color? Tint { get; set; }
	[InLua("type")]
    public string Type { get; } = "animation";
	[InLua("width")]
    public SpriteSizeType? Width { get; set; }
	[InLua("x")]
    public SpriteSizeType? X { get; set; }
	[InLua("y")]
    public SpriteSizeType? Y { get; set; }

    
    
    
    

    

    
}