namespace Nofus.CodeSamples.Effects
{
    using System;
    using Battles.Entities;
    using UnityEngine;

    public abstract class EffectConfig : ScriptableObject, IEffect
    {
        public abstract Type DataType { get; }
        
        public abstract bool Invoke(IEntityState targetState, IEffectData effectData);

        public abstract string GetDescription(IEffectData effectData);
    }

    public abstract class EffectConfig<T> : EffectConfig
        where T : IEffectData
    {
        public override Type DataType => typeof(T);

        public sealed override bool Invoke(IEntityState targetState, IEffectData effectData)
        {
            T data = GetCastedEffectData(effectData);
            return Invoke(targetState, data);
        }

        protected abstract bool Invoke(IEntityState targetState, T data);

        public sealed override string GetDescription(IEffectData effectData)
        {
            T data = GetCastedEffectData(effectData);
            return GetDescription(data);
        }

        protected abstract string GetDescription(T data);

        private T GetCastedEffectData(IEffectData effectData)
        {
            T data = (T) effectData;
            Debug.Assert(data != null);
            
            return data;
        }
    }
}
