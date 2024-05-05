using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Vector3D")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Vector3D 
{
    [InLua("x")]
    public float X { get; set; }
	[InLua("y")]
    public float Y { get; set; }
	[InLua("z")]
    public float Z { get; set; }

    
    
    public Vector3D() {}
    private Vector3D((float, float, float) value)
    {
        X = value.Item1;
Y = value.Item2;
Z = value.Item3;

    }

    public static implicit operator Vector3D((float, float, float) value) => new(value);

    
}