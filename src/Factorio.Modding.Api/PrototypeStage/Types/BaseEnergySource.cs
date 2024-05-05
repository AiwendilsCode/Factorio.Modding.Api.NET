using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BaseEnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BaseEnergySource 
{
    [InLua("emissions_per_minute")]
    public double? EmissionsPerMinute { get; set; }
	[InLua("render_no_network_icon")]
    public bool? RenderNoNetworkIcon { get; set; }
	[InLua("render_no_power_icon")]
    public bool? RenderNoPowerIcon { get; set; }

    
    
    
    

    

    
}