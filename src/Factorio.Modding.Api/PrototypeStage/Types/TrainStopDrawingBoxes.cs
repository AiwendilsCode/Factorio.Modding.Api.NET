using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TrainStopDrawingBoxes")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TrainStopDrawingBoxes 
{
    [InLua("east")]
    public BoundingBox East { get; set; }
	[InLua("north")]
    public BoundingBox North { get; set; }
	[InLua("south")]
    public BoundingBox South { get; set; }
	[InLua("west")]
    public BoundingBox West { get; set; }

    
    
    
    

    

    
}