using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeaconModuleVisualizations")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeaconModuleVisualizations 
{
    [InLua("art_style")]
    public string ArtStyle { get; set; }
	[InLua("slots")]
    public BeaconModuleVisualization[][]? Slots { get; set; }
	[InLua("tier_offset")]
    public int? TierOffset { get; set; }
	[InLua("use_for_empty_slots")]
    public bool? UseForEmptySlots { get; set; }

    
    
    
    

    

    
}