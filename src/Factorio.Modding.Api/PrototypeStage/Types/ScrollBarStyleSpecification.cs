using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ScrollBarStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ScrollBarStyleSpecification : BaseStyleSpecification
{
    [InLua("background_graphical_set")]
    public ElementImageSet? BackgroundGraphicalSet { get; set; }
	[InLua("thumb_button_style")]
    public ButtonStyleSpecification? ThumbButtonStyle { get; set; }

    
    
    
    

    

    
}