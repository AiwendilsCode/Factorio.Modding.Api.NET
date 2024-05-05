using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UndergroundBeltStructure")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UndergroundBeltStructure 
{
    [InLua("back_patch")]
    public Sprite4Way? BackPatch { get; set; }
	[InLua("direction_in")]
    public Sprite4Way DirectionIn { get; set; }
	[InLua("direction_in_side_loading")]
    public Sprite4Way? DirectionInSideLoading { get; set; }
	[InLua("direction_out")]
    public Sprite4Way DirectionOut { get; set; }
	[InLua("direction_out_side_loading")]
    public Sprite4Way? DirectionOutSideLoading { get; set; }
	[InLua("front_patch")]
    public Sprite4Way? FrontPatch { get; set; }

    
    
    
    

    

    
}