using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EquipmentGridPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EquipmentGridPrototype : PrototypeBase
{
    [InLua("equipment_categories")]
    public EquipmentCategoryID[] EquipmentCategories { get; set; }
	[InLua("height")]
    public uint Height { get; set; }
	[InLua("locked")]
    public bool? Locked { get; set; }
	[InLua("width")]
    public uint Width { get; set; }

    
    
    
    

    

    
}