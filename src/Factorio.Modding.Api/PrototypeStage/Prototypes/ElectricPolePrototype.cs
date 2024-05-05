using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ElectricPolePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElectricPolePrototype : EntityWithOwnerPrototype
{
    [InLua("active_picture")]
    public Sprite? ActivePicture { get; set; }
	[InLua("connection_points")]
    public WireConnectionPoint[] ConnectionPoints { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("maximum_wire_distance")]
    public double? MaximumWireDistance { get; set; }
	[InLua("pictures")]
    public RotatedSprite Pictures { get; set; }
	[InLua("radius_visualisation_picture")]
    public Sprite? RadiusVisualisationPicture { get; set; }
	[InLua("supply_area_distance")]
    public double SupplyAreaDistance { get; set; }
	[InLua("track_coverage_during_build_by_moving")]
    public bool? TrackCoverageDuringBuildByMoving { get; set; }

    
    
    
    

    

    
}