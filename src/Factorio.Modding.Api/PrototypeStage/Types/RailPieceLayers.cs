using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RailPieceLayers")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailPieceLayers 
{
    [InLua("backplates")]
    public SpriteVariations Backplates { get; set; }
	[InLua("metals")]
    public SpriteVariations Metals { get; set; }
	[InLua("segment_visualisation_continuing_back")]
    public Sprite? SegmentVisualisationContinuingBack { get; set; }
	[InLua("segment_visualisation_continuing_front")]
    public Sprite? SegmentVisualisationContinuingFront { get; set; }
	[InLua("segment_visualisation_ending_back")]
    public Sprite? SegmentVisualisationEndingBack { get; set; }
	[InLua("segment_visualisation_ending_front")]
    public Sprite? SegmentVisualisationEndingFront { get; set; }
	[InLua("segment_visualisation_middle")]
    public Sprite? SegmentVisualisationMiddle { get; set; }
	[InLua("stone_path")]
    public SpriteVariations StonePath { get; set; }
	[InLua("stone_path_background")]
    public SpriteVariations? StonePathBackground { get; set; }
	[InLua("ties")]
    public SpriteVariations Ties { get; set; }

    
    
    
    

    

    
}