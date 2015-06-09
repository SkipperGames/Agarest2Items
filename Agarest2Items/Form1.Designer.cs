namespace Agarest2Items
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.quantityCheckbox = new System.Windows.Forms.CheckBox();
            this.statsCheckbox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.dlcCheckbox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(12, 103);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(280, 32);
            this.itemButton.TabIndex = 0;
            this.itemButton.Text = "Get All Items";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += this.button1_Click;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.quantityCheckbox);
            this.groupBox4.Controls.Add(this.statsCheckbox);
            this.groupBox4.Controls.Add(this.overwriteCheckbox);
            this.groupBox4.Controls.Add(this.dlcCheckbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 69);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preferences";
            // 
            // quantityCheckbox
            // 
            this.quantityCheckbox.AutoSize = true;
            this.quantityCheckbox.Checked = true;
            this.quantityCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quantityCheckbox.Location = new System.Drawing.Point(139, 44);
            this.quantityCheckbox.Name = "quantityCheckbox";
            this.quantityCheckbox.Size = new System.Drawing.Size(86, 17);
            this.quantityCheckbox.TabIndex = 3;
            this.quantityCheckbox.Text = "Max quantity";
            this.quantityCheckbox.UseVisualStyleBackColor = true;
            // 
            // statsCheckbox
            // 
            this.statsCheckbox.AutoSize = true;
            this.statsCheckbox.Checked = true;
            this.statsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statsCheckbox.Location = new System.Drawing.Point(139, 20);
            this.statsCheckbox.Name = "statsCheckbox";
            this.statsCheckbox.Size = new System.Drawing.Size(71, 17);
            this.statsCheckbox.TabIndex = 2;
            this.statsCheckbox.Text = "Max stats";
            this.statsCheckbox.UseVisualStyleBackColor = true;
            // 
            // overwriteCheckbox
            // 
            this.overwriteCheckbox.AutoSize = true;
            this.overwriteCheckbox.Checked = true;
            this.overwriteCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteCheckbox.Location = new System.Drawing.Point(7, 44);
            this.overwriteCheckbox.Name = "overwriteCheckbox";
            this.overwriteCheckbox.Size = new System.Drawing.Size(109, 17);
            this.overwriteCheckbox.TabIndex = 1;
            this.overwriteCheckbox.Text = "Overwrite existing";
            this.overwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // dlcCheckbox
            // 
            this.dlcCheckbox.AutoSize = true;
            this.dlcCheckbox.Checked = true;
            this.dlcCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dlcCheckbox.Location = new System.Drawing.Point(7, 20);
            this.dlcCheckbox.Name = "dlcCheckbox";
            this.dlcCheckbox.Size = new System.Drawing.Size(85, 17);
            this.dlcCheckbox.TabIndex = 0;
            this.dlcCheckbox.Text = "Include DLC";
            this.dlcCheckbox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(13, 165);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Max Skills";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.Name = "Form1";
            this.Text = "Agarest 2 Items";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox overwriteCheckbox;
        private System.Windows.Forms.CheckBox dlcCheckbox;
        private System.Windows.Forms.CheckBox quantityCheckbox;
        private System.Windows.Forms.CheckBox statsCheckbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

