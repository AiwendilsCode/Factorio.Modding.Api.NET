using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ItemWithEntityDataPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemWithEntityDataPrototype : ItemPrototype
{
    [InLua("icon_tintable")]
    public FileName? IconTintable { get; set; }
	[InLua("icon_tintable_mask")]
    public FileName? IconTintableMask { get; set; }
	[InLua("icon_tintable_masks")]
    public IconData[]? IconTintableMasks { get; set; }
	[InLua("icon_tintables")]
    public IconData[]? IconTintables { get; set; }

    
    
    
    

    

    
}