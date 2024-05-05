using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RailPlannerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailPlannerPrototype : ItemPrototype
{
    [InLua("curved_rail")]
    public EntityID CurvedRail { get; set; }
	[InLua("straight_rail")]
    public EntityID StraightRail { get; set; }

    
    
    
    

    

    
}