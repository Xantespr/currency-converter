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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.curLabel1 = new System.Windows.Forms.Label();
            this.curLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseCurBox
            // 
            this.baseCurBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.baseCurBox.CausesValidation = false;
            this.baseCurBox.DisplayMember = "(brak)";
            this.baseCurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseCurBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.baseCurBox.FormattingEnabled = true;
            this.baseCurBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baseCurBox.Location = new System.Drawing.Point(18, 81);
            this.baseCurBox.Name = "baseCurBox";
            this.baseCurBox.Size = new System.Drawing.Size(200, 39);
            this.baseCurBox.Sorted = true;
            this.baseCurBox.TabIndex = 4;
            this.baseCurBox.SelectedIndexChanged += new System.EventHandler(this.baseCurBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONVERTED\r\n  AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "BASE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "TARGET";
            // 
            // targetCurBox
            // 
            this.targetCurBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.targetCurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetCurBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
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
            this.switchCurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.switchCurBtn.Location = new System.Drawing.Point(94, 126);
            this.switchCurBtn.Name = "switchCurBtn";
            this.switchCurBtn.Size = new System.Drawing.Size(52, 52);
            this.switchCurBtn.TabIndex = 9;
            this.switchCurBtn.Text = "↑↓";
            this.switchCurBtn.UseVisualStyleBackColor = false;
            this.switchCurBtn.Click += new System.EventHandler(this.switchCurBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(397, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
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
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.amountBox.Location = new System.Drawing.Point(18, 351);
            this.amountBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(200, 38);
            this.amountBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(259, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "CURENCY CONVERTER APP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(261, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 50);
            this.label5.TabIndex = 15;
            this.label5.Text = "This app converts currencies,\r\nrequires a network conection.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(309, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Result:";
            // 
            // helpIcon
            // 
            this.helpIcon.Image = global::currency_converter.Properties.Resources.help;
            this.helpIcon.Location = new System.Drawing.Point(641, 81);
            this.helpIcon.Name = "helpIcon";
            this.helpIcon.Size = new System.Drawing.Size(50, 50);
            this.helpIcon.TabIndex = 17;
            this.helpIcon.TabStop = false;
            this.helpIcon.Click += new System.EventHandler(this.helpIcon_Click);
            // 
            // curLabel1
            // 
            this.curLabel1.AutoSize = true;
            this.curLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.curLabel1.Location = new System.Drawing.Point(288, 166);
            this.curLabel1.Name = "curLabel1";
            this.curLabel1.Size = new System.Drawing.Size(333, 25);
            this.curLabel1.TabIndex = 18;
            this.curLabel1.Text = "Currency conversion from PLN";
            // 
            // curLabel2
            // 
            this.curLabel2.AutoSize = true;
            this.curLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.curLabel2.Location = new System.Drawing.Point(620, 166);
            this.curLabel2.Name = "curLabel2";
            this.curLabel2.Size = new System.Drawing.Size(90, 25);
            this.curLabel2.TabIndex = 19;
            this.curLabel2.Text = "to PLN.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(266, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 185);
            this.dataGridView1.TabIndex = 20;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(635, 219);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 20);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "add to table";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 160F;
            this.Column1.HeaderText = "base";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 180F;
            this.Column2.HeaderText = "base amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 180F;
            this.Column3.HeaderText = "target";
            this.Column3.MinimumWidth = 30;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 180F;
            this.Column4.HeaderText = "target amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.curLabel2);
            this.Controls.Add(this.curLabel1);
            this.Controls.Add(this.helpIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "currency converter";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label curLabel1;
        private System.Windows.Forms.Label curLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

