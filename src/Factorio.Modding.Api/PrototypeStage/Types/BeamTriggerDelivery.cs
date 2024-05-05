using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeamTriggerDelivery")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeamTriggerDelivery : TriggerDeliveryItem
{
    [InLua("add_to_shooter")]
    public bool? AddToShooter { get; set; }
	[InLua("beam")]
    public EntityID Beam { get; set; }
	[InLua("duration")]
    public uint? Duration { get; set; }
	[InLua("max_length")]
    public uint? MaxLength { get; set; }
	[InLua("source_offset")]
    public Vector? SourceOffset { get; set; }
	[InLua("type")]
    public string Type { get; } = "beam";

    
    
    
    

    

    
}