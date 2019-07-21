namespace studentInformation
{
    partial class mainForm
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
            this.l_lastName = new System.Windows.Forms.Label();
            this.l_section = new System.Windows.Forms.Label();
            this.cb_section = new System.Windows.Forms.ComboBox();
            this.dg_students = new System.Windows.Forms.DataGridView();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.l_search = new System.Windows.Forms.Label();
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
            // l_lastName
            // 
            this.l_lastName.AutoSize = true;
            this.l_lastName.Location = new System.Drawing.Point(11, 102);
            this.l_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_lastName.Name = "l_lastName";
            this.l_lastName.Size = new System.Drawing.Size(61, 13);
            this.l_lastName.TabIndex = 3;
            this.l_lastName.Text = "Last Name:";
            // 
            // l_section
            // 
            this.l_section.AutoSize = true;
            this.l_section.Location = new System.Drawing.Point(11, 133);
            this.l_section.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_section.Name = "l_section";
            this.l_section.Size = new System.Drawing.Size(46, 13);
            this.l_section.TabIndex = 5;
            this.l_section.Text = "Section:";
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
            this.dg_students.AllowUserToAddRows = false;
            this.dg_students.AllowUserToDeleteRows = false;
            this.dg_students.AllowUserToResizeColumns = false;
            this.dg_students.AllowUserToResizeRows = false;
            this.dg_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_students.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dg_students.Location = new System.Drawing.Point(339, 36);
            this.dg_students.Name = "dg_students";
            this.dg_students.ReadOnly = true;
            this.dg_students.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_students.RowHeadersVisible = false;
            this.dg_students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_students.Size = new System.Drawing.Size(378, 239);
            this.dg_students.TabIndex = 7;
            this.dg_students.SelectionChanged += new System.EventHandler(this.Dg_students_SelectionChanged);
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
            this.b_update.Click += new System.EventHandler(this.B_update_Click);
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
            this.b_delete.Click += new System.EventHandler(this.B_delete_Click);
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
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(156, 169);
            this.b_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(56, 19);
            this.b_cancel.TabIndex = 13;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(424, 11);
            this.tb_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(293, 20);
            this.tb_search.TabIndex = 15;
            this.tb_search.TextChanged += new System.EventHandler(this.Tb_search_TextChanged);
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.Location = new System.Drawing.Point(336, 14);
            this.l_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(75, 13);
            this.l_search.TabIndex = 14;
            this.l_search.Text = "Search Name:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 287);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.l_search);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.dg_students);
            this.Controls.Add(this.cb_section);
            this.Controls.Add(this.l_section);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.l_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.l_firstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
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
        private System.Windows.Forms.Label l_lastName;
        private System.Windows.Forms.Label l_section;
        private System.Windows.Forms.ComboBox cb_section;
        private System.Windows.Forms.DataGridView dg_students;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label l_search;
    }
}

