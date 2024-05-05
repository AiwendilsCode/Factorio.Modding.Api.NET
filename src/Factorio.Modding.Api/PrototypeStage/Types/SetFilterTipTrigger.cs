using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SetFilterTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SetFilterTipTrigger 
{
    [InLua("consecutive")]
    public bool? Consecutive { get; set; }
	[InLua("count")]
    public uint? Count { get; set; }
	[InLua("entity")]
    public EntityID? Entity { get; set; }
	[InLua("match_type_only")]
    public bool? MatchTypeOnly { get; set; }
	[InLua("type")]
    public string Type { get; } = "set-filter";

    
    
    
    

    

    
}