using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ElectricEnergyInterfacePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElectricEnergyInterfacePrototype : EntityWithOwnerPrototype
{
    [InLua("allow_copy_paste")]
    public bool? AllowCopyPaste { get; set; }
	[InLua("animation")]
    public Animation? Animation { get; set; }
	[InLua("animations")]
    public Animation4Way? Animations { get; set; }
	[InLua("continuous_animation")]
    public bool? ContinuousAnimation { get; set; }
	[InLua("energy_production")]
    public Energy? EnergyProduction { get; set; }
	[InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy? EnergyUsage { get; set; }
	[InLua("gui_mode")]
    public GuiModeEnum? GuiMode { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }
	[InLua("pictures")]
    public Sprite4Way? Pictures { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }

    
    
    
    

    

    
}