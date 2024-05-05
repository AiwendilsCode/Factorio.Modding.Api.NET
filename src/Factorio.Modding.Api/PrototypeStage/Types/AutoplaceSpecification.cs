using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AutoplaceSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AutoplaceSpecification 
{
    [InLua("control")]
    public AutoplaceControlID? Control { get; set; }
	[InLua("coverage")]
    public double? Coverage { get; set; }
	[InLua("default_enabled")]
    public bool? DefaultEnabled { get; set; }
	[InLua("force")]
    public OneOf<string, ForceEnum>? Force { get; set; }
	[InLua("max_probability")]
    public double? MaxProbability { get; set; }
	[InLua("order")]
    public Order? Order { get; set; }
	[InLua("peaks")]
    public AutoplacePeak[]? Peaks { get; set; }
	[InLua("placement_density")]
    public uint? PlacementDensity { get; set; }
	[InLua("probability_expression")]
    public NoiseExpression? ProbabilityExpression { get; set; }
	[InLua("random_probability_penalty")]
    public double? RandomProbabilityPenalty { get; set; }
	[InLua("richness_base")]
    public double? RichnessBase { get; set; }
	[InLua("richness_expression")]
    public NoiseExpression? RichnessExpression { get; set; }
	[InLua("richness_multiplier")]
    public double? RichnessMultiplier { get; set; }
	[InLua("richness_multiplier_distance_bonus")]
    public double? RichnessMultiplierDistanceBonus { get; set; }
	[InLua("sharpness")]
    public double? Sharpness { get; set; }
	[InLua("starting_area_amount")]
    public uint? StartingAreaAmount { get; set; }
	[InLua("starting_area_size")]
    public uint? StartingAreaSize { get; set; }
	[InLua("tile_restriction")]
    public TileIDRestriction[]? TileRestriction { get; set; }
	
    public AutoplacePeak? AutoplacePeak { get; set; }

    
    
    public AutoplaceSpecification() {}
    private AutoplaceSpecification(AutoplacePeak value)
    {
        AutoplacePeak = value;
    }

    public static implicit operator AutoplaceSpecification(AutoplacePeak value) => new(value);

    
}