using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EmptyWidgetStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EmptyWidgetStyleSpecification : BaseStyleSpecification
{
    [InLua("graphical_set")]
    public ElementImageSet? GraphicalSet { get; set; }
	[InLua("type")]
    public string Type { get; } = "empty_widget_style";

    
    
    
    

    

    
}