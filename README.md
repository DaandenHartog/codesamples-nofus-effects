# Code sample of effects
This is a stripped down sample of how I handle effects in a turn based game I'm working on. An [IEffect](https://github.com/daandenhartog/codesamples-nofus-effects/blob/main/Scripts/IEffect.cs) alters an entity state based on the provided IEffectData. Since this uses the SOLID design pattern the actual implemenation is done using an [EffectConfig](https://github.com/daandenhartog/codesamples-nofus-effects/blob/main/Scripts/EffectConfig.cs), of which [DamageEffectConfig](https://github.com/daandenhartog/codesamples-nofus-effects/blob/main/Scripts/DamageEffectConfig.cs) is a great example. Spells, glyphs, statuses and traps can all implement [EffectContainers](https://github.com/daandenhartog/codesamples-nofus-effects/blob/main/Scripts/EffectContainer.cs), which allow easy configuration of the effect & its data.

&nbsp;
&nbsp;

<p align="center">
  <img src=/Images/result.gif>
</p>

<p align="center">
	The actual system in my project.
</p>
