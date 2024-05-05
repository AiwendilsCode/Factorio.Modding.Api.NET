using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TabbedPaneStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TabbedPaneStyleSpecification : BaseStyleSpecification
{
    [InLua("tab_container")]
    public HorizontalFlowStyleSpecification? TabContainer { get; set; }
	[InLua("tab_content_frame")]
    public FrameStyleSpecification? TabContentFrame { get; set; }
	[InLua("type")]
    public string Type { get; } = "tabbed_pane_style";
	[InLua("vertical_spacing")]
    public uint? VerticalSpacing { get; set; }

    
    
    
    

    

    
}