﻿namespace TPQR_Session5_23_9
{
    partial class AdminMain
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
            this.btnAssignSeating = new System.Windows.Forms.Button();
            this.btnEnterMarks = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.btnAnalyzeResults = new System.Windows.Forms.Button();
            this.btnCalculateBonus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(974, 100);
            this.panel1.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 54);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(335, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrator Main Menu";
            // 
            // btnAssignSeating
            // 
            this.btnAssignSeating.Location = new System.Drawing.Point(370, 164);
            this.btnAssignSeating.Name = "btnAssignSeating";
            this.btnAssignSeating.Size = new System.Drawing.Size(236, 68);
            this.btnAssignSeating.TabIndex = 4;
            this.btnAssignSeating.Text = "Assign Seating";
            this.btnAssignSeating.UseVisualStyleBackColor = true;
            this.btnAssignSeating.Click += new System.EventHandler(this.btnAssignSeating_Click);
            // 
            // btnEnterMarks
            // 
            this.btnEnterMarks.Location = new System.Drawing.Point(370, 238);
            this.btnEnterMarks.Name = "btnEnterMarks";
            this.btnEnterMarks.Size = new System.Drawing.Size(236, 68);
            this.btnEnterMarks.TabIndex = 5;
            this.btnEnterMarks.Text = "Enter Marks";
            this.btnEnterMarks.UseVisualStyleBackColor = true;
            // 
            // btnViewResults
            // 
            this.btnViewResults.Location = new System.Drawing.Point(370, 312);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(236, 68);
            this.btnViewResults.TabIndex = 6;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = true;
            // 
            // btnAnalyzeResults
            // 
            this.btnAnalyzeResults.Location = new System.Drawing.Point(370, 386);
            this.btnAnalyzeResults.Name = "btnAnalyzeResults";
            this.btnAnalyzeResults.Size = new System.Drawing.Size(236, 68);
            this.btnAnalyzeResults.TabIndex = 7;
            this.btnAnalyzeResults.Text = "Analyze Results";
            this.btnAnalyzeResults.UseVisualStyleBackColor = true;
            // 
            // btnCalculateBonus
            // 
            this.btnCalculateBonus.Location = new System.Drawing.Point(370, 460);
            this.btnCalculateBonus.Name = "btnCalculateBonus";
            this.btnCalculateBonus.Size = new System.Drawing.Size(236, 68);
            this.btnCalculateBonus.TabIndex = 8;
            this.btnCalculateBonus.Text = "Calculate Bonus";
            this.btnCalculateBonus.UseVisualStyleBackColor = true;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 614);
            this.Controls.Add(this.btnCalculateBonus);
            this.Controls.Add(this.btnAnalyzeResults);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.btnEnterMarks);
            this.Controls.Add(this.btnAssignSeating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminMain";
            this.Text = "Admin Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssignSeating;
        private System.Windows.Forms.Button btnEnterMarks;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnAnalyzeResults;
        private System.Windows.Forms.Button btnCalculateBonus;
    }
}