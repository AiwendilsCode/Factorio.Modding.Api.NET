using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpiderLegPart")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderLegPart 
{
    [InLua("bottom_end")]
    public Sprite? BottomEnd { get; set; }
	[InLua("bottom_end_length")]
    public float? BottomEndLength { get; set; }
	[InLua("middle")]
    public Sprite? Middle { get; set; }
	[InLua("middle_offset_from_bottom")]
    public float? MiddleOffsetFromBottom { get; set; }
	[InLua("middle_offset_from_top")]
    public float? MiddleOffsetFromTop { get; set; }
	[InLua("top_end")]
    public Sprite? TopEnd { get; set; }
	[InLua("top_end_length")]
    public float? TopEndLength { get; set; }

    
    
    
    

    

    
}