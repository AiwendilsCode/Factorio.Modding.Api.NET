using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TreePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TreePrototype : EntityWithHealthPrototype
{
    [InLua("colors")]
    public Color[]? Colors { get; set; }
	[InLua("darkness_of_burnt_tree")]
    public float? DarknessOfBurntTree { get; set; }
	[InLua("healing_per_tick")]
    public float? HealingPerTick { get; set; }
	[InLua("pictures")]
    public SpriteVariations? Pictures { get; set; }
	[InLua("variation_weights")]
    public float[]? VariationWeights { get; set; }
	[InLua("variations")]
    public TreeVariation[]? Variations { get; set; }

    
    
    
    

    

    
}