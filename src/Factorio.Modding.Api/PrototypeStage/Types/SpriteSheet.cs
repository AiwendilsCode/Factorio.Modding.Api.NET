using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpriteSheet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpriteSheet : SpriteParameters
{
    [InLua("hr_version")]
    public SpriteSheet? HrVersion { get; set; }
	[InLua("layers")]
    public SpriteSheet[]? Layers { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("repeat_count")]
    public uint? RepeatCount { get; set; }
	[InLua("variation_count")]
    public uint? VariationCount { get; set; }

    
    
    
    

    

    
}