using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileSpriteWithProbability")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileSpriteWithProbability : TileSprite
{
    [InLua("probability")]
    public double? Probability { get; set; }
	[InLua("size")]
    public uint Size { get; set; }
	[InLua("weights")]
    public double[]? Weights { get; set; }

    
    
    
    

    

    
}