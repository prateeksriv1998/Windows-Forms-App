namespace WindowsFormsApp1
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
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.lblupload = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfileupload = new System.Windows.Forms.TextBox();
            this.btnsheet = new System.Windows.Forms.Button();
            this.txtsheet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(55, 43);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(216, 20);
            this.txtbarcode.TabIndex = 0;
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(52, 27);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(88, 13);
            this.lblbarcode.TabIndex = 1;
            this.lblbarcode.Text = "Barcode Textbox";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(55, 109);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(75, 23);
            this.btnupload.TabIndex = 2;
            this.btnupload.Text = "Upload File";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // lblupload
            // 
            this.lblupload.AutoSize = true;
            this.lblupload.Location = new System.Drawing.Point(377, 46);
            this.lblupload.Name = "lblupload";
            this.lblupload.Size = new System.Drawing.Size(0, 13);
            this.lblupload.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtfileupload
            // 
            this.txtfileupload.Location = new System.Drawing.Point(154, 109);
            this.txtfileupload.Name = "txtfileupload";
            this.txtfileupload.Size = new System.Drawing.Size(577, 20);
            this.txtfileupload.TabIndex = 5;
            // 
            // btnsheet
            // 
            this.btnsheet.Location = new System.Drawing.Point(55, 149);
            this.btnsheet.Name = "btnsheet";
            this.btnsheet.Size = new System.Drawing.Size(75, 23);
            this.btnsheet.TabIndex = 6;
            this.btnsheet.Text = "Load Sheet";
            this.btnsheet.UseVisualStyleBackColor = true;
            this.btnsheet.Click += new System.EventHandler(this.btnsheet_Click);
            // 
            // txtsheet
            // 
            this.txtsheet.Location = new System.Drawing.Point(154, 149);
            this.txtsheet.Name = "txtsheet";
            this.txtsheet.Size = new System.Drawing.Size(577, 20);
            this.txtsheet.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsheet);
            this.Controls.Add(this.btnsheet);
            this.Controls.Add(this.txtfileupload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblupload);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.txtbarcode);
            this.Name = "Form1";
            this.Text = "Demo App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label lblupload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfileupload;
        private System.Windows.Forms.Button btnsheet;
        private System.Windows.Forms.TextBox txtsheet;
    }
}