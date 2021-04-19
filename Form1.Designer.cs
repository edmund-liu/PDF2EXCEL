namespace PDF2CSV
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPDFLoc = new System.Windows.Forms.Button();
            this.btnExcelLoc = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source PDF File Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Excel FIle Location";
            // 
            // btnPDFLoc
            // 
            this.btnPDFLoc.Location = new System.Drawing.Point(185, 30);
            this.btnPDFLoc.Name = "btnPDFLoc";
            this.btnPDFLoc.Size = new System.Drawing.Size(61, 23);
            this.btnPDFLoc.TabIndex = 3;
            this.btnPDFLoc.Text = "...";
            this.btnPDFLoc.UseVisualStyleBackColor = true;
            this.btnPDFLoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcelLoc
            // 
            this.btnExcelLoc.Location = new System.Drawing.Point(185, 92);
            this.btnExcelLoc.Name = "btnExcelLoc";
            this.btnExcelLoc.Size = new System.Drawing.Size(61, 23);
            this.btnExcelLoc.TabIndex = 4;
            this.btnExcelLoc.Text = "...";
            this.btnExcelLoc.UseVisualStyleBackColor = true;
            this.btnExcelLoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(278, 97);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 5;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(278, 40);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 13);
            this.lblInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 211);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExcelLoc);
            this.Controls.Add(this.btnPDFLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FUEL PDF REPORT TO EXCEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPDFLoc;
        private System.Windows.Forms.Button btnExcelLoc;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
    }
}

