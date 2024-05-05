using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MouseCursorID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MouseCursorID 
{
    
    public string Value { get; set; }

    
    
    
    private MouseCursorID(string value)
    {
        Value = value;
    }

    public static implicit operator MouseCursorID(string value) => new(value);

    
}