using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("MarketPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MarketPrototype : EntityWithOwnerPrototype
{
    [InLua("allow_access_to_all_forces")]
    public bool? AllowAccessToAllForces { get; set; }
	[InLua("picture")]
    public Sprite Picture { get; set; }

    
    
    
    

    

    
}