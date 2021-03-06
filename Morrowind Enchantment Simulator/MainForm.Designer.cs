﻿namespace Morrowind_Enchantment_Simulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.enchantBox = new System.Windows.Forms.TextBox();
            this.intelligenceBox = new System.Windows.Forms.TextBox();
            this.luckBox = new System.Windows.Forms.TextBox();
            this.enchantLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
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
            this.morrowindLabel = new System.Windows.Forms.Label();
            this.efCosMultLabel = new System.Windows.Forms.Label();
            this.effectCostMultBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.verticalDivider = new System.Windows.Forms.Label();
            this.enchantmentPointsLabel = new System.Windows.Forms.Label();
            this.enchantmentPointsBox = new System.Windows.Forms.TextBox();
            this.castCostLabel = new System.Windows.Forms.Label();
            this.castCostBox = new System.Windows.Forms.TextBox();
            this.craftChanceLabel = new System.Windows.Forms.Label();
            this.craftChanceBox = new System.Windows.Forms.TextBox();
            this.maxEnchantLabel = new System.Windows.Forms.Label();
            this.maxEnchantBox = new System.Windows.Forms.TextBox();
            this.addEffectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enchantBox
            // 
            this.enchantBox.Location = new System.Drawing.Point(12, 46);
            this.enchantBox.Name = "enchantBox";
            this.enchantBox.Size = new System.Drawing.Size(100, 20);
            this.enchantBox.TabIndex = 0;
            this.enchantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(12, 85);
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(100, 20);
            this.intelligenceBox.TabIndex = 1;
            this.intelligenceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.intelligenceBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // luckBox
            // 
            this.luckBox.Location = new System.Drawing.Point(12, 124);
            this.luckBox.Name = "luckBox";
            this.luckBox.Size = new System.Drawing.Size(100, 20);
            this.luckBox.TabIndex = 2;
            this.luckBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.luckBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enchantLabel
            // 
            this.enchantLabel.AutoSize = true;
            this.enchantLabel.Location = new System.Drawing.Point(9, 30);
            this.enchantLabel.Name = "enchantLabel";
            this.enchantLabel.Size = new System.Drawing.Size(47, 13);
            this.enchantLabel.TabIndex = 5;
            this.enchantLabel.Text = "Enchant";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(9, 69);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.intelligenceLabel.TabIndex = 6;
            this.intelligenceLabel.Text = "Intelligence";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(9, 108);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(31, 13);
            this.luckLabel.TabIndex = 7;
            this.luckLabel.Text = "Luck";
            // 
            // enchantmentChanceMultBox
            // 
            this.enchantmentChanceMultBox.Location = new System.Drawing.Point(118, 46);
            this.enchantmentChanceMultBox.Name = "enchantmentChanceMultBox";
            this.enchantmentChanceMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentChanceMultBox.TabIndex = 3;
            this.enchantmentChanceMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentChanceMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enChMultLabel
            // 
            this.enChMultLabel.AutoSize = true;
            this.enChMultLabel.Location = new System.Drawing.Point(118, 30);
            this.enChMultLabel.Name = "enChMultLabel";
            this.enChMultLabel.Size = new System.Drawing.Size(130, 13);
            this.enChMultLabel.TabIndex = 19;
            this.enChMultLabel.Text = "fEnchantmentChanceMult";
            // 
            // enchantmentConstantChanceMultBox
            // 
            this.enchantmentConstantChanceMultBox.Location = new System.Drawing.Point(118, 85);
            this.enchantmentConstantChanceMultBox.Name = "enchantmentConstantChanceMultBox";
            this.enchantmentConstantChanceMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentConstantChanceMultBox.TabIndex = 4;
            this.enchantmentConstantChanceMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentConstantChanceMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enchantmentConstantDurationMultBox
            // 
            this.enchantmentConstantDurationMultBox.Location = new System.Drawing.Point(118, 124);
            this.enchantmentConstantDurationMultBox.Name = "enchantmentConstantDurationMultBox";
            this.enchantmentConstantDurationMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentConstantDurationMultBox.TabIndex = 5;
            this.enchantmentConstantDurationMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentConstantDurationMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enchantmentMultBox
            // 
            this.enchantmentMultBox.Location = new System.Drawing.Point(118, 163);
            this.enchantmentMultBox.Name = "enchantmentMultBox";
            this.enchantmentMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentMultBox.TabIndex = 6;
            this.enchantmentMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enchantmentValueMultBox
            // 
            this.enchantmentValueMultBox.Location = new System.Drawing.Point(118, 202);
            this.enchantmentValueMultBox.Name = "enchantmentValueMultBox";
            this.enchantmentValueMultBox.Size = new System.Drawing.Size(172, 20);
            this.enchantmentValueMultBox.TabIndex = 7;
            this.enchantmentValueMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.enchantmentValueMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // enConChMultLabel
            // 
            this.enConChMultLabel.AutoSize = true;
            this.enConChMultLabel.Location = new System.Drawing.Point(118, 69);
            this.enConChMultLabel.Name = "enConChMultLabel";
            this.enConChMultLabel.Size = new System.Drawing.Size(172, 13);
            this.enConChMultLabel.TabIndex = 24;
            this.enConChMultLabel.Text = "fEnchantmentConstantChanceMult";
            // 
            // enConDurMultLabel
            // 
            this.enConDurMultLabel.AutoSize = true;
            this.enConDurMultLabel.Location = new System.Drawing.Point(118, 108);
            this.enConDurMultLabel.Name = "enConDurMultLabel";
            this.enConDurMultLabel.Size = new System.Drawing.Size(175, 13);
            this.enConDurMultLabel.TabIndex = 25;
            this.enConDurMultLabel.Text = "fEnchantmentConstantDurationMult";
            // 
            // enMultLabel
            // 
            this.enMultLabel.AutoSize = true;
            this.enMultLabel.Location = new System.Drawing.Point(118, 147);
            this.enMultLabel.Name = "enMultLabel";
            this.enMultLabel.Size = new System.Drawing.Size(93, 13);
            this.enMultLabel.TabIndex = 26;
            this.enMultLabel.Text = "fEnchantmentMult";
            // 
            // enValMultLabel
            // 
            this.enValMultLabel.AutoSize = true;
            this.enValMultLabel.Location = new System.Drawing.Point(118, 186);
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
            // morrowindLabel
            // 
            this.morrowindLabel.AutoSize = true;
            this.morrowindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morrowindLabel.Location = new System.Drawing.Point(115, 9);
            this.morrowindLabel.Name = "morrowindLabel";
            this.morrowindLabel.Size = new System.Drawing.Size(65, 13);
            this.morrowindLabel.TabIndex = 30;
            this.morrowindLabel.Text = "Morrowind";
            // 
            // efCosMultLabel
            // 
            this.efCosMultLabel.AutoSize = true;
            this.efCosMultLabel.Location = new System.Drawing.Point(118, 225);
            this.efCosMultLabel.Name = "efCosMultLabel";
            this.efCosMultLabel.Size = new System.Drawing.Size(79, 13);
            this.efCosMultLabel.TabIndex = 31;
            this.efCosMultLabel.Text = "fEffectCostMult";
            // 
            // effectCostMultBox
            // 
            this.effectCostMultBox.Location = new System.Drawing.Point(118, 241);
            this.effectCostMultBox.Name = "effectCostMultBox";
            this.effectCostMultBox.Size = new System.Drawing.Size(172, 20);
            this.effectCostMultBox.TabIndex = 8;
            this.effectCostMultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.effectCostMultBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(215, 267);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // verticalDivider
            // 
            this.verticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider.Location = new System.Drawing.Point(306, -34);
            this.verticalDivider.Name = "verticalDivider";
            this.verticalDivider.Size = new System.Drawing.Size(2, 339);
            this.verticalDivider.TabIndex = 2;
            // 
            // enchantmentPointsLabel
            // 
            this.enchantmentPointsLabel.AutoSize = true;
            this.enchantmentPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enchantmentPointsLabel.Location = new System.Drawing.Point(314, 30);
            this.enchantmentPointsLabel.Name = "enchantmentPointsLabel";
            this.enchantmentPointsLabel.Size = new System.Drawing.Size(120, 13);
            this.enchantmentPointsLabel.TabIndex = 33;
            this.enchantmentPointsLabel.Text = "Enchantment Points";
            // 
            // enchantmentPointsBox
            // 
            this.enchantmentPointsBox.Location = new System.Drawing.Point(317, 46);
            this.enchantmentPointsBox.Name = "enchantmentPointsBox";
            this.enchantmentPointsBox.ReadOnly = true;
            this.enchantmentPointsBox.Size = new System.Drawing.Size(120, 20);
            this.enchantmentPointsBox.TabIndex = 34;
            this.enchantmentPointsBox.TabStop = false;
            // 
            // castCostLabel
            // 
            this.castCostLabel.AutoSize = true;
            this.castCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castCostLabel.Location = new System.Drawing.Point(314, 69);
            this.castCostLabel.Name = "castCostLabel";
            this.castCostLabel.Size = new System.Drawing.Size(61, 13);
            this.castCostLabel.TabIndex = 35;
            this.castCostLabel.Text = "Cast Cost";
            // 
            // castCostBox
            // 
            this.castCostBox.Location = new System.Drawing.Point(317, 85);
            this.castCostBox.Name = "castCostBox";
            this.castCostBox.ReadOnly = true;
            this.castCostBox.Size = new System.Drawing.Size(120, 20);
            this.castCostBox.TabIndex = 36;
            this.castCostBox.TabStop = false;
            // 
            // craftChanceLabel
            // 
            this.craftChanceLabel.AutoSize = true;
            this.craftChanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftChanceLabel.Location = new System.Drawing.Point(314, 108);
            this.craftChanceLabel.Name = "craftChanceLabel";
            this.craftChanceLabel.Size = new System.Drawing.Size(81, 13);
            this.craftChanceLabel.TabIndex = 37;
            this.craftChanceLabel.Text = "Craft Chance";
            // 
            // craftChanceBox
            // 
            this.craftChanceBox.Location = new System.Drawing.Point(317, 124);
            this.craftChanceBox.Name = "craftChanceBox";
            this.craftChanceBox.ReadOnly = true;
            this.craftChanceBox.Size = new System.Drawing.Size(120, 20);
            this.craftChanceBox.TabIndex = 38;
            this.craftChanceBox.TabStop = false;
            // 
            // maxEnchantLabel
            // 
            this.maxEnchantLabel.AutoSize = true;
            this.maxEnchantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxEnchantLabel.Location = new System.Drawing.Point(314, 147);
            this.maxEnchantLabel.Name = "maxEnchantLabel";
            this.maxEnchantLabel.Size = new System.Drawing.Size(117, 13);
            this.maxEnchantLabel.TabIndex = 39;
            this.maxEnchantLabel.Text = "Max Enchant Value";
            // 
            // maxEnchantBox
            // 
            this.maxEnchantBox.Location = new System.Drawing.Point(317, 163);
            this.maxEnchantBox.Name = "maxEnchantBox";
            this.maxEnchantBox.ReadOnly = true;
            this.maxEnchantBox.Size = new System.Drawing.Size(117, 20);
            this.maxEnchantBox.TabIndex = 40;
            this.maxEnchantBox.TabStop = false;
            // 
            // addEffectsButton
            // 
            this.addEffectsButton.Location = new System.Drawing.Point(12, 267);
            this.addEffectsButton.Name = "addEffectsButton";
            this.addEffectsButton.Size = new System.Drawing.Size(75, 23);
            this.addEffectsButton.TabIndex = 9;
            this.addEffectsButton.Text = "Add Effects";
            this.addEffectsButton.UseVisualStyleBackColor = true;
            this.addEffectsButton.Click += new System.EventHandler(this.addEffectsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 301);
            this.Controls.Add(this.addEffectsButton);
            this.Controls.Add(this.maxEnchantBox);
            this.Controls.Add(this.maxEnchantLabel);
            this.Controls.Add(this.craftChanceBox);
            this.Controls.Add(this.craftChanceLabel);
            this.Controls.Add(this.castCostBox);
            this.Controls.Add(this.castCostLabel);
            this.Controls.Add(this.enchantmentPointsBox);
            this.Controls.Add(this.enchantmentPointsLabel);
            this.Controls.Add(this.verticalDivider);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.effectCostMultBox);
            this.Controls.Add(this.efCosMultLabel);
            this.Controls.Add(this.morrowindLabel);
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
            this.Controls.Add(this.luckLabel);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.enchantLabel);
            this.Controls.Add(this.luckBox);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.enchantBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morrowind Enchantment Simulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enchantBox;
        private System.Windows.Forms.TextBox intelligenceBox;
        private System.Windows.Forms.TextBox luckBox;
        private System.Windows.Forms.Label enchantLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label luckLabel;
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
        private System.Windows.Forms.Label morrowindLabel;
        private System.Windows.Forms.Label efCosMultLabel;
        private System.Windows.Forms.TextBox effectCostMultBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label verticalDivider;
        private System.Windows.Forms.Label enchantmentPointsLabel;
        private System.Windows.Forms.TextBox enchantmentPointsBox;
        private System.Windows.Forms.Label castCostLabel;
        private System.Windows.Forms.TextBox castCostBox;
        private System.Windows.Forms.Label craftChanceLabel;
        private System.Windows.Forms.TextBox craftChanceBox;
        private System.Windows.Forms.Label maxEnchantLabel;
        private System.Windows.Forms.TextBox maxEnchantBox;
        private System.Windows.Forms.Button addEffectsButton;
    }
}

