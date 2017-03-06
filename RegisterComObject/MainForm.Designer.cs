namespace RegisterComObject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtDllPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForRegasm = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegasmPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDllInfo = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblInvalidRegasmPath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDllPath
            // 
            this.txtDllPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDllPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDllPath.Location = new System.Drawing.Point(16, 29);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.Size = new System.Drawing.Size(918, 20);
            this.txtDllPath.TabIndex = 1;
            this.txtDllPath.TextChanged += new System.EventHandler(this.txtDllPath_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Dll files|*.dll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your dll path to register";
            // 
            // labelForRegasm
            // 
            this.labelForRegasm.AutoSize = true;
            this.labelForRegasm.Location = new System.Drawing.Point(13, 116);
            this.labelForRegasm.Name = "labelForRegasm";
            this.labelForRegasm.Size = new System.Drawing.Size(79, 13);
            this.labelForRegasm.TabIndex = 7;
            this.labelForRegasm.Text = "Regasm path->";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(483, 215);
            this.txtLog.TabIndex = 9;
            this.txtLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInvalidRegasmPath);
            this.panel1.Controls.Add(this.lblPlatform);
            this.panel1.Controls.Add(this.txtRegasmPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDllPath);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.labelForRegasm);
            this.panel1.Controls.Add(this.btnUnregister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 144);
            this.panel1.TabIndex = 10;
            // 
            // txtRegasmPath
            // 
            this.txtRegasmPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegasmPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegasmPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegasmPath.Location = new System.Drawing.Point(146, 117);
            this.txtRegasmPath.Name = "txtRegasmPath";
            this.txtRegasmPath.Size = new System.Drawing.Size(867, 13);
            this.txtRegasmPath.TabIndex = 9;
            this.txtRegasmPath.TextChanged += new System.EventHandler(this.txtRegasmPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatAppearance.BorderSize = 2;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Image = global::RegisterComObject.Properties.Resources._1488477758_Magnifier;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(940, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Image = global::RegisterComObject.Properties.Resources._1488477875_play_circle_outline;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(16, 55);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 48);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register Com Object";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUnregister
            // 
            this.btnUnregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnregister.Enabled = false;
            this.btnUnregister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUnregister.FlatAppearance.BorderSize = 2;
            this.btnUnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnregister.Image = global::RegisterComObject.Properties.Resources._1488477880_stop;
            this.btnUnregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnregister.Location = new System.Drawing.Point(178, 55);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(147, 48);
            this.btnUnregister.TabIndex = 5;
            this.btnUnregister.Text = "Unregister Com Object";
            this.btnUnregister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 234);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDllInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 234);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dll Info";
            // 
            // txtDllInfo
            // 
            this.txtDllInfo.BackColor = System.Drawing.Color.MintCream;
            this.txtDllInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDllInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDllInfo.Location = new System.Drawing.Point(3, 16);
            this.txtDllInfo.Name = "txtDllInfo";
            this.txtDllInfo.ReadOnly = true;
            this.txtDllInfo.Size = new System.Drawing.Size(535, 215);
            this.txtDllInfo.TabIndex = 9;
            this.txtDllInfo.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 163);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 234);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 14;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlatform.ForeColor = System.Drawing.Color.Navy;
            this.lblPlatform.Location = new System.Drawing.Point(90, 116);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(37, 15);
            this.lblPlatform.TabIndex = 10;
            this.lblPlatform.Text = "32bit";
            // 
            // lblInvalidRegasmPath
            // 
            this.lblInvalidRegasmPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvalidRegasmPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInvalidRegasmPath.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidRegasmPath.Location = new System.Drawing.Point(89, 112);
            this.lblInvalidRegasmPath.Name = "lblInvalidRegasmPath";
            this.lblInvalidRegasmPath.Size = new System.Drawing.Size(52, 23);
            this.lblInvalidRegasmPath.TabIndex = 11;
            this.lblInvalidRegasmPath.Text = "Invalid";
            this.lblInvalidRegasmPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInvalidRegasmPath.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 397);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COR: Com Object Registerer v1.0 (Net.4.6.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDllPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Label labelForRegasm;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegasmPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtDllInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblInvalidRegasmPath;
    }
}

