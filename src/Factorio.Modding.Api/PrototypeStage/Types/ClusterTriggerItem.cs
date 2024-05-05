using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ClusterTriggerItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ClusterTriggerItem : TriggerItem
{
    [InLua("cluster_count")]
    public uint ClusterCount { get; set; }
	[InLua("distance")]
    public float Distance { get; set; }
	[InLua("distance_deviation")]
    public float? DistanceDeviation { get; set; }
	[InLua("type")]
    public string Type { get; } = "cluster";

    
    
    
    

    

    
}