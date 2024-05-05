using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EntityWithHealthPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityWithHealthPrototype : EntityPrototype
{
    [InLua("alert_when_damaged")]
    public bool? AlertWhenDamaged { get; set; }
	[InLua("attack_reaction")]
    public OneOf<AttackReactionItem, AttackReactionItem[]>? AttackReaction { get; set; }
	[InLua("corpse")]
    public OneOf<EntityID, EntityID[]>? Corpse { get; set; }
	[InLua("create_ghost_on_death")]
    public bool? CreateGhostOnDeath { get; set; }
	[InLua("damaged_trigger_effect")]
    public TriggerEffect? DamagedTriggerEffect { get; set; }
	[InLua("dying_explosion")]
    public OneOf<ExplosionDefinition, ExplosionDefinition[]>? DyingExplosion { get; set; }
	[InLua("dying_trigger_effect")]
    public TriggerEffect? DyingTriggerEffect { get; set; }
	[InLua("healing_per_tick")]
    public float? HealingPerTick { get; set; }
	[InLua("hide_resistances")]
    public bool? HideResistances { get; set; }
	[InLua("integration_patch")]
    public Sprite4Way? IntegrationPatch { get; set; }
	[InLua("integration_patch_render_layer")]
    public RenderLayer? IntegrationPatchRenderLayer { get; set; }
	[InLua("loot")]
    public LootItem[]? Loot { get; set; }
	[InLua("max_health")]
    public float? MaxHealth { get; set; }
	[InLua("random_corpse_variation")]
    public bool? RandomCorpseVariation { get; set; }
	[InLua("repair_sound")]
    public Sound? RepairSound { get; set; }
	[InLua("repair_speed_modifier")]
    public float? RepairSpeedModifier { get; set; }
	[InLua("resistances")]
    public Resistance[]? Resistances { get; set; }

    
    
    
    

    

    
}