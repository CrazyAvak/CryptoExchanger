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
            this.SuspendLayout();
            // 
            // comboBoxCur1
            // 
            this.comboBoxCur1.FormattingEnabled = true;
            this.comboBoxCur1.Location = new System.Drawing.Point(80, 142);
            this.comboBoxCur1.Name = "comboBoxCur1";
            this.comboBoxCur1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCur1.TabIndex = 0;
            // 
            // comboBoxCur2
            // 
            this.comboBoxCur2.FormattingEnabled = true;
            this.comboBoxCur2.Location = new System.Drawing.Point(223, 142);
            this.comboBoxCur2.Name = "comboBoxCur2";
            this.comboBoxCur2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCur2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.comboBoxCur2);
            this.Controls.Add(this.comboBoxCur1);
            this.Name = "Form1";
            this.Text = "CryptoExchanger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCur1;
        private System.Windows.Forms.ComboBox comboBoxCur2;
    }
}

