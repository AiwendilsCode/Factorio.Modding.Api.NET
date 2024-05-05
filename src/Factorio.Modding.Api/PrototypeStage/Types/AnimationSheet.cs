using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimationSheet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationSheet : AnimationParameters
{
    [InLua("frame_count")]
    public uint? FrameCount { get; set; }
	[InLua("hr_version")]
    public AnimationSheet? HrVersion { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("variation_count")]
    public uint VariationCount { get; set; }

    
    
    
    

    

    
}