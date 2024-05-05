using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimationParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationParameters : SpriteParameters
{
    [InLua("animation_speed")]
    public float? AnimationSpeed { get; set; }
	[InLua("dice")]
    public byte? Dice { get; set; }
	[InLua("dice_x")]
    public byte? DiceX { get; set; }
	[InLua("dice_y")]
    public byte? DiceY { get; set; }
	[InLua("frame_count")]
    public uint? FrameCount { get; set; }
	[InLua("frame_sequence")]
    public AnimationFrameSequence? FrameSequence { get; set; }
	[InLua("generate_sdf")]
    public bool? GenerateSdf { get; set; }
	[InLua("height")]
    public SpriteSizeType? Height { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("max_advance")]
    public float? MaxAdvance { get; set; }
	[InLua("mipmap_count")]
    public byte? MipmapCount { get; set; }
	[InLua("repeat_count")]
    public byte? RepeatCount { get; set; }
	[InLua("run_mode")]
    public RunModeEnum? RunMode { get; set; }
	[InLua("size")]
    public OneOf<SpriteSizeType, (SpriteSizeType, SpriteSizeType)>? Size { get; set; }
	[InLua("width")]
    public SpriteSizeType? Width { get; set; }

    
    
    
    

    

    
}