using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RotatedAnimation4Way")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RotatedAnimation4Way 
{
    [InLua("east")]
    public RotatedAnimation? East { get; set; }
	[InLua("north")]
    public RotatedAnimation North { get; set; }
	[InLua("south")]
    public RotatedAnimation? South { get; set; }
	[InLua("west")]
    public RotatedAnimation? West { get; set; }

    
    
    public RotatedAnimation4Way() {}
    private RotatedAnimation4Way(RotatedAnimation value)
    {
        North = value;
    }

    public static implicit operator RotatedAnimation4Way(RotatedAnimation value) => new(value);

    
}