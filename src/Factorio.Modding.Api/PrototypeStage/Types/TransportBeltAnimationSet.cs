using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TransportBeltAnimationSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TransportBeltAnimationSet 
{
    [InLua("animation_set")]
    public RotatedAnimation AnimationSet { get; set; }
	[InLua("east_index")]
    public byte? EastIndex { get; set; }
	[InLua("ending_east_index")]
    public byte? EndingEastIndex { get; set; }
	[InLua("ending_north_index")]
    public byte? EndingNorthIndex { get; set; }
	[InLua("ending_patch")]
    public Sprite4Way? EndingPatch { get; set; }
	[InLua("ending_south_index")]
    public byte? EndingSouthIndex { get; set; }
	[InLua("ending_west_index")]
    public byte? EndingWestIndex { get; set; }
	[InLua("ends_with_stopper")]
    public bool? EndsWithStopper { get; set; }
	[InLua("north_index")]
    public byte? NorthIndex { get; set; }
	[InLua("south_index")]
    public byte? SouthIndex { get; set; }
	[InLua("starting_east_index")]
    public byte? StartingEastIndex { get; set; }
	[InLua("starting_north_index")]
    public byte? StartingNorthIndex { get; set; }
	[InLua("starting_south_index")]
    public byte? StartingSouthIndex { get; set; }
	[InLua("starting_west_index")]
    public byte? StartingWestIndex { get; set; }
	[InLua("west_index")]
    public byte? WestIndex { get; set; }

    
    
    
    

    

    
}