using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileTransitionsVariants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileTransitionsVariants : TileTransitions
{
    [InLua("main")]
    public TileSpriteWithProbability[] Main { get; set; }
	[InLua("material_background")]
    public TileSprite? MaterialBackground { get; set; }

    
    
    
    

    

    
}