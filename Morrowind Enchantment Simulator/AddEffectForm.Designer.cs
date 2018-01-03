namespace Morrowind_Enchantment_Simulator
{
    partial class AddEffectForm
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
            this.baseCostLabel = new System.Windows.Forms.Label();
            this.baseCostBox = new System.Windows.Forms.TextBox();
            this.minMagLabel = new System.Windows.Forms.Label();
            this.minMagBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxMagBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.aoeLabel = new System.Windows.Forms.Label();
            this.aoeBox = new System.Windows.Forms.TextBox();
            this.castStyleBox = new System.Windows.Forms.ComboBox();
            this.castStyleLabel = new System.Windows.Forms.Label();
            this.effectsGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.effectsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseCostLabel
            // 
            this.baseCostLabel.AutoSize = true;
            this.baseCostLabel.Location = new System.Drawing.Point(12, 49);
            this.baseCostLabel.Name = "baseCostLabel";
            this.baseCostLabel.Size = new System.Drawing.Size(55, 13);
            this.baseCostLabel.TabIndex = 0;
            this.baseCostLabel.Text = "Base Cost";
            // 
            // baseCostBox
            // 
            this.baseCostBox.Location = new System.Drawing.Point(12, 65);
            this.baseCostBox.Name = "baseCostBox";
            this.baseCostBox.Size = new System.Drawing.Size(100, 20);
            this.baseCostBox.TabIndex = 1;
            this.baseCostBox.Text = "1";
            this.baseCostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.baseCostBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // minMagLabel
            // 
            this.minMagLabel.AutoSize = true;
            this.minMagLabel.Location = new System.Drawing.Point(12, 88);
            this.minMagLabel.Name = "minMagLabel";
            this.minMagLabel.Size = new System.Drawing.Size(80, 13);
            this.minMagLabel.TabIndex = 2;
            this.minMagLabel.Text = "Min. Magnitude";
            // 
            // minMagBox
            // 
            this.minMagBox.Location = new System.Drawing.Point(12, 104);
            this.minMagBox.Name = "minMagBox";
            this.minMagBox.Size = new System.Drawing.Size(100, 20);
            this.minMagBox.TabIndex = 2;
            this.minMagBox.Text = "1";
            this.minMagBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.minMagBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max. Magnitude";
            // 
            // maxMagBox
            // 
            this.maxMagBox.Location = new System.Drawing.Point(12, 143);
            this.maxMagBox.Name = "maxMagBox";
            this.maxMagBox.Size = new System.Drawing.Size(100, 20);
            this.maxMagBox.TabIndex = 3;
            this.maxMagBox.Text = "1";
            this.maxMagBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.maxMagBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(12, 166);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 6;
            this.durationLabel.Text = "Duration";
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(12, 182);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(100, 20);
            this.durationBox.TabIndex = 4;
            this.durationBox.Text = "1";
            this.durationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.durationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // aoeLabel
            // 
            this.aoeLabel.AutoSize = true;
            this.aoeLabel.Location = new System.Drawing.Point(12, 205);
            this.aoeLabel.Name = "aoeLabel";
            this.aoeLabel.Size = new System.Drawing.Size(29, 13);
            this.aoeLabel.TabIndex = 8;
            this.aoeLabel.Text = "AOE";
            // 
            // aoeBox
            // 
            this.aoeBox.Location = new System.Drawing.Point(12, 221);
            this.aoeBox.Name = "aoeBox";
            this.aoeBox.Size = new System.Drawing.Size(100, 20);
            this.aoeBox.TabIndex = 5;
            this.aoeBox.Text = "1";
            this.aoeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.aoeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // castStyleBox
            // 
            this.castStyleBox.FormattingEnabled = true;
            this.castStyleBox.Items.AddRange(new object[] {
            "On Touch/Self",
            "On Target",
            "Constant Effect"});
            this.castStyleBox.Location = new System.Drawing.Point(12, 25);
            this.castStyleBox.Name = "castStyleBox";
            this.castStyleBox.Size = new System.Drawing.Size(100, 21);
            this.castStyleBox.TabIndex = 0;
            // 
            // castStyleLabel
            // 
            this.castStyleLabel.AutoSize = true;
            this.castStyleLabel.Location = new System.Drawing.Point(12, 9);
            this.castStyleLabel.Name = "castStyleLabel";
            this.castStyleLabel.Size = new System.Drawing.Size(54, 13);
            this.castStyleLabel.TabIndex = 11;
            this.castStyleLabel.Text = "Cast Style";
            // 
            // effectsGridView
            // 
            this.effectsGridView.AllowUserToAddRows = false;
            this.effectsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.effectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.effectsGridView.Location = new System.Drawing.Point(118, 25);
            this.effectsGridView.Name = "effectsGridView";
            this.effectsGridView.ReadOnly = true;
            this.effectsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.effectsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.effectsGridView.Size = new System.Drawing.Size(568, 257);
            this.effectsGridView.TabIndex = 12;
            this.effectsGridView.TabStop = false;
            this.effectsGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.effectsGridView_RowsRemoved);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Effect";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 294);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.effectsGridView);
            this.Controls.Add(this.castStyleLabel);
            this.Controls.Add(this.castStyleBox);
            this.Controls.Add(this.aoeBox);
            this.Controls.Add(this.aoeLabel);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.maxMagBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minMagBox);
            this.Controls.Add(this.minMagLabel);
            this.Controls.Add(this.baseCostBox);
            this.Controls.Add(this.baseCostLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEffectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Effects";
            this.Load += new System.EventHandler(this.AddEffectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.effectsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseCostLabel;
        private System.Windows.Forms.TextBox baseCostBox;
        private System.Windows.Forms.Label minMagLabel;
        private System.Windows.Forms.TextBox minMagBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxMagBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.Label aoeLabel;
        private System.Windows.Forms.TextBox aoeBox;
        private System.Windows.Forms.ComboBox castStyleBox;
        private System.Windows.Forms.Label castStyleLabel;
        private System.Windows.Forms.DataGridView effectsGridView;
        private System.Windows.Forms.Button addButton;
    }
}