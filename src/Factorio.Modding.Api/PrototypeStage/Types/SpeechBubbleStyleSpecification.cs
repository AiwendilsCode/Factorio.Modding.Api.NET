using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpeechBubbleStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpeechBubbleStyleSpecification : BaseStyleSpecification
{
    [InLua("arrow_graphical_set")]
    public ElementImageSet? ArrowGraphicalSet { get; set; }
	[InLua("arrow_indent")]
    public double? ArrowIndent { get; set; }
	[InLua("close_color")]
    public Color? CloseColor { get; set; }
	[InLua("frame_style")]
    public FrameStyleSpecification? FrameStyle { get; set; }
	[InLua("label_style")]
    public LabelStyleSpecification? LabelStyle { get; set; }
	[InLua("pass_through_mouse")]
    public bool? PassThroughMouse { get; set; }
	[InLua("type")]
    public string Type { get; } = "speech_bubble_style";

    
    
    
    

    

    
}