using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ModuleTint")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ModuleTint 
{
    
    public ModuleTintEnum Value { get; set; }

    
    
    
    private ModuleTint(ModuleTintEnum value)
    {
        Value = value;
    }

    public static implicit operator ModuleTint(ModuleTintEnum value) => new(value);

    
}