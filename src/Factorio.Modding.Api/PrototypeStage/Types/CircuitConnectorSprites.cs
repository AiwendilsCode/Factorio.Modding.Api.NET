using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CircuitConnectorSprites")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CircuitConnectorSprites 
{
    [InLua("blue_led_light_offset")]
    public Vector? BlueLedLightOffset { get; set; }
	[InLua("connector_main")]
    public Sprite? ConnectorMain { get; set; }
	[InLua("connector_shadow")]
    public Sprite? ConnectorShadow { get; set; }
	[InLua("led_blue")]
    public Sprite LedBlue { get; set; }
	[InLua("led_blue_off")]
    public Sprite? LedBlueOff { get; set; }
	[InLua("led_green")]
    public Sprite LedGreen { get; set; }
	[InLua("led_light")]
    public LightDefinition LedLight { get; set; }
	[InLua("led_red")]
    public Sprite LedRed { get; set; }
	[InLua("red_green_led_light_offset")]
    public Vector? RedGreenLedLightOffset { get; set; }
	[InLua("wire_pins")]
    public Sprite? WirePins { get; set; }
	[InLua("wire_pins_shadow")]
    public Sprite? WirePinsShadow { get; set; }

    
    
    
    

    

    
}