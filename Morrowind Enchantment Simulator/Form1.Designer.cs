namespace Morrowind_Enchantment_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enchantBox = new System.Windows.Forms.TextBox();
            this.intelligenceBox = new System.Windows.Forms.TextBox();
            this.luckBox = new System.Windows.Forms.TextBox();
            this.baseCostBox = new System.Windows.Forms.TextBox();
            this.enchantLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.baseCostLabel = new System.Windows.Forms.Label();
            this.minMagLabel = new System.Windows.Forms.Label();
            this.minMagBox = new System.Windows.Forms.TextBox();
            this.maxMagLabel = new System.Windows.Forms.Label();
            this.maxMagBox = new System.Windows.Forms.TextBox();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.aoeBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.aoeLabel = new System.Windows.Forms.Label();
            this.enchantmentChanceMultBox = new System.Windows.Forms.TextBox();
            this.enChMultLabel = new System.Windows.Forms.Label();
            this.enchantmentConstantChanceMultBox = new System.Windows.Forms.TextBox();
            this.enchantmentConstantDurationMultBox = new System.Windows.Forms.TextBox();
            this.enchantmentMultBox = new System.Windows.Forms.TextBox();
            this.enchantmentValueMultBox = new System.Windows.Forms.TextBox();
            this.enConChMultLabel = new System.Windows.Forms.Label();
            this.enConDurMultLabel = new System.Windows.Forms.Label();
            this.enMultLabel = new System.Windows.Forms.Label();
            this.enValMultLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.morrowindLabel = new System.Windows.Forms.Label();
            this.efCosMultLabel = new System.Windows.Forms.Label();
            this.effectCostMultBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enchantBox
            // 
            this.enchantBox.Location = new System.Drawing.Point(12, 46);
            this.enchantBox.Name = "enchantBox";
            this.enchantBox.Size = new System.Drawing.Size(100, 20);
            this.enchantBox.TabIndex = 0;
            this.enchantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(12, 85);
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(100, 20);
            this.intelligenceBox.TabIndex = 1;
            this.intelligenceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.intelligenceBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // luckBox
            // 
            this.luckBox.Location = new System.Drawing.Point(12, 124);
            this.luckBox.Name = "luckBox";
            this.luckBox.Size = new System.Drawing.Size(100, 20);
            this.luckBox.TabIndex = 2;
            this.luckBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.luckBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // baseCostBox
            // 
            this.baseCostBox.Location = new System.Drawing.Point(118, 85);
            this.baseCostBox.Name = "baseCostBox";
            this.baseCostBox.Size = new System.Drawing.Size(100, 20);
            this.baseCostBox.TabIndex = 4;
            this.baseCostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.baseCostBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enchantLabel
            // 
            this.enchantLabel.AutoSize = true;
            this.enchantLabel.Location = new System.Drawing.Point(12, 30);
            this.enchantLabel.Name = "enchantLabel";
            this.enchantLabel.Size = new System.Drawing.Size(47, 13);
            this.enchantLabel.TabIndex = 5;
            this.enchantLabel.Text = "Enchant";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(12, 69);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.intelligenceLabel.TabIndex = 6;
            this.intelligenceLabel.Text = "Intelligence";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(12, 108);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(31, 13);
            this.luckLabel.TabIndex = 7;
            this.luckLabel.Text = "Luck";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(118, 30);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type";
            // 
            // baseCostLabel
            // 
            this.baseCostLabel.AutoSize = true;
            this.baseCostLabel.Location = new System.Drawing.Point(118, 69);
            this.baseCostLabel.Name = "baseCostLabel";
            this.baseCostLabel.Size = new System.Drawing.Size(55, 13);
            this.baseCostLabel.TabIndex = 9;
            this.baseCostLabel.Text = "Base Cost";
            // 
            // minMagLabel
            // 
            this.minMagLabel.AutoSize = true;
            this.minMagLabel.Location = new System.Drawing.Point(118, 108);
            this.minMagLabel.Name = "minMagLabel";
            this.minMagLabel.Size = new System.Drawing.Size(80, 13);
            this.minMagLabel.TabIndex = 10;
            this.minMagLabel.Text = "Min. Magnitude";
            // 
            // minMagBox
            // 
            this.minMagBox.Location = new System.Drawing.Point(118, 124);
            this.minMagBox.Name = "minMagBox";
            this.minMagBox.Size = new System.Drawing.Size(100, 20);
            this.minMagBox.TabIndex = 5;
            this.minMagBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.minMagBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // maxMagLabel
            // 
            this.maxMagLabel.AutoSize = true;
            this.maxMagLabel.Location = new System.Drawing.Point(118, 147);
            this.maxMagLabel.Name = "maxMagLabel";
            this.maxMagLabel.Size = new System.Drawing.Size(83, 13);
            this.maxMagLabel.TabIndex = 12;
            this.maxMagLabel.Text = "Max. Magnitude";
            // 
            // maxMagBox
            // 
            this.maxMagBox.Location = new System.Drawing.Point(118, 163);
            this.maxMagBox.Name = "maxMagBox";
            this.maxMagBox.Size = new System.Drawing.Size(100, 20);
            this.maxMagBox.TabIndex = 6;
            this.maxMagBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.maxMagBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(118, 202);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(100, 20);
            this.durationBox.TabIndex = 7;
            this.durationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.durationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // aoeBox
            // 
            this.aoeBox.Location = new System.Drawing.Point(118, 241);
            this.aoeBox.Name = "aoeBox";
            this.aoeBox.Size = new System.Drawing.Size(100, 20);
            this.aoeBox.TabIndex = 8;
            this.aoeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.aoeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(118, 186);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 16;
            this.durationLabel.Text = "Duration";
            // 
            // aoeLabel
            // 
            this.aoeLabel.AutoSize = true;
            this.aoeLabel.Location = new System.Drawing.Point(118, 225);
            this.aoeLabel.Name = "aoeLabel";
            this.aoeLabel.Size = new System.Drawing.Size(29, 13);
            this.aoeLabel.TabIndex = 17;
            this.aoeLabel.Text = "AOE";
            // 
            // enchantmentChanceMultBox
            // 
            this.enchantmentChanceMultBox.Location = new System.Drawing.Point(224, 46);
            this.enchantmentChanceMultBox.Name = "enchantmentChanceMultBox";
            this.enchantmentChanceMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentChanceMultBox.TabIndex = 9;
            this.enchantmentChanceMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentChanceMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enChMultLabel
            // 
            this.enChMultLabel.AutoSize = true;
            this.enChMultLabel.Location = new System.Drawing.Point(224, 30);
            this.enChMultLabel.Name = "enChMultLabel";
            this.enChMultLabel.Size = new System.Drawing.Size(130, 13);
            this.enChMultLabel.TabIndex = 19;
            this.enChMultLabel.Text = "fEnchantmentChanceMult";
            // 
            // enchantmentConstantChanceMultBox
            // 
            this.enchantmentConstantChanceMultBox.Location = new System.Drawing.Point(224, 85);
            this.enchantmentConstantChanceMultBox.Name = "enchantmentConstantChanceMultBox";
            this.enchantmentConstantChanceMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentConstantChanceMultBox.TabIndex = 10;
            this.enchantmentConstantChanceMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentConstantChanceMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enchantmentConstantDurationMultBox
            // 
            this.enchantmentConstantDurationMultBox.Location = new System.Drawing.Point(224, 124);
            this.enchantmentConstantDurationMultBox.Name = "enchantmentConstantDurationMultBox";
            this.enchantmentConstantDurationMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentConstantDurationMultBox.TabIndex = 11;
            this.enchantmentConstantDurationMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentConstantDurationMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enchantmentMultBox
            // 
            this.enchantmentMultBox.Location = new System.Drawing.Point(224, 163);
            this.enchantmentMultBox.Name = "enchantmentMultBox";
            this.enchantmentMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentMultBox.TabIndex = 12;
            this.enchantmentMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enchantmentValueMultBox
            // 
            this.enchantmentValueMultBox.Location = new System.Drawing.Point(224, 202);
            this.enchantmentValueMultBox.Name = "enchantmentValueMultBox";
            this.enchantmentValueMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentValueMultBox.TabIndex = 13;
            this.enchantmentValueMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentValueMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // enConChMultLabel
            // 
            this.enConChMultLabel.AutoSize = true;
            this.enConChMultLabel.Location = new System.Drawing.Point(224, 69);
            this.enConChMultLabel.Name = "enConChMultLabel";
            this.enConChMultLabel.Size = new System.Drawing.Size(172, 13);
            this.enConChMultLabel.TabIndex = 24;
            this.enConChMultLabel.Text = "fEnchantmentConstantChanceMult";
            // 
            // enConDurMultLabel
            // 
            this.enConDurMultLabel.AutoSize = true;
            this.enConDurMultLabel.Location = new System.Drawing.Point(224, 108);
            this.enConDurMultLabel.Name = "enConDurMultLabel";
            this.enConDurMultLabel.Size = new System.Drawing.Size(175, 13);
            this.enConDurMultLabel.TabIndex = 25;
            this.enConDurMultLabel.Text = "fEnchantmentConstantDurationMult";
            // 
            // enMultLabel
            // 
            this.enMultLabel.AutoSize = true;
            this.enMultLabel.Location = new System.Drawing.Point(224, 147);
            this.enMultLabel.Name = "enMultLabel";
            this.enMultLabel.Size = new System.Drawing.Size(93, 13);
            this.enMultLabel.TabIndex = 26;
            this.enMultLabel.Text = "fEnchantmentMult";
            // 
            // enValMultLabel
            // 
            this.enValMultLabel.AutoSize = true;
            this.enValMultLabel.Location = new System.Drawing.Point(224, 186);
            this.enValMultLabel.Name = "enValMultLabel";
            this.enValMultLabel.Size = new System.Drawing.Size(120, 13);
            this.enValMultLabel.TabIndex = 27;
            this.enValMultLabel.Text = "fEnchantmentValueMult";
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(9, 9);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(62, 13);
            this.characterLabel.TabIndex = 28;
            this.characterLabel.Text = "Character";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(115, 9);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(31, 13);
            this.itemLabel.TabIndex = 29;
            this.itemLabel.Text = "Item";
            // 
            // morrowindLabel
            // 
            this.morrowindLabel.AutoSize = true;
            this.morrowindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morrowindLabel.Location = new System.Drawing.Point(221, 9);
            this.morrowindLabel.Name = "morrowindLabel";
            this.morrowindLabel.Size = new System.Drawing.Size(65, 13);
            this.morrowindLabel.TabIndex = 30;
            this.morrowindLabel.Text = "Morrowind";
            // 
            // efCosMultLabel
            // 
            this.efCosMultLabel.AutoSize = true;
            this.efCosMultLabel.Location = new System.Drawing.Point(224, 225);
            this.efCosMultLabel.Name = "efCosMultLabel";
            this.efCosMultLabel.Size = new System.Drawing.Size(79, 13);
            this.efCosMultLabel.TabIndex = 31;
            this.efCosMultLabel.Text = "fEffectCostMult";
            // 
            // effectCostMultBox
            // 
            this.effectCostMultBox.Location = new System.Drawing.Point(224, 241);
            this.effectCostMultBox.Name = "effectCostMultBox";
            this.effectCostMultBox.Size = new System.Drawing.Size(172, 20);
            this.effectCostMultBox.TabIndex = 14;
            this.effectCostMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.effectCostMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "On Target",
            "On Touch",
            "Constant Effect"});
            this.typeBox.Location = new System.Drawing.Point(118, 45);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(321, 267);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 32;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 505);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.effectCostMultBox);
            this.Controls.Add(this.efCosMultLabel);
            this.Controls.Add(this.morrowindLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.enValMultLabel);
            this.Controls.Add(this.enMultLabel);
            this.Controls.Add(this.enConDurMultLabel);
            this.Controls.Add(this.enConChMultLabel);
            this.Controls.Add(this.enchantmentValueMultBox);
            this.Controls.Add(this.enchantmentMultBox);
            this.Controls.Add(this.enchantmentConstantDurationMultBox);
            this.Controls.Add(this.enchantmentConstantChanceMultBox);
            this.Controls.Add(this.enChMultLabel);
            this.Controls.Add(this.enchantmentChanceMultBox);
            this.Controls.Add(this.aoeLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.aoeBox);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.maxMagBox);
            this.Controls.Add(this.maxMagLabel);
            this.Controls.Add(this.minMagBox);
            this.Controls.Add(this.minMagLabel);
            this.Controls.Add(this.baseCostLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.luckLabel);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.enchantLabel);
            this.Controls.Add(this.baseCostBox);
            this.Controls.Add(this.luckBox);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.enchantBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Morrowind Enchantment Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enchantBox;
        private System.Windows.Forms.TextBox intelligenceBox;
        private System.Windows.Forms.TextBox luckBox;
        private System.Windows.Forms.TextBox baseCostBox;
        private System.Windows.Forms.Label enchantLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label baseCostLabel;
        private System.Windows.Forms.Label minMagLabel;
        private System.Windows.Forms.TextBox minMagBox;
        private System.Windows.Forms.Label maxMagLabel;
        private System.Windows.Forms.TextBox maxMagBox;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.TextBox aoeBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label aoeLabel;
        private System.Windows.Forms.TextBox enchantmentChanceMultBox;
        private System.Windows.Forms.Label enChMultLabel;
        private System.Windows.Forms.TextBox enchantmentConstantChanceMultBox;
        private System.Windows.Forms.TextBox enchantmentConstantDurationMultBox;
        private System.Windows.Forms.TextBox enchantmentMultBox;
        private System.Windows.Forms.TextBox enchantmentValueMultBox;
        private System.Windows.Forms.Label enConChMultLabel;
        private System.Windows.Forms.Label enConDurMultLabel;
        private System.Windows.Forms.Label enMultLabel;
        private System.Windows.Forms.Label enValMultLabel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label morrowindLabel;
        private System.Windows.Forms.Label efCosMultLabel;
        private System.Windows.Forms.TextBox effectCostMultBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button resetButton;
    }
}

