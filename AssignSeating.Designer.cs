﻿namespace TPQR_Session5_23_9
{
    partial class AssignSeating
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSkill = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUnassigned = new System.Windows.Forms.ListBox();
            this.btnRandomAssign = new System.Windows.Forms.Button();
            this.btnManualAssign = new System.Windows.Forms.Button();
            this.btnSwapSeat = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 54);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(384, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assign Seating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skill: ";
            // 
            // cbSkill
            // 
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FormattingEnabled = true;
            this.cbSkill.Location = new System.Drawing.Point(389, 158);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(198, 33);
            this.cbSkill.TabIndex = 6;
            this.cbSkill.SelectedIndexChanged += new System.EventHandler(this.cbSkill_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assigned Competitors: ";
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Location = new System.Drawing.Point(264, 205);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(25, 25);
            this.lblAssigned.TabIndex = 8;
            this.lblAssigned.Text = "0";
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.AutoSize = true;
            this.lblUnassigned.Location = new System.Drawing.Point(857, 205);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(25, 25);
            this.lblUnassigned.TabIndex = 10;
            this.lblUnassigned.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unassigned Competitors: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 322);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unassigned";
            // 
            // lbUnassigned
            // 
            this.lbUnassigned.FormattingEnabled = true;
            this.lbUnassigned.ItemHeight = 25;
            this.lbUnassigned.Location = new System.Drawing.Point(534, 271);
            this.lbUnassigned.Name = "lbUnassigned";
            this.lbUnassigned.Size = new System.Drawing.Size(388, 204);
            this.lbUnassigned.TabIndex = 13;
            // 
            // btnRandomAssign
            // 
            this.btnRandomAssign.Location = new System.Drawing.Point(534, 494);
            this.btnRandomAssign.Name = "btnRandomAssign";
            this.btnRandomAssign.Size = new System.Drawing.Size(191, 69);
            this.btnRandomAssign.TabIndex = 14;
            this.btnRandomAssign.Text = "Randomly Assign";
            this.btnRandomAssign.UseVisualStyleBackColor = true;
            this.btnRandomAssign.Click += new System.EventHandler(this.btnRandomAssign_Click);
            // 
            // btnManualAssign
            // 
            this.btnManualAssign.Location = new System.Drawing.Point(731, 494);
            this.btnManualAssign.Name = "btnManualAssign";
            this.btnManualAssign.Size = new System.Drawing.Size(191, 69);
            this.btnManualAssign.TabIndex = 15;
            this.btnManualAssign.Text = "Manually Assign";
            this.btnManualAssign.UseVisualStyleBackColor = true;
            this.btnManualAssign.Click += new System.EventHandler(this.btnManualAssign_Click);
            // 
            // btnSwapSeat
            // 
            this.btnSwapSeat.Location = new System.Drawing.Point(534, 569);
            this.btnSwapSeat.Name = "btnSwapSeat";
            this.btnSwapSeat.Size = new System.Drawing.Size(191, 69);
            this.btnSwapSeat.TabIndex = 16;
            this.btnSwapSeat.Text = "Swap Seats";
            this.btnSwapSeat.UseVisualStyleBackColor = true;
            this.btnSwapSeat.Click += new System.EventHandler(this.btnSwapSeat_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(731, 569);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(191, 69);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 6;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 6;
            // 
            // AssignSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 716);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSwapSeat);
            this.Controls.Add(this.btnManualAssign);
            this.Controls.Add(this.btnRandomAssign);
            this.Controls.Add(this.lbUnassigned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUnassigned);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AssignSeating";
            this.Text = "Assign Seating";
            this.Load += new System.EventHandler(this.AssignSeating_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSkill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbUnassigned;
        private System.Windows.Forms.Button btnRandomAssign;
        private System.Windows.Forms.Button btnManualAssign;
        private System.Windows.Forms.Button btnSwapSeat;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}