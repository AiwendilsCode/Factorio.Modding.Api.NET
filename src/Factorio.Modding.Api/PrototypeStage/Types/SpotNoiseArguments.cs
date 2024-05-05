using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpotNoiseArguments")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpotNoiseArguments 
{
    [InLua("basement_value")]
    public ConstantNoiseNumber BasementValue { get; set; }
	[InLua("candidate_point_count")]
    public ConstantNoiseNumber? CandidatePointCount { get; set; }
	[InLua("candidate_spot_count")]
    public ConstantNoiseNumber? CandidateSpotCount { get; set; }
	[InLua("comment")]
    public NoiseLiteralString Comment { get; set; }
	[InLua("density_expression")]
    public NoiseLiteralExpression DensityExpression { get; set; }
	[InLua("hard_region_target_quantity")]
    public ConstantNoiseBoolean? HardRegionTargetQuantity { get; set; }
	[InLua("maximum_spot_basement_radius")]
    public ConstantNoiseNumber MaximumSpotBasementRadius { get; set; }
	[InLua("region_size")]
    public ConstantNoiseNumber? RegionSize { get; set; }
	[InLua("seed0")]
    public ConstantNoiseNumber Seed0 { get; set; }
	[InLua("seed1")]
    public ConstantNoiseNumber Seed1 { get; set; }
	[InLua("skip_offset")]
    public ConstantNoiseNumber? SkipOffset { get; set; }
	[InLua("skip_span")]
    public ConstantNoiseNumber? SkipSpan { get; set; }
	[InLua("spot_favorability_expression")]
    public NoiseLiteralExpression SpotFavorabilityExpression { get; set; }
	[InLua("spot_quantity_expression")]
    public NoiseLiteralExpression SpotQuantityExpression { get; set; }
	[InLua("spot_radius_expression")]
    public NoiseLiteralExpression SpotRadiusExpression { get; set; }
	[InLua("suggested_minimum_candidate_point_spacing")]
    public ConstantNoiseNumber? SuggestedMinimumCandidatePointSpacing { get; set; }
	[InLua("x")]
    public NoiseNumber X { get; set; }
	[InLua("y")]
    public NoiseNumber Y { get; set; }

    
    
    
    

    

    
}