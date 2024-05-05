using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LocomotivePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LocomotivePrototype : RollingStockPrototype
{
    [InLua("darkness_to_render_light_animation")]
    public float? DarknessToRenderLightAnimation { get; set; }
	[InLua("energy_source")]
    public OneOf<BurnerEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("front_light")]
    public LightDefinition? FrontLight { get; set; }
	[InLua("front_light_pictures")]
    public RotatedSprite? FrontLightPictures { get; set; }
	[InLua("max_power")]
    public Energy MaxPower { get; set; }
	[InLua("max_snap_to_train_stop_distance")]
    public float? MaxSnapToTrainStopDistance { get; set; }
	[InLua("reversing_power_modifier")]
    public double ReversingPowerModifier { get; set; }

    
    
    
    

    

    
}