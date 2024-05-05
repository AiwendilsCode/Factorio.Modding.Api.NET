using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PipeToGroundPictures")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PipeToGroundPictures 
{
    [InLua("down")]
    public Sprite Down { get; set; }
	[InLua("left")]
    public Sprite Left { get; set; }
	[InLua("right")]
    public Sprite Right { get; set; }
	[InLua("up")]
    public Sprite Up { get; set; }

    
    
    
    

    

    
}