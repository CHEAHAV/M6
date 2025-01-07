using System;

namespace StudentPopulation
{
    partial class frmStudentPupolation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProjectednumberofstudent = new System.Windows.Forms.Label();
            this.txtNumberofstudenttoday = new System.Windows.Forms.TextBox();
            this.txtAnnualgrowthrate = new System.Windows.Forms.TextBox();
            this.txtNumberofyears = new System.Windows.Forms.TextBox();
            this.btnProjectStudentPopulation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students today : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual growth rate : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of years : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projected number of student : ";
            // 
            // lblProjectednumberofstudent
            // 
            this.lblProjectednumberofstudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjectednumberofstudent.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectednumberofstudent.Location = new System.Drawing.Point(474, 226);
            this.lblProjectednumberofstudent.Name = "lblProjectednumberofstudent";
            this.lblProjectednumberofstudent.Size = new System.Drawing.Size(145, 37);
            this.lblProjectednumberofstudent.TabIndex = 4;
            // 
            // txtNumberofstudenttoday
            // 
            this.txtNumberofstudenttoday.Location = new System.Drawing.Point(474, 66);
            this.txtNumberofstudenttoday.Multiline = true;
            this.txtNumberofstudenttoday.Name = "txtNumberofstudenttoday";
            this.txtNumberofstudenttoday.Size = new System.Drawing.Size(145, 36);
            this.txtNumberofstudenttoday.TabIndex = 5;
            // 
            // txtAnnualgrowthrate
            // 
            this.txtAnnualgrowthrate.Location = new System.Drawing.Point(474, 117);
            this.txtAnnualgrowthrate.Multiline = true;
            this.txtAnnualgrowthrate.Name = "txtAnnualgrowthrate";
            this.txtAnnualgrowthrate.Size = new System.Drawing.Size(145, 36);
            this.txtAnnualgrowthrate.TabIndex = 6;
            // 
            // txtNumberofyears
            // 
            this.txtNumberofyears.Location = new System.Drawing.Point(474, 173);
            this.txtNumberofyears.Multiline = true;
            this.txtNumberofyears.Name = "txtNumberofyears";
            this.txtNumberofyears.Size = new System.Drawing.Size(145, 36);
            this.txtNumberofyears.TabIndex = 7;
            // 
            // btnProjectStudentPopulation
            // 
            this.btnProjectStudentPopulation.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectStudentPopulation.Location = new System.Drawing.Point(165, 297);
            this.btnProjectStudentPopulation.Name = "btnProjectStudentPopulation";
            this.btnProjectStudentPopulation.Size = new System.Drawing.Size(111, 69);
            this.btnProjectStudentPopulation.TabIndex = 8;
            this.btnProjectStudentPopulation.Text = "&Project Student Population";
            this.btnProjectStudentPopulation.UseVisualStyleBackColor = true;
            this.btnProjectStudentPopulation.Click += new System.EventHandler(this.btnProjectStudentPopulation_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(408, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentPupolation
            // 
            this.AcceptButton = this.btnProjectStudentPopulation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProjectStudentPopulation);
            this.Controls.Add(this.txtNumberofyears);
            this.Controls.Add(this.txtAnnualgrowthrate);
            this.Controls.Add(this.txtNumberofstudenttoday);
            this.Controls.Add(this.lblProjectednumberofstudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentPupolation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProjectednumberofstudent;
        private System.Windows.Forms.TextBox txtNumberofstudenttoday;
        private System.Windows.Forms.TextBox txtAnnualgrowthrate;
        private System.Windows.Forms.TextBox txtNumberofyears;
        private System.Windows.Forms.Button btnProjectStudentPopulation;
        private System.Windows.Forms.Button btnExit;
    }
}

