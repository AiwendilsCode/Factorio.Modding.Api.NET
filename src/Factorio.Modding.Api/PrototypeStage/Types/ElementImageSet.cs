using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ElementImageSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElementImageSet 
{
    [InLua("base")]
    public ElementImageSetLayer? Base { get; set; }
	[InLua("glow")]
    public ElementImageSetLayer? Glow { get; set; }
	[InLua("shadow")]
    public ElementImageSetLayer? Shadow { get; set; }
	
    public ElementImageSetLayer? ElementImageSetLayer { get; set; }

    
    
    public ElementImageSet() {}
    private ElementImageSet(ElementImageSetLayer value)
    {
        ElementImageSetLayer = value;
    }

    public static implicit operator ElementImageSet(ElementImageSetLayer value) => new(value);

    
}