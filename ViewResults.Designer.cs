namespace TPQR_Session5_23_9
{
    partial class ViewResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSkill = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbGold1 = new System.Windows.Forms.PictureBox();
            this.pbGold2 = new System.Windows.Forms.PictureBox();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.pbSilver2 = new System.Windows.Forms.PictureBox();
            this.pbSilver1 = new System.Windows.Forms.PictureBox();
            this.btnBronze = new System.Windows.Forms.Button();
            this.pbBronze2 = new System.Windows.Forms.PictureBox();
            this.pbBronze1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze1)).BeginInit();
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
            this.panel1.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(741, 37);
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
            this.panel2.Location = new System.Drawing.Point(0, 682);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 54);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(408, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "View Results";
            // 
            // cbSkill
            // 
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FormattingEnabled = true;
            this.cbSkill.Location = new System.Drawing.Point(397, 145);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(198, 33);
            this.cbSkill.TabIndex = 12;
            this.cbSkill.SelectedIndexChanged += new System.EventHandler(this.cbSkill_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Skill: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 372);
            this.dataGridView1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total No. of Sessions: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(255, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(867, 215);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(25, 25);
            this.lblCompleted.TabIndex = 17;
            this.lblCompleted.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. of Completed Sessions: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGold);
            this.groupBox1.Controls.Add(this.pbGold2);
            this.groupBox1.Controls.Add(this.pbGold1);
            this.groupBox1.Location = new System.Drawing.Point(484, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSilver);
            this.groupBox2.Controls.Add(this.pbSilver2);
            this.groupBox2.Controls.Add(this.pbSilver1);
            this.groupBox2.Location = new System.Drawing.Point(484, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 135);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Silver";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBronze);
            this.groupBox3.Controls.Add(this.pbBronze1);
            this.groupBox3.Controls.Add(this.pbBronze2);
            this.groupBox3.Location = new System.Drawing.Point(484, 538);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 135);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bronze";
            // 
            // pbGold1
            // 
            this.pbGold1.Location = new System.Drawing.Point(86, 31);
            this.pbGold1.Name = "pbGold1";
            this.pbGold1.Size = new System.Drawing.Size(100, 50);
            this.pbGold1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold1.TabIndex = 0;
            this.pbGold1.TabStop = false;
            // 
            // pbGold2
            // 
            this.pbGold2.Location = new System.Drawing.Point(308, 31);
            this.pbGold2.Name = "pbGold2";
            this.pbGold2.Size = new System.Drawing.Size(100, 50);
            this.pbGold2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold2.TabIndex = 1;
            this.pbGold2.TabStop = false;
            // 
            // btnGold
            // 
            this.btnGold.Location = new System.Drawing.Point(189, 84);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(106, 35);
            this.btnGold.TabIndex = 2;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Visible = false;
            // 
            // btnSilver
            // 
            this.btnSilver.Location = new System.Drawing.Point(189, 84);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(106, 35);
            this.btnSilver.TabIndex = 5;
            this.btnSilver.Text = "Silver";
            this.btnSilver.UseVisualStyleBackColor = true;
            this.btnSilver.Visible = false;
            // 
            // pbSilver2
            // 
            this.pbSilver2.Location = new System.Drawing.Point(308, 31);
            this.pbSilver2.Name = "pbSilver2";
            this.pbSilver2.Size = new System.Drawing.Size(100, 50);
            this.pbSilver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilver2.TabIndex = 4;
            this.pbSilver2.TabStop = false;
            // 
            // pbSilver1
            // 
            this.pbSilver1.Location = new System.Drawing.Point(86, 31);
            this.pbSilver1.Name = "pbSilver1";
            this.pbSilver1.Size = new System.Drawing.Size(100, 50);
            this.pbSilver1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilver1.TabIndex = 3;
            this.pbSilver1.TabStop = false;
            // 
            // btnBronze
            // 
            this.btnBronze.Location = new System.Drawing.Point(189, 84);
            this.btnBronze.Name = "btnBronze";
            this.btnBronze.Size = new System.Drawing.Size(106, 35);
            this.btnBronze.TabIndex = 8;
            this.btnBronze.Text = "Bronze";
            this.btnBronze.UseVisualStyleBackColor = true;
            this.btnBronze.Visible = false;
            // 
            // pbBronze2
            // 
            this.pbBronze2.Location = new System.Drawing.Point(308, 31);
            this.pbBronze2.Name = "pbBronze2";
            this.pbBronze2.Size = new System.Drawing.Size(100, 50);
            this.pbBronze2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBronze2.TabIndex = 7;
            this.pbBronze2.TabStop = false;
            // 
            // pbBronze1
            // 
            this.pbBronze1.Location = new System.Drawing.Point(86, 31);
            this.pbBronze1.Name = "pbBronze1";
            this.pbBronze1.Size = new System.Drawing.Size(100, 50);
            this.pbBronze1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBronze1.TabIndex = 6;
            this.pbBronze1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Competitors";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 163;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Country";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 122;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Marks";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 143;
            // 
            // ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 736);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ViewResults";
            this.Text = "View Results";
            this.Load += new System.EventHandler(this.ViewResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSkill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.PictureBox pbGold2;
        private System.Windows.Forms.PictureBox pbGold1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.PictureBox pbSilver2;
        private System.Windows.Forms.PictureBox pbSilver1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBronze;
        private System.Windows.Forms.PictureBox pbBronze1;
        private System.Windows.Forms.PictureBox pbBronze2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}