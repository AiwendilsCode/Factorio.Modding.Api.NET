using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LinkedBeltPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LinkedBeltPrototype : TransportBeltConnectablePrototype
{
    [InLua("allow_blueprint_connection")]
    public bool? AllowBlueprintConnection { get; set; }
	[InLua("allow_clone_connection")]
    public bool? AllowCloneConnection { get; set; }
	[InLua("allow_side_loading")]
    public bool? AllowSideLoading { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("structure")]
    public LinkedBeltStructure Structure { get; set; }
	[InLua("structure_render_layer")]
    public RenderLayer? StructureRenderLayer { get; set; }

    
    
    
    

    

    
}