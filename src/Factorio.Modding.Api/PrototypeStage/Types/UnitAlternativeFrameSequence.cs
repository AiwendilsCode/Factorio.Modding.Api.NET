using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UnitAlternativeFrameSequence")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnitAlternativeFrameSequence 
{
    [InLua("attacking_animation_speed")]
    public float AttackingAnimationSpeed { get; set; }
	[InLua("attacking_frame_sequence")]
    public ushort[] AttackingFrameSequence { get; set; }
	[InLua("back_to_walk_animation_speed")]
    public float BackToWalkAnimationSpeed { get; set; }
	[InLua("back_to_walk_frame_sequence")]
    public ushort[] BackToWalkFrameSequence { get; set; }
	[InLua("cooldown_animation_speed")]
    public float CooldownAnimationSpeed { get; set; }
	[InLua("cooldown_frame_sequence")]
    public ushort[] CooldownFrameSequence { get; set; }
	[InLua("prepared_animation_speed")]
    public float PreparedAnimationSpeed { get; set; }
	[InLua("prepared_frame_sequence")]
    public ushort[] PreparedFrameSequence { get; set; }
	[InLua("warmup2_frame_sequence")]
    public ushort[] Warmup2FrameSequence { get; set; }
	[InLua("warmup_animation_speed")]
    public float WarmupAnimationSpeed { get; set; }
	[InLua("warmup_frame_sequence")]
    public ushort[] WarmupFrameSequence { get; set; }

    
    
    
    

    

    
}