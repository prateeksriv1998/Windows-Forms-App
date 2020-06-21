using System;

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
            this.lblcode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtipaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnping = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(118, 31);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(234, 20);
            this.txtbarcode.TabIndex = 0;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(18, 34);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(94, 13);
            this.lblbarcode.TabIndex = 1;
            this.lblbarcode.Text = "Barcode Textbox :";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(21, 43);
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
            this.lblupload.Location = new System.Drawing.Point(683, 206);
            this.lblupload.Name = "lblupload";
            this.lblupload.Size = new System.Drawing.Size(0, 13);
            this.lblupload.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 199);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtfileupload
            // 
            this.txtfileupload.Location = new System.Drawing.Point(120, 43);
            this.txtfileupload.Name = "txtfileupload";
            this.txtfileupload.Size = new System.Drawing.Size(251, 20);
            this.txtfileupload.TabIndex = 5;
            // 
            // btnsheet
            // 
            this.btnsheet.Location = new System.Drawing.Point(21, 83);
            this.btnsheet.Name = "btnsheet";
            this.btnsheet.Size = new System.Drawing.Size(75, 23);
            this.btnsheet.TabIndex = 6;
            this.btnsheet.Text = "Load Sheet";
            this.btnsheet.UseVisualStyleBackColor = true;
            this.btnsheet.Click += new System.EventHandler(this.btnsheet_Click);
            // 
            // txtsheet
            // 
            this.txtsheet.Location = new System.Drawing.Point(120, 83);
            this.txtsheet.Name = "txtsheet";
            this.txtsheet.Size = new System.Drawing.Size(251, 20);
            this.txtsheet.TabIndex = 7;
            this.txtsheet.Text = "sheet1";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Location = new System.Drawing.Point(303, 34);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(0, 13);
            this.lblcode.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsheet);
            this.groupBox1.Controls.Add(this.btnupload);
            this.groupBox1.Controls.Add(this.txtfileupload);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnsheet);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 366);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Database File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbarcode);
            this.groupBox2.Controls.Add(this.lblbarcode);
            this.groupBox2.Location = new System.Drawing.Point(473, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 66);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Functions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP Address :";
            // 
            // txtipaddress
            // 
            this.txtipaddress.Location = new System.Drawing.Point(75, 31);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(135, 20);
            this.txtipaddress.TabIndex = 13;
            this.txtipaddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port :";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(275, 31);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(77, 20);
            this.txtport.TabIndex = 13;
            this.txtport.Text = "8900";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisconnect);
            this.groupBox3.Controls.Add(this.btnconnect);
            this.groupBox3.Controls.Add(this.btnping);
            this.groupBox3.Controls.Add(this.txtipaddress);
            this.groupBox3.Controls.Add(this.txtport);
            this.groupBox3.Controls.Add(this.lblcode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(473, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 103);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect To Printer";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnDisconnect.Location = new System.Drawing.Point(275, 61);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(176, 61);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 14;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnping
            // 
            this.btnping.Location = new System.Drawing.Point(75, 61);
            this.btnping.Name = "btnping";
            this.btnping.Size = new System.Drawing.Size(75, 23);
            this.btnping.TabIndex = 14;
            this.btnping.Text = "Ping";
            this.btnping.UseVisualStyleBackColor = true;
            this.btnping.Click += new System.EventHandler(this.btnping_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(473, 225);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtstatus.Size = new System.Drawing.Size(352, 95);
            this.txtstatus.TabIndex = 0;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(750, 377);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(473, 337);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(352, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblupload);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Demo App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtipaddress;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnping;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDisconnect;
    }
}