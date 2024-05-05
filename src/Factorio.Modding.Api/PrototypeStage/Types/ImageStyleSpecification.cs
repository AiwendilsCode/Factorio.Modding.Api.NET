using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ImageStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ImageStyleSpecification : BaseStyleSpecification
{
    [InLua("graphical_set")]
    public ElementImageSet? GraphicalSet { get; set; }
	[InLua("stretch_image_to_widget_size")]
    public bool? StretchImageToWidgetSize { get; set; }
	[InLua("type")]
    public string Type { get; } = "image_style";

    
    
    
    

    

    
}