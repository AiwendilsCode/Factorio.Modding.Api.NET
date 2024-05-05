using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SpeechBubblePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpeechBubblePrototype : EntityPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("fade_in_out_ticks")]
    public uint? FadeInOutTicks { get; set; }
	[InLua("style")]
    public string Style { get; set; }
	[InLua("wrapper_flow_style")]
    public string? WrapperFlowStyle { get; set; }
	[InLua("y_offset")]
    public double? YOffset { get; set; }

    
    
    
    

    

    
}