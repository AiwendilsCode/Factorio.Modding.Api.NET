using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FrequencySizeRichness")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FrequencySizeRichness 
{
    [InLua("frequency")]
    public MapGenSize? Frequency { get; set; }
	[InLua("richness")]
    public MapGenSize? Richness { get; set; }
	[InLua("size")]
    public MapGenSize? Size { get; set; }

    
    
    
    

    

    
}