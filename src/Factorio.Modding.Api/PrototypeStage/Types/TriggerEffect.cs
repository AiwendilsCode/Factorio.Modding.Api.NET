using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TriggerEffect")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TriggerEffect 
{
    
    public OneOf<OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem>, OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem>[]> Value { get; set; }

    
    
    
    private TriggerEffect(OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem> value)
    {
        Value = value;
    }

	private TriggerEffect(OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem>[] value)
    {
        Value = value;
    }

    public static implicit operator TriggerEffect(OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem> value) => new(value);

	public static implicit operator TriggerEffect(OneOf<DamageTriggerEffectItem, CreateEntityTriggerEffectItem, CreateExplosionTriggerEffectItem, CreateFireTriggerEffectItem, CreateSmokeTriggerEffectItem, CreateTrivialSmokeEffectItem, CreateParticleTriggerEffectItem, CreateStickerTriggerEffectItem, CreateDecorativesTriggerEffectItem, NestedTriggerEffectItem, PlaySoundTriggerEffectItem, PushBackTriggerEffectItem, DestroyCliffsTriggerEffectItem, ShowExplosionOnChartTriggerEffectItem, InsertItemTriggerEffectItem, ScriptTriggerEffectItem, SetTileTriggerEffectItem, InvokeTileEffectTriggerEffectItem, DestroyDecorativesTriggerEffectItem, CameraEffectTriggerEffectItem>[] value) => new(value);

    
}