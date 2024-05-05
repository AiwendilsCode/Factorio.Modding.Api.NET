using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StackTransferTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StackTransferTipTrigger 
{
    [InLua("count")]
    public uint? Count { get; set; }
	[InLua("transfer")]
    public TransferEnum? Transfer { get; set; }
	[InLua("type")]
    public string Type { get; } = "stack-transfer";

    
    
    
    

    

    
}