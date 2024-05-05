using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EquipmentShape")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EquipmentShape 
{
    [InLua("height")]
    public uint Height { get; set; }
	[InLua("points")]
    public uint[][]? Points { get; set; }
	[InLua("type")]
    public TypeEnum Type { get; set; }
	[InLua("width")]
    public uint Width { get; set; }

    
    
    
    

    

    
}