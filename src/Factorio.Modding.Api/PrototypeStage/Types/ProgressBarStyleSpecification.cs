using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ProgressBarStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProgressBarStyleSpecification : BaseStyleSpecification
{
    [InLua("bar")]
    public ElementImageSet? Bar { get; set; }
	[InLua("bar_background")]
    public ElementImageSet? BarBackground { get; set; }
	[InLua("bar_width")]
    public uint? BarWidth { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("embed_text_in_bar")]
    public bool? EmbedTextInBar { get; set; }
	[InLua("filled_font_color")]
    public Color? FilledFontColor { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("font_color")]
    public Color? FontColor { get; set; }
	[InLua("other_colors")]
    public OtherColors[]? OtherColors { get; set; }
	[InLua("side_text_padding")]
    public short? SideTextPadding { get; set; }
	[InLua("type")]
    public string Type { get; } = "progressbar_style";

    
    
    
    

    

    
}