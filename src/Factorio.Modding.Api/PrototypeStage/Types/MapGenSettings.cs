using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapGenSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapGenSettings 
{
    [InLua("autoplace_controls")]
    public Dictionary<AutoplaceControlID, FrequencySizeRichness>? AutoplaceControls { get; set; }
	[InLua("autoplace_settings")]
    public Dictionary<AutoplaceSettingsEnum, AutoplaceSettings>? AutoplaceSettings { get; set; }
	[InLua("cliff_settings")]
    public CliffPlacementSettings? CliffSettings { get; set; }
	[InLua("default_enable_all_autoplace_controls")]
    public bool? DefaultEnableAllAutoplaceControls { get; set; }
	[InLua("height")]
    public uint? Height { get; set; }
	[InLua("peaceful_mode")]
    public bool? PeacefulMode { get; set; }
	[InLua("property_expression_names")]
    public Dictionary<string, OneOf<string, bool, double>>? PropertyExpressionNames { get; set; }
	[InLua("seed")]
    public uint? Seed { get; set; }
	[InLua("starting_area")]
    public MapGenSize? StartingArea { get; set; }
	[InLua("starting_points")]
    public MapPosition[]? StartingPoints { get; set; }
	[InLua("terrain_segmentation")]
    public MapGenSize? TerrainSegmentation { get; set; }
	[InLua("water")]
    public MapGenSize? Water { get; set; }
	[InLua("width")]
    public uint? Width { get; set; }

    
    
    
    

    

    
}