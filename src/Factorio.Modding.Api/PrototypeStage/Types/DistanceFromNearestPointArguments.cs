using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DistanceFromNearestPointArguments")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DistanceFromNearestPointArguments 
{
    [InLua("maximum_distance")]
    public ConstantNoiseNumber? MaximumDistance { get; set; }
	[InLua("points")]
    public NoiseArrayConstruction Points { get; set; }
	[InLua("x")]
    public NoiseNumber X { get; set; }
	[InLua("y")]
    public NoiseNumber Y { get; set; }

    
    
    
    

    

    
}