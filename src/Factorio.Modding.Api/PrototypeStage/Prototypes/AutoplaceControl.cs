using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AutoplaceControl")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AutoplaceControl : PrototypeBase
{
    [InLua("can_be_disabled")]
    public bool? CanBeDisabled { get; set; }
	[InLua("category")]
    public CategoryEnum Category { get; set; }
	[InLua("richness")]
    public bool? Richness { get; set; }

    
    
    
    

    

    
}