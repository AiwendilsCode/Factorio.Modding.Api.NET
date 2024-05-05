using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CraftingMachinePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CraftingMachinePrototype : EntityWithOwnerPrototype
{
    [InLua("allowed_effects")]
    public EffectTypeLimitation? AllowedEffects { get; set; }
	[InLua("always_draw_idle_animation")]
    public bool? AlwaysDrawIdleAnimation { get; set; }
	[InLua("animation")]
    public Animation4Way? Animation { get; set; }
	[InLua("base_productivity")]
    public float? BaseProductivity { get; set; }
	[InLua("crafting_categories")]
    public RecipeCategoryID[] CraftingCategories { get; set; }
	[InLua("crafting_speed")]
    public double CraftingSpeed { get; set; }
	[InLua("default_recipe_tint")]
    public DefaultRecipeTint? DefaultRecipeTint { get; set; }
	[InLua("draw_entity_info_icon_background")]
    public bool? DrawEntityInfoIconBackground { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("entity_info_icon_shift")]
    public Vector? EntityInfoIconShift { get; set; }
	[InLua("fluid_boxes")]
    public FluidBox[]? FluidBoxes { get; set; }
	[InLua("idle_animation")]
    public Animation4Way? IdleAnimation { get; set; }
	[InLua("match_animation_speed_to_activity")]
    public bool? MatchAnimationSpeedToActivity { get; set; }
	[InLua("module_specification")]
    public ModuleSpecification? ModuleSpecification { get; set; }
	[InLua("return_ingredients_on_change")]
    public bool? ReturnIngredientsOnChange { get; set; }
	[InLua("scale_entity_info_icon")]
    public bool? ScaleEntityInfoIcon { get; set; }
	[InLua("shift_animation_transition_duration")]
    public ushort? ShiftAnimationTransitionDuration { get; set; }
	[InLua("shift_animation_waypoint_stop_duration")]
    public ushort? ShiftAnimationWaypointStopDuration { get; set; }
	[InLua("shift_animation_waypoints")]
    public ShiftAnimationWaypoints? ShiftAnimationWaypoints { get; set; }
	[InLua("show_recipe_icon")]
    public bool? ShowRecipeIcon { get; set; }
	[InLua("show_recipe_icon_on_map")]
    public bool? ShowRecipeIconOnMap { get; set; }
	[InLua("status_colors")]
    public StatusColors? StatusColors { get; set; }
	[InLua("working_visualisations")]
    public WorkingVisualisation[]? WorkingVisualisations { get; set; }

    
    
    
    

    

    
}