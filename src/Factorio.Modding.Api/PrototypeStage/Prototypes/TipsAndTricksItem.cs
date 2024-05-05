using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TipsAndTricksItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TipsAndTricksItem : PrototypeBase
{
    [InLua("category")]
    public string? Category { get; set; }
	[InLua("dependencies")]
    public string[]? Dependencies { get; set; }
	[InLua("image")]
    public FileName? Image { get; set; }
	[InLua("indent")]
    public byte? Indent { get; set; }
	[InLua("is_title")]
    public bool? IsTitle { get; set; }
	[InLua("player_input_method_filter")]
    public PlayerInputMethodFilter? PlayerInputMethodFilter { get; set; }
	[InLua("simulation")]
    public SimulationDefinition? Simulation { get; set; }
	[InLua("skip_trigger")]
    public TipTrigger? SkipTrigger { get; set; }
	[InLua("starting_status")]
    public TipStatus? StartingStatus { get; set; }
	[InLua("tag")]
    public string? Tag { get; set; }
	[InLua("trigger")]
    public TipTrigger? Trigger { get; set; }
	[InLua("tutorial")]
    public string? Tutorial { get; set; }

    
    
    
    

    

    
}