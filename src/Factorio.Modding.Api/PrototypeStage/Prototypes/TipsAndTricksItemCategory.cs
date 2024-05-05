using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TipsAndTricksItemCategory")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TipsAndTricksItemCategory 
{
    [InLua("name")]
    public string Name { get; set; }
	[InLua("order")]
    public Order Order { get; set; }
	[InLua("type")]
    public string Type { get; } = "tips-and-tricks-item-category";

    
    
    
    

    

    
}