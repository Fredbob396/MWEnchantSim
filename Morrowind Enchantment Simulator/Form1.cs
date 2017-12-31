﻿using System;
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
        private EnchantSim _sim = new EnchantSim();
        private bool _firstLoad = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultFormValues();
            _firstLoad = false;
        }

        private void SetDefaultFormValues()
        {
            //Character
            enchantBox.Text = _sim.CharacterInfo.EnchantSkill.ToString("");
            intelligenceBox.Text = _sim.CharacterInfo.Intelligence.ToString("");
            luckBox.Text = _sim.CharacterInfo.Luck.ToString("");

            //Item
            typeBox.SelectedIndex = 0;
            baseCostBox.Text = _sim.ItemInfo.BaseCost.ToString("");
            minMagBox.Text = _sim.ItemInfo.MinMagnitude.ToString("");
            maxMagBox.Text = _sim.ItemInfo.MaxMagnitude.ToString("");
            durationBox.Text = _sim.ItemInfo.Duration.ToString("");
            aoeBox.Text = _sim.ItemInfo.AreaOfEffect.ToString("");

            //Morrowind
            enchantmentChanceMultBox.Text = _sim.MWVars.EnchantmentChanceMult.ToString("");
            enchantmentConstantChanceMultBox.Text = _sim.MWVars.EnchantmentConstantChanceMult.ToString("");
            enchantmentConstantDurationMultBox.Text = _sim.MWVars.EnchantmentConstantDurationMult.ToString("");
            enchantmentMultBox.Text = _sim.MWVars.EnchantmentMult.ToString("");
            enchantmentValueMultBox.Text = _sim.MWVars.EnchantmentValueMult.ToString("");
            effectCostMultBox.Text = _sim.MWVars.EffectCostMult.ToString("");
        }

        /// <summary>
        /// Updates the form elements with values from the simulator
        /// </summary>
        private void UpdateFormElements()
        {
            //TODO
        }

        private void UpdateSim()
        {
            //TODO
            //_sim.CharacterInfo.EnchantSkill = Convert.ToSingle(enchantBox.Text);
        }

        private void inputBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Don't update sim if last key pressed is a period or backspace
            if (!e.KeyCode.Equals(Keys.OemPeriod) && !e.KeyCode.Equals(Keys.Back))
            {
                UpdateSim();
            }
        }

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
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetDefaultFormValues();
        }
    }
}
