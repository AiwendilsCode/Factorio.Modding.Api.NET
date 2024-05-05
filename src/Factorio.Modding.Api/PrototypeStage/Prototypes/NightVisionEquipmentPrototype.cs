using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("NightVisionEquipmentPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NightVisionEquipmentPrototype : EquipmentPrototype
{
    [InLua("activate_sound")]
    public Sound? ActivateSound { get; set; }
	[InLua("color_lookup")]
    public DaytimeColorLookupTable ColorLookup { get; set; }
	[InLua("darkness_to_turn_on")]
    public float? DarknessToTurnOn { get; set; }
	[InLua("deactivate_sound")]
    public Sound? DeactivateSound { get; set; }
	[InLua("energy_input")]
    public Energy EnergyInput { get; set; }

    
    
    
    

    

    
}