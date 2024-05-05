using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileIDRestriction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileIDRestriction 
{
    
    public OneOf<TileID, (TileID, TileID)> Value { get; set; }

    
    
    
    private TileIDRestriction(TileID value)
    {
        Value = value;
    }

	private TileIDRestriction((TileID, TileID) value)
    {
        Value = value;

    }

    public static implicit operator TileIDRestriction(TileID value) => new(value);

	public static implicit operator TileIDRestriction((TileID, TileID) value) => new(value);

    
}