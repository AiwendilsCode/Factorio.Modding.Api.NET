using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DirectTriggerItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DirectTriggerItem : TriggerItem
{
    [InLua("filter_enabled")]
    public bool? FilterEnabled { get; set; }
	[InLua("type")]
    public string Type { get; } = "direct";

    
    
    
    

    

    
}