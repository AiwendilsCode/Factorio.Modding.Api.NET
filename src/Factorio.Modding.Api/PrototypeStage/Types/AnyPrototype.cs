using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnyPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnyPrototype 
{
    
    public OneOf<PrototypeBase, AmbientSound, AnimationPrototype, EditorControllerPrototype, FontPrototype, GodControllerPrototype, MapGenPresets, MapSettings, MouseCursor, SoundPrototype, SpectatorControllerPrototype, SpritePrototype, TileEffectDefinition, TipsAndTricksItemCategory, TriggerTargetType, WindSound> Value { get; set; }

    
    
    
    private AnyPrototype(PrototypeBase value)
    {
        Value = value;
    }

	private AnyPrototype(AmbientSound value)
    {
        Value = value;
    }

	private AnyPrototype(AnimationPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(EditorControllerPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(FontPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(GodControllerPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(MapGenPresets value)
    {
        Value = value;
    }

	private AnyPrototype(MapSettings value)
    {
        Value = value;
    }

	private AnyPrototype(MouseCursor value)
    {
        Value = value;
    }

	private AnyPrototype(SoundPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(SpectatorControllerPrototype value)
    {
        Value = value;
    }

	private AnyPrototype(SpritePrototype value)
    {
        Value = value;
    }

	private AnyPrototype(TileEffectDefinition value)
    {
        Value = value;
    }

	private AnyPrototype(TipsAndTricksItemCategory value)
    {
        Value = value;
    }

	private AnyPrototype(TriggerTargetType value)
    {
        Value = value;
    }

	private AnyPrototype(WindSound value)
    {
        Value = value;
    }

    public static implicit operator AnyPrototype(PrototypeBase value) => new(value);

	public static implicit operator AnyPrototype(AmbientSound value) => new(value);

	public static implicit operator AnyPrototype(AnimationPrototype value) => new(value);

	public static implicit operator AnyPrototype(EditorControllerPrototype value) => new(value);

	public static implicit operator AnyPrototype(FontPrototype value) => new(value);

	public static implicit operator AnyPrototype(GodControllerPrototype value) => new(value);

	public static implicit operator AnyPrototype(MapGenPresets value) => new(value);

	public static implicit operator AnyPrototype(MapSettings value) => new(value);

	public static implicit operator AnyPrototype(MouseCursor value) => new(value);

	public static implicit operator AnyPrototype(SoundPrototype value) => new(value);

	public static implicit operator AnyPrototype(SpectatorControllerPrototype value) => new(value);

	public static implicit operator AnyPrototype(SpritePrototype value) => new(value);

	public static implicit operator AnyPrototype(TileEffectDefinition value) => new(value);

	public static implicit operator AnyPrototype(TipsAndTricksItemCategory value) => new(value);

	public static implicit operator AnyPrototype(TriggerTargetType value) => new(value);

	public static implicit operator AnyPrototype(WindSound value) => new(value);

    
}