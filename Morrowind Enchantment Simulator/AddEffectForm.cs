using System;
using System.Windows.Forms;

namespace Morrowind_Enchantment_Simulator
{
    public partial class AddEffectForm : Form
    {
        private Effects Effects { get; }

        public AddEffectForm(Effects effects)
        {
            InitializeComponent();
            Effects = effects;
        }

        private void AddEffectForm_Load(object sender, EventArgs e)
        {
            effectsGridView.AutoGenerateColumns = true;
            castStyleBox.SelectedIndex = 0;
            RefreshGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string comboErrorText = "Constant effect spell effects cannot be combined with On Target or On Touch/Self spell effects";

            //Can't add non-constant to constant
            if (Effects.IsConstant && !castStyleBox.Text.Equals("Constant Effect"))
            {
                MessageBox.Show(comboErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Can't add constant to non-constant
            if (!Effects.IsConstant && castStyleBox.Text.Equals("Constant Effect") && Effects.Enchants.Count > 0)
            {
                MessageBox.Show(comboErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Effects.Enchants.Add(new Effect
            {
                CastStyle = castStyleBox.Text,
                BaseCost = Convert.ToSingle(baseCostBox.Text),
                MinMagnitude = Convert.ToSingle(minMagBox.Text),
                MaxMagnitude = Convert.ToSingle(maxMagBox.Text),
                Duration = Convert.ToSingle(durationBox.Text),
                AreaOfEffect = Convert.ToSingle(aoeBox.Text)
            });

            if (castStyleBox.Text.Equals("Constant Effect") && !Effects.IsConstant)
            {
                Effects.IsConstant = true;
            }
            RefreshGrid();
        }

        /// <summary>
        /// Refreshes the data grid with the latest Enchant values
        /// </summary>
        private void RefreshGrid()
        {
            var source = new BindingSource {DataSource = Effects.Enchants};
            effectsGridView.DataSource = source;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateFloat_KeyPress(sender, e);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidator.ValidateFloat_KeyUp(sender, e);
        }

        private void effectsGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Turns off IsConstant if no effects are left
            if (Effects.Enchants.Count == 0 && Effects.IsConstant)
            {
                Effects.IsConstant = false;
            }
        }
    }
}
