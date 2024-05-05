using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CraftItemTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CraftItemTipTrigger 
{
    [InLua("consecutive")]
    public bool? Consecutive { get; set; }
	[InLua("count")]
    public uint? Count { get; set; }
	[InLua("event_type")]
    public EventTypeEnum EventType { get; set; }
	[InLua("item")]
    public ItemID? Item { get; set; }
	[InLua("type")]
    public string Type { get; } = "craft-item";

    
    
    
    

    

    
}