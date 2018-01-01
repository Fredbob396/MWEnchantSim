using System;

namespace Morrowind_Enchantment_Simulator
{
    class EnchantSim
    {
        // TODO: De-couple these properties from the EnchantSim class
        public CharacterInfo CharacterInfo = new CharacterInfo();
        public ItemInfo ItemInfo = new ItemInfo();
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
            float minMag = Math.Max(1.0f, ItemInfo.MinMagnitude);
            float maxMag = Math.Max(1.0f, ItemInfo.MaxMagnitude);
            float areaOfEffect = Math.Max(1.0f, ItemInfo.AreaOfEffect);

            float magnitudeCost = (minMag + maxMag) * ItemInfo.BaseCost * 0.05f;

            magnitudeCost *= ItemInfo.Type.Equals("Constant Effect")
                ? MWVars.EnchantmentConstantDurationMult
                : ItemInfo.Duration;

            float areaCost = areaOfEffect * 0.05f * ItemInfo.BaseCost;
            float cost = Math.Max(1f, (magnitudeCost + areaCost) * MWVars.EffectCostMult);

            if (ItemInfo.Type.Equals("On Target"))
            {
                cost *= 1.5f;
            }

            return cost;
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
            if (ItemInfo.Type.Equals("Constant Effect")) { return 0.0f; }

            float castCost = GetEnchantPoints();
            return Math.Max(1.0f, castCost - (castCost / 100.0f) * (CharacterInfo.EnchantSkill - 10.0f));
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
            float chance1 = CharacterInfo.EnchantSkill + 
                (0.25f * CharacterInfo.Intelligence) +
                (0.125f * CharacterInfo.Luck);

            float chance2 = 7.5f / (MWVars.EnchantmentChanceMult);
            chance2 *= ItemInfo.Type.Equals("Constant Effect") 
                ? MWVars.EnchantmentConstantChanceMult 
                : 1.0f;

            chance2 *= GetEnchantPoints();

            return (chance1 - chance2);
        }
    }
}
