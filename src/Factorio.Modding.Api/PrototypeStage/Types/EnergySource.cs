using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EnergySource 
{
    
    public OneOf<ElectricEnergySource, BurnerEnergySource, HeatEnergySource, FluidEnergySource, VoidEnergySource> Value { get; set; }

    
    
    
    private EnergySource(ElectricEnergySource value)
    {
        Value = value;
    }

	private EnergySource(BurnerEnergySource value)
    {
        Value = value;
    }

	private EnergySource(HeatEnergySource value)
    {
        Value = value;
    }

	private EnergySource(FluidEnergySource value)
    {
        Value = value;
    }

	private EnergySource(VoidEnergySource value)
    {
        Value = value;
    }

    public static implicit operator EnergySource(ElectricEnergySource value) => new(value);

	public static implicit operator EnergySource(BurnerEnergySource value) => new(value);

	public static implicit operator EnergySource(HeatEnergySource value) => new(value);

	public static implicit operator EnergySource(FluidEnergySource value) => new(value);

	public static implicit operator EnergySource(VoidEnergySource value) => new(value);

    
}