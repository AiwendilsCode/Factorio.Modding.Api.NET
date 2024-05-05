using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BuildEntityTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BuildEntityTipTrigger 
{
    [InLua("build_by_dragging")]
    public bool? BuildByDragging { get; set; }
	[InLua("build_in_line")]
    public bool? BuildInLine { get; set; }
	[InLua("consecutive")]
    public bool? Consecutive { get; set; }
	[InLua("count")]
    public uint? Count { get; set; }
	[InLua("entity")]
    public EntityID? Entity { get; set; }
	[InLua("linear_power_pole_line")]
    public bool? LinearPowerPoleLine { get; set; }
	[InLua("match_type_only")]
    public bool? MatchTypeOnly { get; set; }
	[InLua("type")]
    public string Type { get; } = "build-entity";

    
    
    
    

    

    
}