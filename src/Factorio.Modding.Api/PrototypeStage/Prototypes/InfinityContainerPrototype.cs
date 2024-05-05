using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("InfinityContainerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class InfinityContainerPrototype : LogisticContainerPrototype
{
    [InLua("erase_contents_when_mined")]
    public bool EraseContentsWhenMined { get; set; }
	[InLua("gui_mode")]
    public GuiModeEnum? GuiMode { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("logistic_mode")]
    public LogisticModeEnum? LogisticMode { get; set; }
	[InLua("render_not_in_network_icon")]
    public bool? RenderNotInNetworkIcon { get; set; }

    
    
    
    

    

    
}