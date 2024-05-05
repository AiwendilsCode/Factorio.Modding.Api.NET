using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("GateOverRailBuildTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GateOverRailBuildTipTrigger 
{
    [InLua("count")]
    public uint? Count { get; set; }
	[InLua("type")]
    public string Type { get; } = "gate-over-rail-build";

    
    
    
    

    

    
}