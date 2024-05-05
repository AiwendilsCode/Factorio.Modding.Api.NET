using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("MiningDrillPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MiningDrillPrototype : EntityWithOwnerPrototype
{
    [InLua("allowed_effects")]
    public EffectTypeLimitation? AllowedEffects { get; set; }
	[InLua("animations")]
    public Animation4Way? Animations { get; set; }
	[InLua("base_picture")]
    public Sprite4Way? BasePicture { get; set; }
	[InLua("base_productivity")]
    public float? BaseProductivity { get; set; }
	[InLua("base_render_layer")]
    public RenderLayer? BaseRenderLayer { get; set; }
	[InLua("circuit_connector_sprites")]
    public (CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites, CircuitConnectorSprites)? CircuitConnectorSprites { get; set; }
	[InLua("circuit_wire_connection_points")]
    public (WireConnectionPoint, WireConnectionPoint, WireConnectionPoint, WireConnectionPoint)? CircuitWireConnectionPoints { get; set; }
	[InLua("circuit_wire_max_distance")]
    public double? CircuitWireMaxDistance { get; set; }
	[InLua("draw_circuit_wires")]
    public bool? DrawCircuitWires { get; set; }
	[InLua("draw_copper_wires")]
    public bool? DrawCopperWires { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("graphics_set")]
    public MiningDrillGraphicsSet? GraphicsSet { get; set; }
	[InLua("input_fluid_box")]
    public FluidBox? InputFluidBox { get; set; }
	[InLua("mining_speed")]
    public double MiningSpeed { get; set; }
	[InLua("module_specification")]
    public ModuleSpecification? ModuleSpecification { get; set; }
	[InLua("monitor_visualization_tint")]
    public Color? MonitorVisualizationTint { get; set; }
	[InLua("output_fluid_box")]
    public FluidBox? OutputFluidBox { get; set; }
	[InLua("radius_visualisation_picture")]
    public Sprite? RadiusVisualisationPicture { get; set; }
	[InLua("resource_categories")]
    public ResourceCategoryID[] ResourceCategories { get; set; }
	[InLua("resource_searching_radius")]
    public double ResourceSearchingRadius { get; set; }
	[InLua("vector_to_place_result")]
    public Vector VectorToPlaceResult { get; set; }
	[InLua("wet_mining_graphics_set")]
    public MiningDrillGraphicsSet? WetMiningGraphicsSet { get; set; }

    
    
    
    

    

    
}