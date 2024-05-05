using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ShowExplosionOnChartTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ShowExplosionOnChartTriggerEffectItem : TriggerEffectItem
{
    [InLua("scale")]
    public float Scale { get; set; }
	[InLua("type")]
    public string Type { get; } = "show-explosion-on-chart";

    
    
    
    

    

    
}