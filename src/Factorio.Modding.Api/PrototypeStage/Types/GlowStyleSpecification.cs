using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("GlowStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GlowStyleSpecification : BaseStyleSpecification
{
    [InLua("image_set")]
    public ElementImageSet? ImageSet { get; set; }
	[InLua("type")]
    public string Type { get; } = "glow_style";

    
    
    
    

    

    
}