using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ReactorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ReactorPrototype : EntityWithOwnerPrototype
{
    [InLua("connection_patches_connected")]
    public SpriteVariations? ConnectionPatchesConnected { get; set; }
	[InLua("connection_patches_disconnected")]
    public SpriteVariations? ConnectionPatchesDisconnected { get; set; }
	[InLua("consumption")]
    public Energy Consumption { get; set; }
	[InLua("default_fuel_glow_color")]
    public Color? DefaultFuelGlowColor { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("heat_buffer")]
    public HeatBuffer HeatBuffer { get; set; }
	[InLua("heat_connection_patches_connected")]
    public SpriteVariations? HeatConnectionPatchesConnected { get; set; }
	[InLua("heat_connection_patches_disconnected")]
    public SpriteVariations? HeatConnectionPatchesDisconnected { get; set; }
	[InLua("heat_lower_layer_picture")]
    public Sprite? HeatLowerLayerPicture { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("lower_layer_picture")]
    public Sprite? LowerLayerPicture { get; set; }
	[InLua("meltdown_action")]
    public Trigger? MeltdownAction { get; set; }
	[InLua("neighbour_bonus")]
    public double? NeighbourBonus { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }
	[InLua("scale_energy_usage")]
    public bool? ScaleEnergyUsage { get; set; }
	[InLua("use_fuel_glow_color")]
    public bool? UseFuelGlowColor { get; set; }
	[InLua("working_light_picture")]
    public Sprite WorkingLightPicture { get; set; }

    
    
    
    

    

    
}