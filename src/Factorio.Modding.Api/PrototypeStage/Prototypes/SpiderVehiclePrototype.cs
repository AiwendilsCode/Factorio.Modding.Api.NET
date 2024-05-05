using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SpiderVehiclePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderVehiclePrototype : VehiclePrototype
{
    [InLua("automatic_weapon_cycling")]
    public bool AutomaticWeaponCycling { get; set; }
	[InLua("chain_shooting_cooldown_modifier")]
    public float ChainShootingCooldownModifier { get; set; }
	[InLua("chunk_exploration_radius")]
    public uint ChunkExplorationRadius { get; set; }
	[InLua("energy_source")]
    public OneOf<BurnerEnergySource, VoidEnergySource> EnergySource { get; set; }
	[InLua("graphics_set")]
    public SpiderVehicleGraphicsSet GraphicsSet { get; set; }
	[InLua("guns")]
    public ItemID[]? Guns { get; set; }
	[InLua("height")]
    public float Height { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("movement_energy_consumption")]
    public Energy MovementEnergyConsumption { get; set; }
	[InLua("spider_engine")]
    public SpiderEnginePrototype SpiderEngine { get; set; }
	[InLua("torso_bob_speed")]
    public float? TorsoBobSpeed { get; set; }
	[InLua("torso_rotation_speed")]
    public float? TorsoRotationSpeed { get; set; }
	[InLua("trash_inventory_size")]
    public ItemStackIndex? TrashInventorySize { get; set; }

    
    
    
    

    

    
}