using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("NamedNoiseExpression")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NamedNoiseExpression : PrototypeBase
{
    [InLua("expression")]
    public NoiseExpression Expression { get; set; }
	[InLua("intended_property")]
    public string? IntendedProperty { get; set; }
	[InLua("order")]
    public Order? Order { get; set; }

    
    
    
    

    

    
}