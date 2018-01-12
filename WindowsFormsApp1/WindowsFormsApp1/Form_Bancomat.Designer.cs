namespace WindowsFormsApp1
{
    partial class Form_Bancomat
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
            this.label1 = new System.Windows.Forms.Label();
            this.INPUT_AMOUNT = new System.Windows.Forms.TextBox();
            this.Withraw = new System.Windows.Forms.Button();
            this.info_display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM";
            // 
            // INPUT_AMOUNT
            // 
            this.INPUT_AMOUNT.Location = new System.Drawing.Point(12, 46);
            this.INPUT_AMOUNT.Multiline = true;
            this.INPUT_AMOUNT.Name = "INPUT_AMOUNT";
            this.INPUT_AMOUNT.Size = new System.Drawing.Size(171, 20);
            this.INPUT_AMOUNT.TabIndex = 1;
            this.INPUT_AMOUNT.Text = "Input amount of money : ";
            this.INPUT_AMOUNT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.INPUT_AMOUNT_MouseClick);
            this.INPUT_AMOUNT.TextChanged += new System.EventHandler(this.INPUT_AMOUNT_TextChanged);
            // 
            // Withraw
            // 
            this.Withraw.Location = new System.Drawing.Point(197, 46);
            this.Withraw.Name = "Withraw";
            this.Withraw.Size = new System.Drawing.Size(75, 20);
            this.Withraw.TabIndex = 2;
            this.Withraw.Text = "withdraw ";
            this.Withraw.UseVisualStyleBackColor = true;
            this.Withraw.Click += new System.EventHandler(this.Withraw_Click);
            // 
            // info_display
            // 
            this.info_display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.info_display.Location = new System.Drawing.Point(12, 119);
            this.info_display.Multiline = true;
            this.info_display.Name = "info_display";
            this.info_display.Size = new System.Drawing.Size(260, 117);
            this.info_display.TabIndex = 3;
            this.info_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info_display.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Bancomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.info_display);
            this.Controls.Add(this.Withraw);
            this.Controls.Add(this.INPUT_AMOUNT);
            this.Controls.Add(this.label1);
            this.Name = "Form_Bancomat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Bancomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INPUT_AMOUNT;
        private System.Windows.Forms.Button Withraw;
        private System.Windows.Forms.TextBox info_display;
    }
}