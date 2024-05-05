using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LogisticContainerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LogisticContainerPrototype : ContainerPrototype
{
    [InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("animation_sound")]
    public Sound? AnimationSound { get; set; }
	[InLua("landing_location_offset")]
    public Vector? LandingLocationOffset { get; set; }
	[InLua("logistic_mode")]
    public LogisticModeEnum LogisticMode { get; set; }
	[InLua("max_logistic_slots")]
    public ushort? MaxLogisticSlots { get; set; }
	[InLua("opened_duration")]
    public byte? OpenedDuration { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }
	[InLua("render_not_in_network_icon")]
    public bool? RenderNotInNetworkIcon { get; set; }
	[InLua("use_exact_mode")]
    public bool? UseExactMode { get; set; }

    
    
    
    

    

    
}