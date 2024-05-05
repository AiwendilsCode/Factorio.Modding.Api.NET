using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TriggerDeliveryItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TriggerDeliveryItem 
{
    [InLua("source_effects")]
    public TriggerEffect? SourceEffects { get; set; }
	[InLua("target_effects")]
    public TriggerEffect? TargetEffects { get; set; }

    
    
    
    

    

    
}