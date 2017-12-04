namespace CryptonatorExchanger
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
            this.comboBoxCur1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCur2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAmount1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAmount2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelExchangeActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValue1 = new System.Windows.Forms.Label();
            this.labelValue2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCur1
            // 
            this.comboBoxCur1.FormattingEnabled = true;
            this.comboBoxCur1.Location = new System.Drawing.Point(6, 63);
            this.comboBoxCur1.Name = "comboBoxCur1";
            this.comboBoxCur1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCur1.TabIndex = 0;
            this.comboBoxCur1.SelectedIndexChanged += new System.EventHandler(this.comboBoxCur1_SelectedIndexChanged);
            // 
            // comboBoxCur2
            // 
            this.comboBoxCur2.FormattingEnabled = true;
            this.comboBoxCur2.Location = new System.Drawing.Point(73, 63);
            this.comboBoxCur2.Name = "comboBoxCur2";
            this.comboBoxCur2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCur2.TabIndex = 1;
            this.comboBoxCur2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCur2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValue1);
            this.groupBox1.Controls.Add(this.labelAmount1);
            this.groupBox1.Controls.Add(this.comboBoxCur1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency 1";
            // 
            // labelAmount1
            // 
            this.labelAmount1.AutoSize = true;
            this.labelAmount1.Location = new System.Drawing.Point(6, 16);
            this.labelAmount1.Name = "labelAmount1";
            this.labelAmount1.Size = new System.Drawing.Size(70, 13);
            this.labelAmount1.TabIndex = 2;
            this.labelAmount1.Text = "Coin Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelValue2);
            this.groupBox2.Controls.Add(this.labelAmount2);
            this.groupBox2.Controls.Add(this.comboBoxCur2);
            this.groupBox2.Location = new System.Drawing.Point(231, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency 2";
            // 
            // labelAmount2
            // 
            this.labelAmount2.AutoSize = true;
            this.labelAmount2.Location = new System.Drawing.Point(6, 16);
            this.labelAmount2.Name = "labelAmount2";
            this.labelAmount2.Size = new System.Drawing.Size(70, 13);
            this.labelAmount2.TabIndex = 3;
            this.labelAmount2.Text = "Coin Amount:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(167, 203);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 86);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start exchange";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelExchangeActive
            // 
            this.labelExchangeActive.AutoSize = true;
            this.labelExchangeActive.BackColor = System.Drawing.Color.Red;
            this.labelExchangeActive.Location = new System.Drawing.Point(12, 9);
            this.labelExchangeActive.Name = "labelExchangeActive";
            this.labelExchangeActive.Size = new System.Drawing.Size(118, 13);
            this.labelExchangeActive.TabIndex = 4;
            this.labelExchangeActive.Text = "Exchanger is not active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "->";
            // 
            // labelValue1
            // 
            this.labelValue1.AutoSize = true;
            this.labelValue1.Location = new System.Drawing.Point(6, 29);
            this.labelValue1.Name = "labelValue1";
            this.labelValue1.Size = new System.Drawing.Size(62, 13);
            this.labelValue1.TabIndex = 3;
            this.labelValue1.Text = "Coin in usd:";
            // 
            // labelValue2
            // 
            this.labelValue2.AutoSize = true;
            this.labelValue2.Location = new System.Drawing.Point(6, 29);
            this.labelValue2.Name = "labelValue2";
            this.labelValue2.Size = new System.Drawing.Size(62, 13);
            this.labelValue2.TabIndex = 4;
            this.labelValue2.Text = "Coin in usd:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExchangeActive);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CryptoExchanger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCur1;
        private System.Windows.Forms.ComboBox comboBoxCur2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAmount1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmount2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelExchangeActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValue1;
        private System.Windows.Forms.Label labelValue2;
    }
}

