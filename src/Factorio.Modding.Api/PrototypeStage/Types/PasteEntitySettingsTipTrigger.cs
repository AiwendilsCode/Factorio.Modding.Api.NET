using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PasteEntitySettingsTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PasteEntitySettingsTipTrigger 
{
    [InLua("count")]
    public uint? Count { get; set; }
	[InLua("match_type_only")]
    public bool? MatchTypeOnly { get; set; }
	[InLua("source")]
    public EntityID? Source { get; set; }
	[InLua("target")]
    public EntityID? Target { get; set; }
	[InLua("type")]
    public string Type { get; } = "paste-entity-settings";

    
    
    
    

    

    
}