using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("NoiseExpression")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class NoiseExpression 
{
    
    public OneOf<NoiseVariable, NoiseFunctionApplication, NoiseLiteralBoolean, NoiseLiteralNumber, NoiseLiteralString, NoiseLiteralObject, NoiseLiteralExpression, NoiseArrayConstruction, NoiseProcedureDelimiter, NoiseIfElseChain> Value { get; set; }

    
    
    
    private NoiseExpression(NoiseVariable value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseFunctionApplication value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseLiteralBoolean value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseLiteralNumber value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseLiteralString value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseLiteralObject value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseLiteralExpression value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseArrayConstruction value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseProcedureDelimiter value)
    {
        Value = value;
    }

	private NoiseExpression(NoiseIfElseChain value)
    {
        Value = value;
    }

    public static implicit operator NoiseExpression(NoiseVariable value) => new(value);

	public static implicit operator NoiseExpression(NoiseFunctionApplication value) => new(value);

	public static implicit operator NoiseExpression(NoiseLiteralBoolean value) => new(value);

	public static implicit operator NoiseExpression(NoiseLiteralNumber value) => new(value);

	public static implicit operator NoiseExpression(NoiseLiteralString value) => new(value);

	public static implicit operator NoiseExpression(NoiseLiteralObject value) => new(value);

	public static implicit operator NoiseExpression(NoiseLiteralExpression value) => new(value);

	public static implicit operator NoiseExpression(NoiseArrayConstruction value) => new(value);

	public static implicit operator NoiseExpression(NoiseProcedureDelimiter value) => new(value);

	public static implicit operator NoiseExpression(NoiseIfElseChain value) => new(value);

    
}