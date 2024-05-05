using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PlaceAsTile")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlaceAsTile 
{
    [InLua("condition")]
    public CollisionMask Condition { get; set; }
	[InLua("condition_size")]
    public int ConditionSize { get; set; }
	[InLua("result")]
    public TileID Result { get; set; }

    
    
    
    

    

    
}