using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AmmoTurretPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoTurretPrototype : TurretPrototype
{
    [InLua("automated_ammo_count")]
    public ItemCountType AutomatedAmmoCount { get; set; }
	[InLua("entity_info_icon_shift")]
    public Vector? EntityInfoIconShift { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }

    
    
    
    

    

    
}