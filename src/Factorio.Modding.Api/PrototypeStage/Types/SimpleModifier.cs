using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SimpleModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SimpleModifier : BaseModifier
{
    [InLua("modifier")]
    public double Modifier { get; set; }

    
    
    
    

    

    
}