using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ToolPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ToolPrototype : ItemPrototype
{
    [InLua("durability")]
    public double? Durability { get; set; }
	[InLua("durability_description_key")]
    public string? DurabilityDescriptionKey { get; set; }
	[InLua("durability_description_value")]
    public string? DurabilityDescriptionValue { get; set; }
	[InLua("infinite")]
    public bool? Infinite { get; set; }

    
    
    
    

    

    
}