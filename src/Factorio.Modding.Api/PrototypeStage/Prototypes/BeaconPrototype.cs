using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BeaconPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeaconPrototype : EntityWithOwnerPrototype
{
    [InLua("allowed_effects")]
    public EffectTypeLimitation? AllowedEffects { get; set; }
	[InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("base_picture")]
    public Animation? BasePicture { get; set; }
	[InLua("distribution_effectivity")]
    public double DistributionEffectivity { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("graphics_set")]
    public BeaconGraphicsSet? GraphicsSet { get; set; }
	[InLua("module_specification")]
    public ModuleSpecification ModuleSpecification { get; set; }
	[InLua("radius_visualisation_picture")]
    public Sprite? RadiusVisualisationPicture { get; set; }
	[InLua("supply_area_distance")]
    public double SupplyAreaDistance { get; set; }

    
    
    
    

    

    
}