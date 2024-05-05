using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CameraEffectTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CameraEffectTriggerEffectItem : TriggerEffectItem
{
    [InLua("delay")]
    public byte? Delay { get; set; }
	[InLua("duration")]
    public byte Duration { get; set; }
	[InLua("ease_in_duration")]
    public byte? EaseInDuration { get; set; }
	[InLua("ease_out_duration")]
    public byte? EaseOutDuration { get; set; }
	[InLua("effect")]
    public string Effect { get; set; }
	[InLua("full_strength_max_distance")]
    public ushort? FullStrengthMaxDistance { get; set; }
	[InLua("max_distance")]
    public ushort? MaxDistance { get; set; }
	[InLua("strength")]
    public float? Strength { get; set; }
	[InLua("type")]
    public string Type { get; } = "camera-effect";

    
    
    
    

    

    
}