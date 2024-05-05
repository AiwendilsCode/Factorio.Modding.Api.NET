using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TransportBeltAnimationSetWithCorners")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TransportBeltAnimationSetWithCorners : TransportBeltAnimationSet
{
    [InLua("east_to_north_index")]
    public byte? EastToNorthIndex { get; set; }
	[InLua("east_to_south_index")]
    public byte? EastToSouthIndex { get; set; }
	[InLua("north_to_east_index")]
    public byte? NorthToEastIndex { get; set; }
	[InLua("north_to_west_index")]
    public byte? NorthToWestIndex { get; set; }
	[InLua("south_to_east_index")]
    public byte? SouthToEastIndex { get; set; }
	[InLua("south_to_west_index")]
    public byte? SouthToWestIndex { get; set; }
	[InLua("west_to_north_index")]
    public byte? WestToNorthIndex { get; set; }
	[InLua("west_to_south_index")]
    public byte? WestToSouthIndex { get; set; }

    
    
    
    

    

    
}