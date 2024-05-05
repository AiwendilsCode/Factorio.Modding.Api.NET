using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Animation4Way")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Animation4Way 
{
    [InLua("east")]
    public Animation? East { get; set; }
	[InLua("north")]
    public Animation North { get; set; }
	[InLua("south")]
    public Animation? South { get; set; }
	[InLua("west")]
    public Animation? West { get; set; }

    
    
    public Animation4Way() {}
    private Animation4Way(Animation value)
    {
        North = value;
    }

    public static implicit operator Animation4Way(Animation value) => new(value);

    
}