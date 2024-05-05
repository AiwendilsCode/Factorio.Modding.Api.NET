using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseNumberTypes 
{
    
    public object Value { get; private set; }

    
    
    
    private NoiseNumberTypes(object value)
    {
        Value = value;
    }

    public static implicit operator NoiseNumberTypes(NoiseVariable value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionApplication value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseLiteralNumber value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseProcedureDelimiter value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseIfElseChain value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionAdd value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionSubtract value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionMultiply value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionDivide value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionExponentiate value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionFactorioQuickMultioctaveNoise value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionFactorioMultioctaveNoise value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionDistanceFromNearestPoint value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionFactorioBasisNoise value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionAbsoluteValue value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionClamp value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionRidge value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionTerrace value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionSpotNoise value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionRandomPenalty value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionLog2 value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionModulo value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionFloor value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionCeil value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionBitwiseAnd value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionBitwiseOr value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionBitwiseXor value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionBitwiseNot value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionSin value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionAtan2 value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionCos value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionLessThan value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionLessOrEqual value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionEquals value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionCompileTimeLog value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionNoiseLayerNameToID value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionAutoplaceProbability value) => new(value);

	public static implicit operator NoiseNumberTypes(NoiseFunctionAutoplaceRichness value) => new(value);

    
}