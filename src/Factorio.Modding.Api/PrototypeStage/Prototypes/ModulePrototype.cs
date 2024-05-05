using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ModulePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ModulePrototype : ItemPrototype
{
    [InLua("art_style")]
    public string? ArtStyle { get; set; }
	[InLua("beacon_tint")]
    public BeaconVisualizationTints? BeaconTint { get; set; }
	[InLua("category")]
    public ModuleCategoryID Category { get; set; }
	[InLua("effect")]
    public Effect Effect { get; set; }
	[InLua("limitation")]
    public RecipeID[]? Limitation { get; set; }
	[InLua("limitation_blacklist")]
    public RecipeID[]? LimitationBlacklist { get; set; }
	[InLua("limitation_message_key")]
    public string? LimitationMessageKey { get; set; }
	[InLua("requires_beacon_alt_mode")]
    public bool? RequiresBeaconAltMode { get; set; }
	[InLua("tier")]
    public uint Tier { get; set; }

    
    
    
    

    

    
}