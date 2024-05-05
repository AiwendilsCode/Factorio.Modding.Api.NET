using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SpidertronRemotePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpidertronRemotePrototype : ItemPrototype
{
    [InLua("icon_color_indicator_mask")]
    public FileName? IconColorIndicatorMask { get; set; }
	[InLua("icon_color_indicator_masks")]
    public IconData[]? IconColorIndicatorMasks { get; set; }
	[InLua("stack_size")]
    public double StackSize { get; } = 1;

    
    
    
    

    

    
}