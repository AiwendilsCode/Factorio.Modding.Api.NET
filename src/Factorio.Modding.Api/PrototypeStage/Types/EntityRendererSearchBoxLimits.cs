using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EntityRendererSearchBoxLimits")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityRendererSearchBoxLimits 
{
    [InLua("bottom")]
    public byte Bottom { get; set; }
	[InLua("left")]
    public byte Left { get; set; }
	[InLua("right")]
    public byte Right { get; set; }
	[InLua("top")]
    public byte Top { get; set; }

    
    
    
    

    

    
}