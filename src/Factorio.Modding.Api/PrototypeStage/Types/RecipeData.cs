using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RecipeData")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RecipeData 
{
    [InLua("allow_as_intermediate")]
    public bool? AllowAsIntermediate { get; set; }
	[InLua("allow_decomposition")]
    public bool? AllowDecomposition { get; set; }
	[InLua("allow_inserter_overload")]
    public bool? AllowInserterOverload { get; set; }
	[InLua("allow_intermediates")]
    public bool? AllowIntermediates { get; set; }
	[InLua("always_show_made_in")]
    public bool? AlwaysShowMadeIn { get; set; }
	[InLua("always_show_products")]
    public bool? AlwaysShowProducts { get; set; }
	[InLua("emissions_multiplier")]
    public double? EmissionsMultiplier { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("energy_required")]
    public double? EnergyRequired { get; set; }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("hide_from_player_crafting")]
    public bool? HideFromPlayerCrafting { get; set; }
	[InLua("hide_from_stats")]
    public bool? HideFromStats { get; set; }
	[InLua("ingredients")]
    public IngredientPrototype[] Ingredients { get; set; }
	[InLua("main_product")]
    public string? MainProduct { get; set; }
	[InLua("overload_multiplier")]
    public uint? OverloadMultiplier { get; set; }
	[InLua("requester_paste_multiplier")]
    public uint? RequesterPasteMultiplier { get; set; }
	[InLua("result")]
    public ItemID? Result { get; set; }
	[InLua("result_count")]
    public ushort? ResultCount { get; set; }
	[InLua("results")]
    public ProductPrototype[] Results { get; set; }
	[InLua("show_amount_in_title")]
    public bool? ShowAmountInTitle { get; set; }
	[InLua("unlock_results")]
    public bool? UnlockResults { get; set; }

    
    
    
    

    

    
}