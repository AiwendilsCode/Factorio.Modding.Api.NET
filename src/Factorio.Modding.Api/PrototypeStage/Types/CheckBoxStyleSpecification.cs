using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CheckBoxStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CheckBoxStyleSpecification : StyleWithClickableGraphicalSetSpecification
{
    [InLua("checkmark")]
    public Sprite? Checkmark { get; set; }
	[InLua("disabled_checkmark")]
    public Sprite? DisabledCheckmark { get; set; }
	[InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("font_color")]
    public Color? FontColor { get; set; }
	[InLua("intermediate_mark")]
    public Sprite? IntermediateMark { get; set; }
	[InLua("text_padding")]
    public uint? TextPadding { get; set; }
	[InLua("type")]
    public string Type { get; } = "checkbox_style";

    
    
    
    

    

    
}