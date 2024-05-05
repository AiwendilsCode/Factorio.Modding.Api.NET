using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CurvedRailPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CurvedRailPrototype : RailPrototype
{
    [InLua("bending_type")]
    public string? BendingType { get; } = "turn";

    
    
    
    

    

    
}