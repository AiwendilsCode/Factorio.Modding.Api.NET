using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("PrototypeBase")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PrototypeBase 
{
    [InLua("localised_description")]
    public LocalisedString? LocalisedDescription { get; set; }
	[InLua("localised_name")]
    public LocalisedString? LocalisedName { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("order")]
    public Order? Order { get; set; }
	[InLua("type")]
    public string Type { get; set; }

    
    
    
    

    

    
}