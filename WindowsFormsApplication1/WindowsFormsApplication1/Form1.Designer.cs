namespace WindowsFormsApplication1
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
            this.CalcButton = new System.Windows.Forms.Button();
            this.BillLabel = new System.Windows.Forms.Label();
            this.CalcBox = new System.Windows.Forms.TextBox();
            this.BillBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(99, 160);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            this.CalcButton.MouseHover += new System.EventHandler(this.CalcButton_MouseHover);
            this.CalcButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CalcButton_MouseMove);
            // 
            // BillLabel
            // 
            this.BillLabel.AutoSize = true;
            this.BillLabel.Location = new System.Drawing.Point(1, -2);
            this.BillLabel.Name = "BillLabel";
            this.BillLabel.Size = new System.Drawing.Size(20, 13);
            this.BillLabel.TabIndex = 1;
            this.BillLabel.Text = "Bill\r\n";
            this.BillLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalcBox
            // 
            this.CalcBox.Location = new System.Drawing.Point(198, 163);
            this.CalcBox.Name = "CalcBox";
            this.CalcBox.Size = new System.Drawing.Size(269, 20);
            this.CalcBox.TabIndex = 3;
            // 
            // BillBox
            // 
            this.BillBox.Location = new System.Drawing.Point(198, 99);
            this.BillBox.Name = "BillBox";
            this.BillBox.Size = new System.Drawing.Size(269, 20);
            this.BillBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 300);
            this.Controls.Add(this.BillBox);
            this.Controls.Add(this.CalcBox);
            this.Controls.Add(this.BillLabel);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label BillLabel;
        private System.Windows.Forms.TextBox CalcBox;
        private System.Windows.Forms.TextBox BillBox;
    }
}

