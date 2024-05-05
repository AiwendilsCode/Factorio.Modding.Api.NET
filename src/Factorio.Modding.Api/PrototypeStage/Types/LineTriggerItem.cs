using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LineTriggerItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LineTriggerItem : TriggerItem
{
    [InLua("range")]
    public double Range { get; set; }
	[InLua("range_effects")]
    public TriggerEffect? RangeEffects { get; set; }
	[InLua("type")]
    public string Type { get; } = "line";
	[InLua("width")]
    public double Width { get; set; }

    
    
    
    

    

    
}