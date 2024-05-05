using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AggregationSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AggregationSpecification 
{
    [InLua("count_already_playing")]
    public bool? CountAlreadyPlaying { get; set; }
	[InLua("max_count")]
    public uint MaxCount { get; set; }
	[InLua("progress_threshold")]
    public float? ProgressThreshold { get; set; }
	[InLua("remove")]
    public bool Remove { get; set; }

    
    
    
    

    

    
}