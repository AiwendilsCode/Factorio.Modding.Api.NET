using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TrivialSmokePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TrivialSmokePrototype : PrototypeBase
{
    [InLua("affected_by_wind")]
    public bool? AffectedByWind { get; set; }
	[InLua("animation")]
    public Animation Animation { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("cyclic")]
    public bool? Cyclic { get; set; }
	[InLua("duration")]
    public uint Duration { get; set; }
	[InLua("end_scale")]
    public float? EndScale { get; set; }
	[InLua("fade_away_duration")]
    public uint? FadeAwayDuration { get; set; }
	[InLua("fade_in_duration")]
    public uint? FadeInDuration { get; set; }
	[InLua("glow_animation")]
    public Animation? GlowAnimation { get; set; }
	[InLua("glow_fade_away_duration")]
    public uint? GlowFadeAwayDuration { get; set; }
	[InLua("movement_slow_down_factor")]
    public double? MovementSlowDownFactor { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("show_when_smoke_off")]
    public bool? ShowWhenSmokeOff { get; set; }
	[InLua("spread_duration")]
    public uint? SpreadDuration { get; set; }
	[InLua("start_scale")]
    public float? StartScale { get; set; }

    
    
    
    

    

    
}