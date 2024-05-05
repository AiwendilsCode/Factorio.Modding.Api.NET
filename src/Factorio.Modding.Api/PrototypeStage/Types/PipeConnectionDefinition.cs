using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PipeConnectionDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PipeConnectionDefinition 
{
    [InLua("max_underground_distance")]
    public uint? MaxUndergroundDistance { get; set; }
	[InLua("position")]
    public Vector? Position { get; set; }
	[InLua("positions")]
    public Vector[]? Positions { get; set; }
	[InLua("type")]
    public TypeEnum? Type { get; set; }

    
    
    
    

    

    
}