using System;

namespace Morrowind_Enchantment_Simulator
{
    class EnchantSim
    {
        public Character Character = new Character();
        public Effects Effects = new Effects();
        public MWVars MWVars = new MWVars();

        /*
         * OpenMW Dev Comment:
         * Vanilla enchant cost formula:
         * 
         * Touch/Self:          (min + max) * baseCost * 0.025 * duration + area * baseCost * 0.025
         * Target:       1.5 * ((min + max) * baseCost * 0.025 * duration + area * baseCost * 0.025)
         * Constant eff:        (min + max) * baseCost * 2.5              + area * baseCost * 0.025
         * 
         * For multiple effects - cost of each effect is multiplied by number of effects that follows +1.
         * Note: Minimal value inside formula for 'min' and 'max' is 1. So in vanilla:
         *       (0 + 0) == (1 + 0) == (1 + 1) => 2 or (2 + 0) == (1 + 2) => 3
         *
         * Formula on UESPWiki is not entirely correct.
        */
        /// <summary>
        /// Gets the enchant points
        /// </summary>
        public float GetEnchantPoints()
        {
            float enchantPoints = 0;
            foreach (Effect effect in Effects.Enchants)
            {
                float minMag = Math.Max(1.0f, effect.MinMagnitude);
                float maxMag = Math.Max(1.0f, effect.MaxMagnitude);
                float areaOfEffect = Math.Max(1.0f, effect.AreaOfEffect);

                float magnitudeCost = (minMag + maxMag) * effect.BaseCost * 0.05f;

                magnitudeCost *= Effects.IsConstant
                    ? MWVars.EnchantmentConstantDurationMult
                    : effect.Duration;

                float areaCost = areaOfEffect * 0.05f * effect.BaseCost;
                float effectCost = Math.Max(1f, (magnitudeCost + areaCost) * MWVars.EffectCostMult);

                if (effect.CastStyle.Equals("On Target"))
                {
                    effectCost *= 1.5f;
                }

                // Rounds to a whole number
                enchantPoints += Convert.ToInt32(effectCost);
            }

            return enchantPoints;
        }

        /// <summary>
        /// Gets the enchant price
        /// </summary>
        public float GetEnchantPrice()
        {
            return GetEnchantPoints() * MWVars.EnchantmentValueMult;
        }

        /*
         *  OpenMW Dev Comment:
         *  Each point of enchant skill above/under 10 subtracts/adds
         *  one percent of enchantment cost while minimum is 1.
        */
        /// <summary>
        /// Gets the enchant cast cost
        /// </summary>
        public float GetCastCost()
        {
            // Constant effects have no cast cost
            if (Effects.IsConstant) { return 0.0f; }

            float castCost = GetEnchantPoints();
            return Math.Max(1.0f, castCost - (castCost / 100.0f) * (Character.EnchantSkill - 10.0f));
        }

        /// <summary>
        /// Gets the max enchant value
        /// </summary>
        public float GetMaxEnchantValue()
        {
            // TODO: Verify that this functions the same as the OpenMW function
            return GetEnchantPoints() * MWVars.EnchantmentMult;
        }

        /// <summary>
        /// Gets the chance of a successful enchant
        /// </summary>
        public float GetEnchantChance()
        {
            float chance1 = Character.EnchantSkill + 
                (0.25f * Character.Intelligence) +
                (0.125f * Character.Luck);

            float chance2 = 7.5f / (MWVars.EnchantmentChanceMult);
            chance2 *= Effects.IsConstant
                ? MWVars.EnchantmentConstantChanceMult 
                : 1.0f;

            chance2 *= GetEnchantPoints();

            return (chance1 - chance2);
        }
    }
}
