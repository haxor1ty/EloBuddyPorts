using EloBuddy;

namespace NabbActivator
{
    using System.Linq;
    using LeagueSharp.SDK;

    /// <summary>
    ///     The spellslots.
    /// </summary>
    internal class SpellSlots
    {
        #region Public Properties

        /// <summary>
        ///     Gets the Barrier SpellSlot.
        /// </summary>
        public static SpellSlot Barrier => ObjectManager.Player.GetSpellSlot("SummonerBarrier");

        /// <summary>
        ///     Gets the Clarity SpellSlot.
        /// </summary>
        public static SpellSlot Clarity => ObjectManager.Player.GetSpellSlot("SummonerMana");

        /// <summary>
        ///     Gets the Cleanse SpellSlot.
        /// </summary>
        public static SpellSlot Cleanse => ObjectManager.Player.GetSpellSlot("SummonerBoost");

        /// <summary>
        ///     Gets the Exhaust SpellSlot.
        /// </summary>
        public static SpellSlot Exhaust => ObjectManager.Player.GetSpellSlot("SummonerExhaust");

        /// <summary>
        ///     Gets the Heal SpellSlot.
        /// </summary>
        public static SpellSlot Heal => ObjectManager.Player.GetSpellSlot("SummonerHeal");

        /// <summary>
        ///     Gets the Ignite SpellSlot.
        /// </summary>
        public static SpellSlot Ignite => ObjectManager.Player.GetSpellSlot("SummonerDot");

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Gets the Barrier SpellSlot.
        /// </summary>
        public static SpellSlot GetSmiteSlot()
        {
            foreach (var spell in ObjectManager.Player.Spellbook.Spells.Where(s => s.Name.ToLower().Contains("smite")))
            {
                return spell.Slot;
            }

            return SpellSlot.Unknown;
        }

        #endregion
    }
}