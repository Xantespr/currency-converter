namespace currency_converter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseCurBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.targetCurBox = new System.Windows.Forms.ComboBox();
            this.switchCurBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.helpIcon = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // baseCurBox
            // 
            this.baseCurBox.CausesValidation = false;
            this.baseCurBox.DisplayMember = "(brak)";
            this.baseCurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseCurBox.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.baseCurBox.FormattingEnabled = true;
            this.baseCurBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baseCurBox.Location = new System.Drawing.Point(18, 88);
            this.baseCurBox.Name = "baseCurBox";
            this.baseCurBox.Size = new System.Drawing.Size(200, 39);
            this.baseCurBox.Sorted = true;
            this.baseCurBox.TabIndex = 4;
            this.baseCurBox.SelectedIndexChanged += new System.EventHandler(this.baseCurBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONVERTED\r\n  AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "BASE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "TARGET";
            // 
            // targetCurBox
            // 
            this.targetCurBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.targetCurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetCurBox.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.targetCurBox.FormattingEnabled = true;
            this.targetCurBox.Location = new System.Drawing.Point(18, 216);
            this.targetCurBox.Name = "targetCurBox";
            this.targetCurBox.Size = new System.Drawing.Size(200, 39);
            this.targetCurBox.Sorted = true;
            this.targetCurBox.TabIndex = 8;
            this.targetCurBox.SelectedIndexChanged += new System.EventHandler(this.targetCurBox_SelectedIndexChanged);
            // 
            // switchCurBtn
            // 
            this.switchCurBtn.BackColor = System.Drawing.Color.SeaShell;
            this.switchCurBtn.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.switchCurBtn.Location = new System.Drawing.Point(94, 133);
            this.switchCurBtn.Name = "switchCurBtn";
            this.switchCurBtn.Size = new System.Drawing.Size(45, 45);
            this.switchCurBtn.TabIndex = 9;
            this.switchCurBtn.Text = "↑↓";
            this.switchCurBtn.UseVisualStyleBackColor = false;
            this.switchCurBtn.Click += new System.EventHandler(this.switchCurBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 51);
            this.textBox2.TabIndex = 10;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.amountBox);
            this.panelMenu.Controls.Add(this.targetCurBox);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.baseCurBox);
            this.panelMenu.Controls.Add(this.switchCurBtn);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 461);
            this.panelMenu.TabIndex = 13;
            // 
            // amountBox
            // 
            this.amountBox.DecimalPlaces = 2;
            this.amountBox.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.amountBox.Location = new System.Drawing.Point(18, 351);
            this.amountBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(200, 37);
            this.amountBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(303, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "CURENCY CONVERTER APP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(360, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "This  app converts the  currencies,\r\n        needs network conection.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(318, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Result:";
            // 
            // helpIcon
            // 
            this.helpIcon.Location = new System.Drawing.Point(626, 160);
            this.helpIcon.Name = "helpIcon";
            this.helpIcon.Size = new System.Drawing.Size(100, 50);
            this.helpIcon.TabIndex = 17;
            this.helpIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.helpIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "currency converter";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox baseCurBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox targetCurBox;
        private System.Windows.Forms.Button switchCurBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.PictureBox helpIcon;
    }
}

