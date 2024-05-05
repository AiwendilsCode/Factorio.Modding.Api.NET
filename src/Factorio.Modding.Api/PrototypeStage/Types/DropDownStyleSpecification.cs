using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DropDownStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DropDownStyleSpecification : BaseStyleSpecification
{
    [InLua("button_style")]
    public ButtonStyleSpecification? ButtonStyle { get; set; }
	[InLua("icon")]
    public Sprite? Icon { get; set; }
	[InLua("list_box_style")]
    public ListBoxStyleSpecification? ListBoxStyle { get; set; }
	[InLua("opened_sound")]
    public Sound? OpenedSound { get; set; }
	[InLua("selector_and_title_spacing")]
    public short? SelectorAndTitleSpacing { get; set; }
	[InLua("type")]
    public string Type { get; } = "dropdown_style";

    
    
    
    

    

    
}