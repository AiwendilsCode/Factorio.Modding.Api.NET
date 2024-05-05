using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArmorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArmorPrototype : ToolPrototype
{
    [InLua("equipment_grid")]
    public EquipmentGridID? EquipmentGrid { get; set; }
	[InLua("inventory_size_bonus")]
    public ItemStackIndex? InventorySizeBonus { get; set; }
	[InLua("resistances")]
    public Resistance[]? Resistances { get; set; }

    
    
    
    

    

    
}