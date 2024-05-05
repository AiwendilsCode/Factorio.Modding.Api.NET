using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeamAttackParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeamAttackParameters : BaseAttackParameters
{
    [InLua("source_direction_count")]
    public uint? SourceDirectionCount { get; set; }
	[InLua("source_offset")]
    public Vector? SourceOffset { get; set; }
	[InLua("type")]
    public string Type { get; } = "beam";

    
    
    
    

    

    
}