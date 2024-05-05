using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("VerticalFlowStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class VerticalFlowStyleSpecification : BaseStyleSpecification
{
    [InLua("type")]
    public string Type { get; } = "vertical_flow_style";
	[InLua("vertical_spacing")]
    public int? VerticalSpacing { get; set; }

    
    
    
    

    

    
}