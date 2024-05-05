using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SwitchStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SwitchStyleSpecification : BaseStyleSpecification
{
    [InLua("active_label")]
    public LabelStyleSpecification? ActiveLabel { get; set; }
	[InLua("button")]
    public ButtonStyleSpecification? Button { get; set; }
	[InLua("default_background")]
    public Sprite? DefaultBackground { get; set; }
	[InLua("disabled_background")]
    public Sprite? DisabledBackground { get; set; }
	[InLua("hover_background")]
    public Sprite? HoverBackground { get; set; }
	[InLua("inactive_label")]
    public LabelStyleSpecification? InactiveLabel { get; set; }
	[InLua("left_button_position")]
    public uint? LeftButtonPosition { get; set; }
	[InLua("middle_button_position")]
    public uint? MiddleButtonPosition { get; set; }
	[InLua("right_button_position")]
    public uint? RightButtonPosition { get; set; }
	[InLua("type")]
    public string Type { get; } = "switch_style";

    
    
    
    

    

    
}