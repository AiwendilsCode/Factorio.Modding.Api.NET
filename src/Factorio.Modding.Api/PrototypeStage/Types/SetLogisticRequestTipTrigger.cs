using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SetLogisticRequestTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SetLogisticRequestTipTrigger 
{
    [InLua("count")]
    public uint? Count { get; set; }
	[InLua("logistic_chest_only")]
    public bool? LogisticChestOnly { get; set; }
	[InLua("type")]
    public string Type { get; } = "set-logistic-request";

    
    
    
    

    

    
}