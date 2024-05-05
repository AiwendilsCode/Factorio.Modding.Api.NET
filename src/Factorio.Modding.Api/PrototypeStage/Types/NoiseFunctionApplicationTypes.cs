using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseFunctionApplicationTypes 
{
    
    public object Value { get; private set; }

    
    
    
    private NoiseFunctionApplicationTypes(object value)
    {
        Value = value;
    }

    public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionAdd value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionSubtract value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionMultiply value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionDivide value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionExponentiate value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionAbsoluteValue value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionClamp value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionCompileTimeLog value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionDistanceFromNearestPoint value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionRidge value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionTerrace value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionModulo value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionFloor value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionCeil value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionBitwiseAnd value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionBitwiseOr value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionBitwiseXor value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionBitwiseNot value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionSin value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionCos value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionAtan2 value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionLessThan value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionLessOrEqual value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionEquals value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionFactorioBasisNoise value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionFactorioQuickMultioctaveNoise value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionRandomPenalty value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionLog2 value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionNoiseLayerNameToID value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionAutoplaceProbability value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionAutoplaceRichness value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionOffsetPoints value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionFactorioMultioctaveNoise value) => new(value);

	public static implicit operator NoiseFunctionApplicationTypes(NoiseFunctionSpotNoise value) => new(value);

    
}