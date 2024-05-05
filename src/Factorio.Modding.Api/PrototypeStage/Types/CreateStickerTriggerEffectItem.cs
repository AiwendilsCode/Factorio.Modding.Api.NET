using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateStickerTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateStickerTriggerEffectItem : TriggerEffectItem
{
    [InLua("show_in_tooltip")]
    public bool? ShowInTooltip { get; set; }
	[InLua("sticker")]
    public EntityID Sticker { get; set; }
	[InLua("trigger_created_entity")]
    public bool? TriggerCreatedEntity { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-sticker";

    
    
    
    

    

    
}