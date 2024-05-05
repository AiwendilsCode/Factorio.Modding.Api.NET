using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CharacterItemDropDistanceModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterItemDropDistanceModifier : SimpleModifier
{
    [InLua("type")]
    public string Type { get; } = "character-item-drop-distance";
	[InLua("use_icon_overlay_constant")]
    public bool? UseIconOverlayConstant { get; set; }

    
    
    
    

    

    
}