using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CharacterInventorySlotsBonusModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterInventorySlotsBonusModifier : SimpleModifier
{
    [InLua("type")]
    public string Type { get; } = "character-inventory-slots-bonus";
	[InLua("use_icon_overlay_constant")]
    public bool? UseIconOverlayConstant { get; set; }

    
    
    
    

    

    
}