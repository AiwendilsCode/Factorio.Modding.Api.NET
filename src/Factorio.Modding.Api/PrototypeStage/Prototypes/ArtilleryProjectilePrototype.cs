using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArtilleryProjectilePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArtilleryProjectilePrototype : EntityPrototype
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("chart_picture")]
    public Sprite? ChartPicture { get; set; }
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("final_action")]
    public Trigger? FinalAction { get; set; }
	[InLua("height_from_ground")]
    public float? HeightFromGround { get; set; }
	[InLua("map_color")]
    public Color MapColor { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }
	[InLua("reveal_map")]
    public bool RevealMap { get; set; }
	[InLua("rotatable")]
    public bool? Rotatable { get; set; }
	[InLua("shadow")]
    public Sprite? Shadow { get; set; }

    
    
    
    

    

    
}