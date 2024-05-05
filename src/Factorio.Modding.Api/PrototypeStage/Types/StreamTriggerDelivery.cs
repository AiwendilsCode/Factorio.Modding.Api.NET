using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StreamTriggerDelivery")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StreamTriggerDelivery : TriggerDeliveryItem
{
    [InLua("source_offset")]
    public Vector? SourceOffset { get; set; }
	[InLua("stream")]
    public EntityID Stream { get; set; }
	[InLua("type")]
    public string Type { get; } = "stream";

    
    
    
    

    

    
}