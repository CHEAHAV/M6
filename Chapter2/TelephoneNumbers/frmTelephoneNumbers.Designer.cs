namespace TelephoneNumbers
{
    partial class frmTelephoneNumbers
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
            this.txtAlphanumericNumber = new System.Windows.Forms.TextBox();
            this.txtNumericOnly = new System.Windows.Forms.TextBox();
            this.btnConverttoNumericOnly = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alphanumeric Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numeric Only : ";
            // 
            // txtAlphanumericNumber
            // 
            this.txtAlphanumericNumber.Location = new System.Drawing.Point(361, 48);
            this.txtAlphanumericNumber.Multiline = true;
            this.txtAlphanumericNumber.Name = "txtAlphanumericNumber";
            this.txtAlphanumericNumber.Size = new System.Drawing.Size(148, 36);
            this.txtAlphanumericNumber.TabIndex = 2;
            // 
            // txtNumericOnly
            // 
            this.txtNumericOnly.Location = new System.Drawing.Point(361, 116);
            this.txtNumericOnly.Multiline = true;
            this.txtNumericOnly.Name = "txtNumericOnly";
            this.txtNumericOnly.ReadOnly = true;
            this.txtNumericOnly.Size = new System.Drawing.Size(148, 36);
            this.txtNumericOnly.TabIndex = 3;
            // 
            // btnConverttoNumericOnly
            // 
            this.btnConverttoNumericOnly.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverttoNumericOnly.Location = new System.Drawing.Point(126, 214);
            this.btnConverttoNumericOnly.Name = "btnConverttoNumericOnly";
            this.btnConverttoNumericOnly.Size = new System.Drawing.Size(123, 82);
            this.btnConverttoNumericOnly.TabIndex = 4;
            this.btnConverttoNumericOnly.Text = "&Convert to Numeric Only";
            this.btnConverttoNumericOnly.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(361, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConverttoNumericOnly;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(593, 319);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConverttoNumericOnly);
            this.Controls.Add(this.txtNumericOnly);
            this.Controls.Add(this.txtAlphanumericNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlphanumericNumber;
        private System.Windows.Forms.TextBox txtNumericOnly;
        private System.Windows.Forms.Button btnConverttoNumericOnly;
        private System.Windows.Forms.Button btnExit;
    }
}

