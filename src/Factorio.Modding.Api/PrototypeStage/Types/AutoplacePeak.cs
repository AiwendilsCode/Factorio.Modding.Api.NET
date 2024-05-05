using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AutoplacePeak")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AutoplacePeak 
{
    [InLua("aux_max_range")]
    public double? AuxMaxRange { get; set; }
	[InLua("aux_optimal")]
    public double? AuxOptimal { get; set; }
	[InLua("aux_range")]
    public double? AuxRange { get; set; }
	[InLua("aux_top_property_limit")]
    public double? AuxTopPropertyLimit { get; set; }
	[InLua("distance_max_range")]
    public double? DistanceMaxRange { get; set; }
	[InLua("distance_optimal")]
    public double? DistanceOptimal { get; set; }
	[InLua("distance_range")]
    public double? DistanceRange { get; set; }
	[InLua("distance_top_property_limit")]
    public double? DistanceTopPropertyLimit { get; set; }
	[InLua("elevation_max_range")]
    public double? ElevationMaxRange { get; set; }
	[InLua("elevation_optimal")]
    public double? ElevationOptimal { get; set; }
	[InLua("elevation_range")]
    public double? ElevationRange { get; set; }
	[InLua("elevation_top_property_limit")]
    public double? ElevationTopPropertyLimit { get; set; }
	[InLua("influence")]
    public double? Influence { get; set; }
	[InLua("max_influence")]
    public double? MaxInfluence { get; set; }
	[InLua("min_influence")]
    public double? MinInfluence { get; set; }
	[InLua("noise_layer")]
    public NoiseLayerID? NoiseLayer { get; set; }
	[InLua("noise_octaves_difference")]
    public double? NoiseOctavesDifference { get; set; }
	[InLua("noise_persistence")]
    public double? NoisePersistence { get; set; }
	[InLua("noise_scale")]
    public double? NoiseScale { get; set; }
	[InLua("richness_influence")]
    public double? RichnessInfluence { get; set; }
	[InLua("starting_area_weight_max_range")]
    public double? StartingAreaWeightMaxRange { get; set; }
	[InLua("starting_area_weight_optimal")]
    public double? StartingAreaWeightOptimal { get; set; }
	[InLua("starting_area_weight_range")]
    public double? StartingAreaWeightRange { get; set; }
	[InLua("starting_area_weight_top_property_limit")]
    public double? StartingAreaWeightTopPropertyLimit { get; set; }
	[InLua("temperature_max_range")]
    public double? TemperatureMaxRange { get; set; }
	[InLua("temperature_optimal")]
    public double? TemperatureOptimal { get; set; }
	[InLua("temperature_range")]
    public double? TemperatureRange { get; set; }
	[InLua("temperature_top_property_limit")]
    public double? TemperatureTopPropertyLimit { get; set; }
	[InLua("tier_from_start_max_range")]
    public double? TierFromStartMaxRange { get; set; }
	[InLua("tier_from_start_optimal")]
    public double? TierFromStartOptimal { get; set; }
	[InLua("tier_from_start_range")]
    public double? TierFromStartRange { get; set; }
	[InLua("tier_from_start_top_property_limit")]
    public double? TierFromStartTopPropertyLimit { get; set; }
	[InLua("water_max_range")]
    public double? WaterMaxRange { get; set; }
	[InLua("water_optimal")]
    public double? WaterOptimal { get; set; }
	[InLua("water_range")]
    public double? WaterRange { get; set; }
	[InLua("water_top_property_limit")]
    public double? WaterTopPropertyLimit { get; set; }

    
    
    
    

    

    
}