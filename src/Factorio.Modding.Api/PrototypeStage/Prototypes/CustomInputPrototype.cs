using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CustomInputPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CustomInputPrototype : PrototypeBase
{
    [InLua("action")]
    public ActionEnum? Action { get; set; }
	[InLua("alternative_key_sequence")]
    public string? AlternativeKeySequence { get; set; }
	[InLua("consuming")]
    public ConsumingType? Consuming { get; set; }
	[InLua("controller_alternative_key_sequence")]
    public string? ControllerAlternativeKeySequence { get; set; }
	[InLua("controller_key_sequence")]
    public string? ControllerKeySequence { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("enabled_while_in_cutscene")]
    public bool? EnabledWhileInCutscene { get; set; }
	[InLua("enabled_while_spectating")]
    public bool? EnabledWhileSpectating { get; set; }
	[InLua("include_selected_prototype")]
    public bool? IncludeSelectedPrototype { get; set; }
	[InLua("item_to_spawn")]
    public ItemID? ItemToSpawn { get; set; }
	[InLua("key_sequence")]
    public string KeySequence { get; set; }
	[InLua("linked_game_control")]
    public LinkedGameControl? LinkedGameControl { get; set; }
	[InLua("name")]
    public string Name { get; set; }

    
    
    
    

    

    
}