using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CharacterLogisticRequestsModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterLogisticRequestsModifier : BoolModifier
{
    [InLua("type")]
    public string Type { get; } = "character-logistic-requests";
	[InLua("use_icon_overlay_constant")]
    public bool? UseIconOverlayConstant { get; set; }

    
    
    
    

    

    
}