namespace studentInformation
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
            this.b_submit = new System.Windows.Forms.Button();
            this.l_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(98, 173);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(75, 23);
            this.b_submit.TabIndex = 0;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.B_submit_Click);
            // 
            // l_firstName
            // 
            this.l_firstName.AutoSize = true;
            this.l_firstName.Location = new System.Drawing.Point(12, 39);
            this.l_firstName.Name = "l_firstName";
            this.l_firstName.Size = new System.Drawing.Size(80, 17);
            this.l_firstName.TabIndex = 1;
            this.l_firstName.Text = "First Name:";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(98, 36);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(288, 22);
            this.tb_firstName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.l_firstName);
            this.Controls.Add(this.b_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Label l_firstName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

