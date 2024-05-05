using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TrainStopLight")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TrainStopLight 
{
    [InLua("light")]
    public LightDefinition Light { get; set; }
	[InLua("picture")]
    public Sprite4Way Picture { get; set; }
	[InLua("red_picture")]
    public Sprite4Way RedPicture { get; set; }

    
    
    
    

    

    
}