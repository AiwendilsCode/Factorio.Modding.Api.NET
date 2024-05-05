using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RadarPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RadarPrototype : EntityWithOwnerPrototype
{
    [InLua("energy_per_nearby_scan")]
    public Energy EnergyPerNearbyScan { get; set; }
	[InLua("energy_per_sector")]
    public Energy EnergyPerSector { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }
	[InLua("max_distance_of_nearby_sector_revealed")]
    public uint MaxDistanceOfNearbySectorRevealed { get; set; }
	[InLua("max_distance_of_sector_revealed")]
    public uint MaxDistanceOfSectorRevealed { get; set; }
	[InLua("pictures")]
    public RotatedSprite Pictures { get; set; }
	[InLua("radius_minimap_visualisation_color")]
    public Color? RadiusMinimapVisualisationColor { get; set; }
	[InLua("rotation_speed")]
    public double? RotationSpeed { get; set; }

    
    
    
    

    

    
}