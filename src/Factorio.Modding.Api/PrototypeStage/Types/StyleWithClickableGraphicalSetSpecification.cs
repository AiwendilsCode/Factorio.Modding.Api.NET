using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StyleWithClickableGraphicalSetSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StyleWithClickableGraphicalSetSpecification : BaseStyleSpecification
{
    [InLua("clicked_graphical_set")]
    public ElementImageSet? ClickedGraphicalSet { get; set; }
	[InLua("default_graphical_set")]
    public ElementImageSet? DefaultGraphicalSet { get; set; }
	[InLua("disabled_graphical_set")]
    public ElementImageSet? DisabledGraphicalSet { get; set; }
	[InLua("hovered_graphical_set")]
    public ElementImageSet? HoveredGraphicalSet { get; set; }
	[InLua("left_click_sound")]
    public Sound? LeftClickSound { get; set; }
	[InLua("selected_clicked_graphical_set")]
    public ElementImageSet? SelectedClickedGraphicalSet { get; set; }
	[InLua("selected_graphical_set")]
    public ElementImageSet? SelectedGraphicalSet { get; set; }
	[InLua("selected_hovered_graphical_set")]
    public ElementImageSet? SelectedHoveredGraphicalSet { get; set; }

    
    
    
    

    

    
}