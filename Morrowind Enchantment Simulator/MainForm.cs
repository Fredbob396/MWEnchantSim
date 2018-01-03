using System;
using System.Windows.Forms;

namespace Morrowind_Enchantment_Simulator
{
    public partial class MainForm : Form
    {
        private EnchantSim _sim;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        /// <summary>
        /// Resets all values to default and removes all spell effects
        /// </summary>
        private void SetDefaultValues()
        {
            //Spell effects
            _sim = new EnchantSim();

            // Character
            enchantBox.Text = _sim.Character.EnchantSkill.ToString("");
            intelligenceBox.Text = _sim.Character.Intelligence.ToString("");
            luckBox.Text = _sim.Character.Luck.ToString("");

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
            _sim.Character.EnchantSkill = Convert.ToSingle(enchantBox.Text);
            _sim.Character.Intelligence = Convert.ToSingle(intelligenceBox.Text);
            _sim.Character.Luck = Convert.ToSingle(luckBox.Text);

            // Morrowind
            _sim.MWVars.EnchantmentChanceMult = Convert.ToSingle(enchantmentChanceMultBox.Text);
            _sim.MWVars.EnchantmentConstantChanceMult = Convert.ToSingle(enchantmentConstantChanceMultBox.Text);
            _sim.MWVars.EnchantmentConstantDurationMult = Convert.ToSingle(enchantmentConstantDurationMultBox.Text);
            _sim.MWVars.EnchantmentMult = Convert.ToSingle(enchantmentChanceMultBox.Text);
            _sim.MWVars.EnchantmentValueMult = Convert.ToSingle(enchantmentValueMultBox.Text);
            _sim.MWVars.EffectCostMult = Convert.ToSingle(effectCostMultBox.Text);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidator.ValidateFloat_KeyUp(sender, e);

            // Prevents crash during auto-refresh
            if (!e.KeyCode.Equals(Keys.OemPeriod) && !e.KeyCode.Equals(Keys.Decimal))
            {
                UpdateSim();
                UpdateFormElements();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateFloat_KeyPress(sender, e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        /// <summary>
        /// Opens the add effects form
        /// </summary>
        private void addEffectsButton_Click(object sender, EventArgs e)
        {
            using (var addEffectForm = new AddEffectForm(_sim.Effects))
            {
                addEffectForm.ShowDialog();
            }
            UpdateFormElements();
        }
    }
}
