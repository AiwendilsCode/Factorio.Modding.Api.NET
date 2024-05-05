using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FlowStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FlowStyleSpecification : BaseStyleSpecification
{
    [InLua("horizontal_spacing")]
    public int? HorizontalSpacing { get; set; }
	[InLua("max_on_row")]
    public int? MaxOnRow { get; set; }
	[InLua("type")]
    public string Type { get; } = "flow_style";
	[InLua("vertical_spacing")]
    public int? VerticalSpacing { get; set; }

    
    
    
    

    

    
}