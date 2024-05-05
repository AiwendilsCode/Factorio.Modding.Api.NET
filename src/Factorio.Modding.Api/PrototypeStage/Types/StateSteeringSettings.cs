using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StateSteeringSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StateSteeringSettings 
{
    [InLua("force_unit_fuzzy_goto_behavior")]
    public bool ForceUnitFuzzyGotoBehavior { get; set; }
	[InLua("radius")]
    public double Radius { get; set; }
	[InLua("separation_factor")]
    public double SeparationFactor { get; set; }
	[InLua("separation_force")]
    public double SeparationForce { get; set; }

    
    
    
    

    

    
}