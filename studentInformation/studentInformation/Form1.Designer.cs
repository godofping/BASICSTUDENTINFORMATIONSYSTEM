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
            this.l_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_section = new System.Windows.Forms.ComboBox();
            this.dg_students = new System.Windows.Forms.DataGridView();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_students)).BeginInit();
            this.SuspendLayout();
            // 
            // l_firstName
            // 
            this.l_firstName.AutoSize = true;
            this.l_firstName.Location = new System.Drawing.Point(9, 73);
            this.l_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_firstName.Name = "l_firstName";
            this.l_firstName.Size = new System.Drawing.Size(60, 13);
            this.l_firstName.TabIndex = 1;
            this.l_firstName.Text = "First Name:";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(74, 70);
            this.tb_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(217, 20);
            this.tb_firstName.TabIndex = 2;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(74, 99);
            this.tb_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(217, 20);
            this.tb_lastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Section:";
            // 
            // cb_section
            // 
            this.cb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_section.FormattingEnabled = true;
            this.cb_section.Location = new System.Drawing.Point(74, 130);
            this.cb_section.Name = "cb_section";
            this.cb_section.Size = new System.Drawing.Size(217, 21);
            this.cb_section.TabIndex = 6;
            // 
            // dg_students
            // 
            this.dg_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_students.Location = new System.Drawing.Point(339, 32);
            this.dg_students.Name = "dg_students";
            this.dg_students.Size = new System.Drawing.Size(378, 239);
            this.dg_students.TabIndex = 7;
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(235, 169);
            this.b_clear.Margin = new System.Windows.Forms.Padding(2);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(56, 19);
            this.b_clear.TabIndex = 8;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.B_clear_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(156, 32);
            this.b_update.Margin = new System.Windows.Forms.Padding(2);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(56, 19);
            this.b_update.TabIndex = 9;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(235, 32);
            this.b_delete.Margin = new System.Windows.Forms.Padding(2);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(56, 19);
            this.b_delete.TabIndex = 10;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(74, 32);
            this.b_add.Margin = new System.Windows.Forms.Padding(2);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(56, 19);
            this.b_add.TabIndex = 11;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(74, 169);
            this.b_save.Margin = new System.Windows.Forms.Padding(2);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(56, 19);
            this.b_save.TabIndex = 12;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 295);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.dg_students);
            this.Controls.Add(this.cb_section);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.l_firstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BASIC STUDENT INFORMATION SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_firstName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_section;
        private System.Windows.Forms.DataGridView dg_students;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_save;
    }
}

