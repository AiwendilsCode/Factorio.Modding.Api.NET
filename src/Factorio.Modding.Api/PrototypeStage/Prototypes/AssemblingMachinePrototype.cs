using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AssemblingMachinePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AssemblingMachinePrototype : CraftingMachinePrototype
{
    [InLua("entity_info_icon_shift")]
    public Vector? EntityInfoIconShift { get; set; }
	[InLua("fixed_recipe")]
    public RecipeID? FixedRecipe { get; set; }
	[InLua("gui_title_key")]
    public string? GuiTitleKey { get; set; }
	[InLua("ingredient_count")]
    public byte? IngredientCount { get; set; }

    
    
    
    

    

    
}