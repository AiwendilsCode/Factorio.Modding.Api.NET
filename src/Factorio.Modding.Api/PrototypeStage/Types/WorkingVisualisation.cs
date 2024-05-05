using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("WorkingVisualisation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WorkingVisualisation 
{
    [InLua("align_to_waypoint")]
    public bool? AlignToWaypoint { get; set; }
	[InLua("always_draw")]
    public bool? AlwaysDraw { get; set; }
	[InLua("animated_shift")]
    public bool? AnimatedShift { get; set; }
	[InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("apply_recipe_tint")]
    public ApplyRecipeTintEnum? ApplyRecipeTint { get; set; }
	[InLua("apply_tint")]
    public ApplyTintEnum? ApplyTint { get; set; }
	[InLua("constant_speed")]
    public bool? ConstantSpeed { get; set; }
	[InLua("draw_as_light")]
    public bool? DrawAsLight { get; set; }
	[InLua("draw_as_sprite")]
    public bool? DrawAsSprite { get; set; }
	[InLua("east_animation")]
    public Animation? EastAnimation { get; set; }
	[InLua("east_position")]
    public Vector? EastPosition { get; set; }
	[InLua("effect")]
    public EffectEnum? Effect { get; set; }
	[InLua("fadeout")]
    public bool? Fadeout { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("north_animation")]
    public Animation? NorthAnimation { get; set; }
	[InLua("north_position")]
    public Vector? NorthPosition { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_draw_order")]
    public sbyte? SecondaryDrawOrder { get; set; }
	[InLua("south_animation")]
    public Animation? SouthAnimation { get; set; }
	[InLua("south_position")]
    public Vector? SouthPosition { get; set; }
	[InLua("synced_fadeout")]
    public bool? SyncedFadeout { get; set; }
	[InLua("west_animation")]
    public Animation? WestAnimation { get; set; }
	[InLua("west_position")]
    public Vector? WestPosition { get; set; }

    
    
    
    

    

    
}