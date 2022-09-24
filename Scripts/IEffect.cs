namespace Nofus.CodeSamples.Effects
{
    using Battles.Entities;

    public interface IEffectData
    {
    }
    
    public interface IEffect
    {
        bool Invoke(IEntityState targetState, IEffectData effectData);

        string GetDescription(IEffectData effectData);
    }
}
