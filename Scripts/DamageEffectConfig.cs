namespace Nofus.CodeSamples.Effects
{
    using System;
    using Battles.Entities;
    using Battles.Stats;
    using UnityEngine;
    using Random = UnityEngine.Random;

    [Serializable]
    public class DamageEffectData : IEffectData
    {
        [SerializeField] private int minDamage;
        [SerializeField] private int maxDamage;

        public int MinDamage => minDamage;
        public int MaxDamage => maxDamage;
    }

    [CreateAssetMenu(fileName = "DamageEffectConfig", menuName = "EnumItems/EffectConfigs/DamageEffectConfig")]
    public class DamageEffectConfig : EffectConfig<DamageEffectData>
    {
        protected override bool Invoke(IEntityState targetState, DamageEffectData data)
        {
            int rolledDamage = Random.Range(data.MinDamage, data.MaxDamage + 1);
            
            targetState[StatConfig.Health].AlterCurrentWith(-rolledDamage);

            return rolledDamage != 0;
        }

        protected override string GetDescription(DamageEffectData data)
        {
            return $"Deal {data.MinDamage} to {data.MaxDamage} damage to target";
        }
    }
}
