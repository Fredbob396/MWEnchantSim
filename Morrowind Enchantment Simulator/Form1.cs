using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Morrowind_Enchantment_Simulator
{
    public partial class Form1 : Form
    {
        private EnchantSim _sim;
        private bool _firstLoad = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
            _firstLoad = false;
        }

        private void SetDefaultValues()
        {
            _sim = new EnchantSim();

            // Character
            enchantBox.Text = _sim.CharacterInfo.EnchantSkill.ToString("");
            intelligenceBox.Text = _sim.CharacterInfo.Intelligence.ToString("");
            luckBox.Text = _sim.CharacterInfo.Luck.ToString("");

            // Item
            typeBox.SelectedIndex = 0;
            baseCostBox.Text = _sim.ItemInfo.BaseCost.ToString("");
            minMagBox.Text = _sim.ItemInfo.MinMagnitude.ToString("");
            maxMagBox.Text = _sim.ItemInfo.MaxMagnitude.ToString("");
            durationBox.Text = _sim.ItemInfo.Duration.ToString("");
            aoeBox.Text = _sim.ItemInfo.AreaOfEffect.ToString("");

            // Morrowind
            enchantmentChanceMultBox.Text = _sim.MWVars.EnchantmentChanceMult.ToString("");
            enchantmentConstantChanceMultBox.Text = _sim.MWVars.EnchantmentConstantChanceMult.ToString("");
            enchantmentConstantDurationMultBox.Text = _sim.MWVars.EnchantmentConstantDurationMult.ToString("");
            enchantmentMultBox.Text = _sim.MWVars.EnchantmentMult.ToString("");
            enchantmentValueMultBox.Text = _sim.MWVars.EnchantmentValueMult.ToString("");
            effectCostMultBox.Text = _sim.MWVars.EffectCostMult.ToString("");

            // Results
            enchantmentPointsBox.Text = "";
            castCostBox.Text = "";
            craftChanceBox.Text = "";
            maxEnchantBox.Text = "";
        }

        /// <summary>
        /// Updates the form elements with values from the simulator
        /// </summary>
        private void UpdateFormElements()
        {
            enchantmentPointsBox.Text = _sim.GetEnchantPoints().ToString("");
            castCostBox.Text = _sim.GetCastCost().ToString("");
            craftChanceBox.Text = _sim.GetEnchantChance().ToString("");
            maxEnchantBox.Text = _sim.GetMaxEnchantValue().ToString("");
        }

        /// <summary>
        /// Updates values in the sim from the form
        /// </summary>
        private void UpdateSim()
        {
            // Character
            _sim.CharacterInfo.EnchantSkill = Convert.ToSingle(enchantBox.Text);
            _sim.CharacterInfo.Intelligence = Convert.ToSingle(intelligenceBox.Text);
            _sim.CharacterInfo.Luck = Convert.ToSingle(luckBox.Text);

            // Item
            _sim.ItemInfo.Type = typeBox.Text;
            _sim.ItemInfo.BaseCost = Convert.ToSingle(baseCostBox.Text);
            _sim.ItemInfo.MinMagnitude = Convert.ToSingle(minMagBox.Text);
            _sim.ItemInfo.MaxMagnitude = Convert.ToSingle(maxMagBox.Text);
            _sim.ItemInfo.Duration = Convert.ToSingle(durationBox.Text);
            _sim.ItemInfo.AreaOfEffect = Convert.ToSingle(aoeBox.Text);

            // Morrowind
            _sim.MWVars.EnchantmentChanceMult = Convert.ToSingle(enchantmentChanceMultBox.Text);
            _sim.MWVars.EnchantmentConstantChanceMult = Convert.ToSingle(enchantmentConstantChanceMultBox.Text);
            _sim.MWVars.EnchantmentConstantDurationMult = Convert.ToSingle(enchantmentConstantDurationMultBox.Text);
            _sim.MWVars.EnchantmentMult = Convert.ToSingle(enchantmentChanceMultBox.Text);
            _sim.MWVars.EnchantmentValueMult = Convert.ToSingle(enchantmentValueMultBox.Text);
            _sim.MWVars.EffectCostMult = Convert.ToSingle(effectCostMultBox.Text);
        }

        private void inputBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Check for if changes whole box with highlight
            TextBox textBox = (TextBox) sender;
            if (textBox.Text.Equals("") || textBox.Text.Equals("."))
            {
                textBox.Text = "0";
            }

            // Don't update sim if last key pressed is a period or decimal
            if (!e.KeyCode.Equals(Keys.OemPeriod) && !e.KeyCode.Equals(Keys.Decimal))
            {
                UpdateSim();
                UpdateFormElements();
            }
        }

        /// <summary>
        /// Validates textbox keypresses to only allow values that are valid floats
        /// </summary>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool hasDecimal = textBox.Text.Contains('.');
            bool backspace = e.KeyChar.Equals('\b');

            //Suppress anything other than numbers, decimals, and the backspace key
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^.]") && !backspace)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                return;
            }

            //Suppress extra decimals
            if (hasDecimal && e.KeyChar.Equals('.'))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                return;
            }

            //Special cases for single-character boxes
            if (textBox.Text.Length == 1)
            {
                // Replace only character with 0 if backspace
                if (backspace)
                {
                    textBox.Text = "0";
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                    return;
                }
                // Replace last character with typed character if not a decimal
                if (textBox.Text.Equals("0") && !e.KeyChar.Equals('.'))
                {
                    textBox.Text = e.KeyChar.ToString();
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                }
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_firstLoad)
            {
                UpdateSim();
                UpdateFormElements();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }
    }
}
