using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("HeatEnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class HeatEnergySource : BaseEnergySource
{
    [InLua("connections")]
    public HeatConnection[]? Connections { get; set; }
	[InLua("default_temperature")]
    public double? DefaultTemperature { get; set; }
	[InLua("heat_glow")]
    public Sprite4Way? HeatGlow { get; set; }
	[InLua("heat_picture")]
    public Sprite4Way? HeatPicture { get; set; }
	[InLua("heat_pipe_covers")]
    public Sprite4Way? HeatPipeCovers { get; set; }
	[InLua("max_temperature")]
    public double MaxTemperature { get; set; }
	[InLua("max_transfer")]
    public Energy MaxTransfer { get; set; }
	[InLua("min_temperature_gradient")]
    public double? MinTemperatureGradient { get; set; }
	[InLua("min_working_temperature")]
    public double? MinWorkingTemperature { get; set; }
	[InLua("minimum_glow_temperature")]
    public float? MinimumGlowTemperature { get; set; }
	[InLua("pipe_covers")]
    public Sprite4Way? PipeCovers { get; set; }
	[InLua("specific_heat")]
    public Energy SpecificHeat { get; set; }
	[InLua("type")]
    public string Type { get; } = "heat";

    
    
    
    

    

    
}