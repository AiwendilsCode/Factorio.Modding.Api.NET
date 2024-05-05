using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FontPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FontPrototype 
{
    [InLua("border")]
    public bool? Border { get; set; }
	[InLua("border_color")]
    public Color? BorderColor { get; set; }
	[InLua("filtered")]
    public bool? Filtered { get; set; }
	[InLua("from")]
    public string From { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("size")]
    public int Size { get; set; }
	[InLua("spacing")]
    public float? Spacing { get; set; }
	[InLua("type")]
    public string Type { get; } = "font";

    
    
    
    

    

    
}