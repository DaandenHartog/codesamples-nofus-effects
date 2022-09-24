namespace Nofus.CodeSamples.Effects
{
    using Battles.Entities;

    public interface IEffectContainer
    {
        bool Invoke(IEntityState targetState);

        string GetDescription();
    }
}
