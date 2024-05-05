using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapGenPreset")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapGenPreset 
{
    [InLua("advanced_settings")]
    public AdvancedMapGenSettings? AdvancedSettings { get; set; }
	[InLua("basic_settings")]
    public MapGenSettings? BasicSettings { get; set; }
	[InLua("default")]
    public bool? Default { get; set; }
	[InLua("order")]
    public Order Order { get; set; }

    
    
    
    

    

    
}