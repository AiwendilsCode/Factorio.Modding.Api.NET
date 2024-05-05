using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("VirtualSignalPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class VirtualSignalPrototype : PrototypeBase
{
    [InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("subgroup")]
    public ItemSubGroupID? Subgroup { get; set; }

    
    
    
    

    

    
}