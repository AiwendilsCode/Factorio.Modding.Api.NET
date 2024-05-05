using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
using Factorio.Modding.Api.Common.Extensions;
using Factorio.Modding.Api.Common.Extensions;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RecipePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RecipePrototype : PrototypeBase
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
	[InLua("category")]
    public RecipeCategoryID? Category { get; set; }
	[InLua("crafting_machine_tint")]
    public CraftingMachineTint? CraftingMachineTint { get; set; }
	[InLua("emissions_multiplier")]
    public double? EmissionsMultiplier { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("energy_required")]
    public double? EnergyRequired { get; set; }
	[InLua("expensive")]
    public BoolOr<RecipeData>? Expensive {
                get
                {
                    return _expensive;
                }
                        
                set
                {
                    if (value is null)
                                    _expensive = new BoolOr<RecipeData>(false, default);
                                else
                                    _expensive = new BoolOr<RecipeData>(false, value.Value.GetAs<RecipeData>());
                }
            }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("hide_from_player_crafting")]
    public bool? HideFromPlayerCrafting { get; set; }
	[InLua("hide_from_stats")]
    public bool? HideFromStats { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("ingredients")]
    public IngredientPrototype[]? Ingredients { get; set; }
	[InLua("main_product")]
    public string? MainProduct { get; set; }
	[InLua("normal")]
    public BoolOr<RecipeData>? Normal {
                get
                {
                    return _normal;
                }
                        
                set
                {
                    if (value is null)
                                    _normal = new BoolOr<RecipeData>(false, default);
                                else
                                    _normal = new BoolOr<RecipeData>(false, value.Value.GetAs<RecipeData>());
                }
            }
	[InLua("overload_multiplier")]
    public uint? OverloadMultiplier { get; set; }
	[InLua("requester_paste_multiplier")]
    public uint? RequesterPasteMultiplier { get; set; }
	[InLua("result")]
    public ItemID? Result { get; set; }
	[InLua("result_count")]
    public ushort? ResultCount { get; set; }
	[InLua("results")]
    public ProductPrototype[]? Results { get; set; }
	[InLua("show_amount_in_title")]
    public bool? ShowAmountInTitle { get; set; }
	[InLua("subgroup")]
    public ItemSubGroupID? Subgroup { get; set; }
	[InLua("unlock_results")]
    public bool? UnlockResults { get; set; }

    private BoolOr<RecipeData>? _expensive ;
	private BoolOr<RecipeData>? _normal ;
    
    
    

    

    
}