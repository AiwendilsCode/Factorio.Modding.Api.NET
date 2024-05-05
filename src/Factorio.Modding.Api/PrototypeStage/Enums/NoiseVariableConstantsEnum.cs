using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum NoiseVariableConstantsEnum
{
    [InLua("map_seed")]
    MapSeed,
	[InLua("map_width")]
    MapWidth,
	[InLua("map_height")]
    MapHeight,
	[InLua("water_level")]
    WaterLevel,
	[InLua("finite_water_level")]
    FiniteWaterLevel,
	[InLua("wlc_elevation_minimum")]
    WlcElevationMinimum,
	[InLua("wlc_elevation_offset")]
    WlcElevationOffset,
	[InLua("cliff_elevation_offset")]
    CliffElevationOffset,
	[InLua("cliff_elevation_interval")]
    CliffElevationInterval,
	[InLua("control-setting:cliffs:richness:multiplier")]
    ControlSettingCliffsRichnessMultiplier,
	[InLua("terrace_elevation_offset")]
    TerraceElevationOffset,
	[InLua("terrace_elevation_interval")]
    TerraceElevationInterval,
	[InLua("starting_area_radius")]
    StartingAreaRadius,
	[InLua("starting_positions")]
    StartingPositions,
	[InLua("starting_lake_positions")]
    StartingLakePositions,
	[InLua("peaceful_mode")]
    PeacefulMode
}