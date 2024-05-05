using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ListBoxStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ListBoxStyleSpecification : BaseStyleSpecification
{
    [InLua("item_style")]
    public ButtonStyleSpecification? ItemStyle { get; set; }
	[InLua("scroll_pane_style")]
    public ScrollPaneStyleSpecification? ScrollPaneStyle { get; set; }
	[InLua("type")]
    public string Type { get; } = "list_box_style";

    
    
    
    

    

    
}