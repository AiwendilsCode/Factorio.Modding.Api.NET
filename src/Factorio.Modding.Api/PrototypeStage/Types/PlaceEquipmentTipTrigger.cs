using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PlaceEquipmentTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlaceEquipmentTipTrigger 
{
    [InLua("count")]
    public uint? Count { get; set; }
	[InLua("equipment")]
    public EquipmentID? Equipment { get; set; }
	[InLua("type")]
    public string Type { get; } = "place-equipment";

    
    
    
    

    

    
}