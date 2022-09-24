namespace Nofus.CodeSamples.Effects
{
    using System;
    using Battles.Entities;
    using UnityEngine;

    [Serializable]
    public class EffectContainer : IEffectContainer
    {
        [SerializeField] private EffectConfig effectConfig;
        [SerializeReference] private IEffectData effectData;

        private IEffect Effect => effectConfig;
        
        public bool Invoke(IEntityState targetState)
        {
            return Effect.Invoke(targetState, effectData);
        }

        public string GetDescription()
        {
            return Effect.GetDescription(effectData);
        }
    }
}
