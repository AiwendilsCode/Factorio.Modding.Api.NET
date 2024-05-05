using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LootItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LootItem 
{
    [InLua("count_max")]
    public double? CountMax { get; set; }
	[InLua("count_min")]
    public double? CountMin { get; set; }
	[InLua("item")]
    public ItemID Item { get; set; }
	[InLua("probability")]
    public double? Probability { get; set; }

    
    
    
    

    

    
}