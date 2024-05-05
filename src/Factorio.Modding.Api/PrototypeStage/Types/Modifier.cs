using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Modifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Modifier 
{
    
    public ModifierTypes Value { get; set; }

    
    
    
    private Modifier(ModifierTypes value)
    {
        Value = value;
    }

    public static implicit operator Modifier(ModifierTypes value) => new(value);

    
}