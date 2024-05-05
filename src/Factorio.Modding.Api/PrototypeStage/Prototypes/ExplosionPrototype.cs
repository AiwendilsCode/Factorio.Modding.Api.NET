using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ExplosionPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ExplosionPrototype : EntityPrototype
{
    [InLua("animations")]
    public AnimationVariations Animations { get; set; }
	[InLua("beam")]
    public bool? Beam { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("correct_rotation")]
    public bool? CorrectRotation { get; set; }
	[InLua("fade_in_duration")]
    public byte? FadeInDuration { get; set; }
	[InLua("fade_out_duration")]
    public byte? FadeOutDuration { get; set; }
	[InLua("height")]
    public float? Height { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("light_intensity_factor_final")]
    public float? LightIntensityFactorFinal { get; set; }
	[InLua("light_intensity_factor_initial")]
    public float? LightIntensityFactorInitial { get; set; }
	[InLua("light_intensity_peak_end_progress")]
    public float? LightIntensityPeakEndProgress { get; set; }
	[InLua("light_intensity_peak_start_progress")]
    public float? LightIntensityPeakStartProgress { get; set; }
	[InLua("light_size_factor_final")]
    public float? LightSizeFactorFinal { get; set; }
	[InLua("light_size_factor_initial")]
    public float? LightSizeFactorInitial { get; set; }
	[InLua("light_size_peak_end_progress")]
    public float? LightSizePeakEndProgress { get; set; }
	[InLua("light_size_peak_start_progress")]
    public float? LightSizePeakStartProgress { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("rotate")]
    public bool? Rotate { get; set; }
	[InLua("scale")]
    public float? Scale { get; set; }
	[InLua("scale_animation_speed")]
    public bool? ScaleAnimationSpeed { get; set; }
	[InLua("scale_deviation")]
    public float? ScaleDeviation { get; set; }
	[InLua("scale_end")]
    public float? ScaleEnd { get; set; }
	[InLua("scale_in_duration")]
    public byte? ScaleInDuration { get; set; }
	[InLua("scale_increment_per_tick")]
    public float? ScaleIncrementPerTick { get; set; }
	[InLua("scale_initial")]
    public float? ScaleInitial { get; set; }
	[InLua("scale_initial_deviation")]
    public float? ScaleInitialDeviation { get; set; }
	[InLua("scale_out_duration")]
    public byte? ScaleOutDuration { get; set; }
	[InLua("smoke")]
    public TrivialSmokeID? Smoke { get; set; }
	[InLua("smoke_count")]
    public ushort? SmokeCount { get; set; }
	[InLua("smoke_slow_down_factor")]
    public float? SmokeSlowDownFactor { get; set; }
	[InLua("sound")]
    public Sound? Sound { get; set; }

    
    
    
    

    

    
}