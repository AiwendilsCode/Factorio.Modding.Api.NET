using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ShortcutPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ShortcutPrototype : PrototypeBase
{
    [InLua("action")]
    public ActionEnum Action { get; set; }
	[InLua("associated_control_input")]
    public string? AssociatedControlInput { get; set; }
	[InLua("disabled_icon")]
    public Sprite? DisabledIcon { get; set; }
	[InLua("disabled_small_icon")]
    public Sprite? DisabledSmallIcon { get; set; }
	[InLua("icon")]
    public Sprite Icon { get; set; }
	[InLua("item_to_spawn")]
    public ItemID? ItemToSpawn { get; set; }
	[InLua("order")]
    public Order? Order { get; set; }
	[InLua("small_icon")]
    public Sprite? SmallIcon { get; set; }
	[InLua("style")]
    public StyleEnum? Style { get; set; }
	[InLua("technology_to_unlock")]
    public TechnologyID? TechnologyToUnlock { get; set; }
	[InLua("toggleable")]
    public bool? Toggleable { get; set; }

    
    
    
    

    

    
}