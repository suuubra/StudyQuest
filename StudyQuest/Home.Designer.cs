namespace StudyQuest
{
    partial class Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelExport = new System.Windows.Forms.LinkLabel();
            this.linkLabelImport = new System.Windows.Forms.LinkLabel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.linkLabel2);
            this.panelMenu.Controls.Add(this.linkLabelExport);
            this.panelMenu.Controls.Add(this.linkLabelImport);
            this.panelMenu.Location = new System.Drawing.Point(82, 274);
            this.panelMenu.MaximumSize = new System.Drawing.Size(424, 470);
            this.panelMenu.MinimumSize = new System.Drawing.Size(424, 470);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(75);
            this.panelMenu.Size = new System.Drawing.Size(424, 470);
            this.panelMenu.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Heavitas", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linkLabel2.Location = new System.Drawing.Point(94, 229);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(236, 77);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Stats";
            // 
            // linkLabelExport
            // 
            this.linkLabelExport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.linkLabelExport.AutoSize = true;
            this.linkLabelExport.Font = new System.Drawing.Font("Heavitas", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelExport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelExport.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linkLabelExport.Location = new System.Drawing.Point(78, 152);
            this.linkLabelExport.Name = "linkLabelExport";
            this.linkLabelExport.Size = new System.Drawing.Size(289, 77);
            this.linkLabelExport.TabIndex = 2;
            this.linkLabelExport.TabStop = true;
            this.linkLabelExport.Text = "Export";
            // 
            // linkLabelImport
            // 
            this.linkLabelImport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.linkLabelImport.AutoSize = true;
            this.linkLabelImport.Font = new System.Drawing.Font("Heavitas", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelImport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelImport.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linkLabelImport.Location = new System.Drawing.Point(78, 75);
            this.linkLabelImport.Name = "linkLabelImport";
            this.linkLabelImport.Size = new System.Drawing.Size(282, 77);
            this.linkLabelImport.TabIndex = 1;
            this.linkLabelImport.TabStop = true;
            this.linkLabelImport.Text = "Import";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabelExport;
        private LinkLabel linkLabelImport;
    }
}