using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LoaderPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LoaderPrototype : TransportBeltConnectablePrototype
{
    [InLua("allow_container_interaction")]
    public bool? AllowContainerInteraction { get; set; }
	[InLua("allow_rail_interaction")]
    public bool? AllowRailInteraction { get; set; }
	[InLua("belt_length")]
    public double? BeltLength { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("container_distance")]
    public double? ContainerDistance { get; set; }
	[InLua("energy_per_item")]
    public Energy? EnergyPerItem { get; set; }
	[InLua("energy_source")]
    public OneOf<ElectricEnergySource, HeatEnergySource, FluidEnergySource, VoidEnergySource>? EnergySource { get; set; }
	[InLua("filter_count")]
    public byte FilterCount { get; set; }
	[InLua("structure")]
    public LoaderStructure Structure { get; set; }
	[InLua("structure_render_layer")]
    public RenderLayer? StructureRenderLayer { get; set; }

    
    
    
    

    

    
}