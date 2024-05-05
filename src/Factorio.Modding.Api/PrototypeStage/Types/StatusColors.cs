using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StatusColors")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StatusColors 
{
    [InLua("disabled")]
    public Color? Disabled { get; set; }
	[InLua("full_output")]
    public Color? FullOutput { get; set; }
	[InLua("idle")]
    public Color? Idle { get; set; }
	[InLua("insufficient_input")]
    public Color? InsufficientInput { get; set; }
	[InLua("low_power")]
    public Color? LowPower { get; set; }
	[InLua("no_minable_resources")]
    public Color? NoMinableResources { get; set; }
	[InLua("no_power")]
    public Color? NoPower { get; set; }
	[InLua("working")]
    public Color? Working { get; set; }

    
    
    
    

    

    
}