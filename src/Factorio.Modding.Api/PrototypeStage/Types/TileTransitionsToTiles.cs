using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileTransitionsToTiles")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileTransitionsToTiles : TileTransitions
{
    [InLua("to_tiles")]
    public TileID[] ToTiles { get; set; }
	[InLua("transition_group")]
    public byte TransitionGroup { get; set; }

    
    
    
    

    

    
}