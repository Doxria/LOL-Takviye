
namespace AramBoost
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Aktif = new System.Windows.Forms.Button();
            this.HeadUstPanel = new System.Windows.Forms.Panel();
            this.website = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KapatTxtBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadUstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aktif
            // 
            this.Aktif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Aktif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aktif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.Aktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aktif.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.Aktif.Location = new System.Drawing.Point(12, 29);
            this.Aktif.Name = "Aktif";
            this.Aktif.Size = new System.Drawing.Size(133, 40);
            this.Aktif.TabIndex = 0;
            this.Aktif.Text = "Takviye";
            this.Aktif.UseVisualStyleBackColor = false;
            this.Aktif.Click += new System.EventHandler(this.AktifBtnTikla);
            // 
            // HeadUstPanel
            // 
            this.HeadUstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HeadUstPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeadUstPanel.BackgroundImage")));
            this.HeadUstPanel.Controls.Add(this.website);
            this.HeadUstPanel.Controls.Add(this.label2);
            this.HeadUstPanel.Controls.Add(this.KapatTxtBtn);
            this.HeadUstPanel.Controls.Add(this.label1);
            this.HeadUstPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.HeadUstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadUstPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadUstPanel.Name = "HeadUstPanel";
            this.HeadUstPanel.Size = new System.Drawing.Size(157, 20);
            this.HeadUstPanel.TabIndex = 1;
            this.HeadUstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseDown);
            this.HeadUstPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseMove);
            this.HeadUstPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseUp);
            // 
            // website
            // 
            this.website.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.website.AutoSize = true;
            this.website.BackColor = System.Drawing.Color.Transparent;
            this.website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.website.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.ForeColor = System.Drawing.Color.Snow;
            this.website.Location = new System.Drawing.Point(105, 4);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(13, 13);
            this.website.TabIndex = 4;
            this.website.Text = "?";
            this.website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.website.Click += new System.EventHandler(this.website_Tıkla);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(122, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.MinimizeTxtBtn_Tıkla);
            // 
            // KapatTxtBtn
            // 
            this.KapatTxtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatTxtBtn.AutoSize = true;
            this.KapatTxtBtn.BackColor = System.Drawing.Color.Transparent;
            this.KapatTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapatTxtBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KapatTxtBtn.ForeColor = System.Drawing.Color.Crimson;
            this.KapatTxtBtn.Location = new System.Drawing.Point(140, 3);
            this.KapatTxtBtn.Name = "KapatTxtBtn";
            this.KapatTxtBtn.Size = new System.Drawing.Size(14, 15);
            this.KapatTxtBtn.TabIndex = 2;
            this.KapatTxtBtn.Text = "X";
            this.KapatTxtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KapatTxtBtn.Click += new System.EventHandler(this.KapatTxtBtn_Tıkla);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOL - Takviye";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(157, 78);
            this.Controls.Add(this.HeadUstPanel);
            this.Controls.Add(this.Aktif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doxria Aram Boost";
            this.HeadUstPanel.ResumeLayout(false);
            this.HeadUstPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aktif;
        private System.Windows.Forms.Panel HeadUstPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KapatTxtBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label website;
    }
}

