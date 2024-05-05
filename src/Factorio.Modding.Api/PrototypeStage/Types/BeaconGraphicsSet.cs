using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeaconGraphicsSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeaconGraphicsSet 
{
    [InLua("animation_layer")]
    public RenderLayer? AnimationLayer { get; set; }
	[InLua("animation_list")]
    public AnimationElement[]? AnimationList { get; set; }
	[InLua("animation_progress")]
    public float? AnimationProgress { get; set; }
	[InLua("apply_module_tint")]
    public ModuleTint? ApplyModuleTint { get; set; }
	[InLua("apply_module_tint_to_light")]
    public ModuleTint? ApplyModuleTintToLight { get; set; }
	[InLua("base_layer")]
    public RenderLayer? BaseLayer { get; set; }
	[InLua("draw_animation_when_idle")]
    public bool? DrawAnimationWhenIdle { get; set; }
	[InLua("draw_light_when_idle")]
    public bool? DrawLightWhenIdle { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("max_animation_progress")]
    public float? MaxAnimationProgress { get; set; }
	[InLua("min_animation_progress")]
    public float? MinAnimationProgress { get; set; }
	[InLua("module_icons_suppressed")]
    public bool? ModuleIconsSuppressed { get; set; }
	[InLua("module_tint_mode")]
    public ModuleTintModeEnum? ModuleTintMode { get; set; }
	[InLua("module_visualisations")]
    public BeaconModuleVisualizations[]? ModuleVisualisations { get; set; }
	[InLua("no_modules_tint")]
    public Color? NoModulesTint { get; set; }
	[InLua("random_animation_offset")]
    public bool? RandomAnimationOffset { get; set; }
	[InLua("top_layer")]
    public RenderLayer? TopLayer { get; set; }

    
    
    
    

    

    
}