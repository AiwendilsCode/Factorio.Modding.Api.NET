using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileTransitionsBetweenTransitions")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileTransitionsBetweenTransitions : TileTransitions
{
    [InLua("transition_group1")]
    public byte TransitionGroup1 { get; set; }
	[InLua("transition_group2")]
    public byte TransitionGroup2 { get; set; }

    
    
    
    

    

    
}