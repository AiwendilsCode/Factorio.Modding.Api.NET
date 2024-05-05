using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AmmoItemPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoItemPrototype : ItemPrototype
{
    [InLua("ammo_type")]
    public OneOf<AmmoType, AmmoType[]> AmmoType { get; set; }
	[InLua("magazine_size")]
    public float? MagazineSize { get; set; }
	[InLua("reload_time")]
    public float? ReloadTime { get; set; }

    
    
    
    

    

    
}