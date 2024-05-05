using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BoxSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BoxSpecification 
{
    [InLua("is_whole_box")]
    public bool? IsWholeBox { get; set; }
	[InLua("max_side_length")]
    public double? MaxSideLength { get; set; }
	[InLua("side_height")]
    public double? SideHeight { get; set; }
	[InLua("side_length")]
    public double? SideLength { get; set; }
	[InLua("sprite")]
    public Sprite Sprite { get; set; }

    
    
    
    

    

    
}