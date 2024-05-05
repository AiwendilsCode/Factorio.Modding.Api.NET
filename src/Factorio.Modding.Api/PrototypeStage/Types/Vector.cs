using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Vector")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Vector 
{
    [InLua("x")]
    public double X { get; set; }
	[InLua("y")]
    public double Y { get; set; }

    
    
    public Vector() {}
    private Vector((double, double) value)
    {
        X = value.Item1;
Y = value.Item2;

    }

    public static implicit operator Vector((double, double) value) => new(value);

    
}