using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateEntityTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateEntityTriggerEffectItem : TriggerEffectItem
{
    [InLua("check_buildability")]
    public bool? CheckBuildability { get; set; }
	[InLua("entity_name")]
    public EntityID EntityName { get; set; }
	[InLua("offset_deviation")]
    public BoundingBox? OffsetDeviation { get; set; }
	[InLua("offsets")]
    public OneOf<Vector, Vector[]>? Offsets { get; set; }
	[InLua("show_in_tooltip")]
    public bool? ShowInTooltip { get; set; }
	[InLua("tile_collision_mask")]
    public CollisionMask? TileCollisionMask { get; set; }
	[InLua("trigger_created_entity")]
    public bool? TriggerCreatedEntity { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-entity";

    
    
    
    

    

    
}