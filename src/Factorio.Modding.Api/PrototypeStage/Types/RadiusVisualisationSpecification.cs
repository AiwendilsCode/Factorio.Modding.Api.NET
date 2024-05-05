using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RadiusVisualisationSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RadiusVisualisationSpecification 
{
    [InLua("distance")]
    public double? Distance { get; set; }
	[InLua("draw_in_cursor")]
    public bool? DrawInCursor { get; set; }
	[InLua("draw_on_selection")]
    public bool? DrawOnSelection { get; set; }
	[InLua("offset")]
    public Vector? Offset { get; set; }
	[InLua("sprite")]
    public Sprite? Sprite { get; set; }

    
    
    
    

    

    
}