namespace App_mua_hang
{
    partial class MainAppForAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chatWC = new System.Windows.Forms.PictureBox();
            this.cusRecharge = new System.Windows.Forms.PictureBox();
            this.addAccount = new System.Windows.Forms.PictureBox();
            this.addMore = new System.Windows.Forms.PictureBox();
            this.viewMenu = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusRecharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chatWC);
            this.panel2.Controls.Add(this.cusRecharge);
            this.panel2.Controls.Add(this.addAccount);
            this.panel2.Controls.Add(this.addMore);
            this.panel2.Controls.Add(this.viewMenu);
            this.panel2.Location = new System.Drawing.Point(-3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 597);
            this.panel2.TabIndex = 1;
            // 
            // chatWC
            // 
            this.chatWC.Image = ((System.Drawing.Image)(resources.GetObject("chatWC.Image")));
            this.chatWC.Location = new System.Drawing.Point(4, 450);
            this.chatWC.Name = "chatWC";
            this.chatWC.Size = new System.Drawing.Size(72, 65);
            this.chatWC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chatWC.TabIndex = 5;
            this.chatWC.TabStop = false;
            // 
            // cusRecharge
            // 
            this.cusRecharge.Image = ((System.Drawing.Image)(resources.GetObject("cusRecharge.Image")));
            this.cusRecharge.Location = new System.Drawing.Point(4, 330);
            this.cusRecharge.Name = "cusRecharge";
            this.cusRecharge.Size = new System.Drawing.Size(72, 65);
            this.cusRecharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cusRecharge.TabIndex = 4;
            this.cusRecharge.TabStop = false;
            // 
            // addAccount
            // 
            this.addAccount.Image = ((System.Drawing.Image)(resources.GetObject("addAccount.Image")));
            this.addAccount.Location = new System.Drawing.Point(4, 217);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(72, 65);
            this.addAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addAccount.TabIndex = 4;
            this.addAccount.TabStop = false;
            // 
            // addMore
            // 
            this.addMore.Image = ((System.Drawing.Image)(resources.GetObject("addMore.Image")));
            this.addMore.Location = new System.Drawing.Point(4, 106);
            this.addMore.Name = "addMore";
            this.addMore.Size = new System.Drawing.Size(72, 65);
            this.addMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addMore.TabIndex = 4;
            this.addMore.TabStop = false;
            // 
            // viewMenu
            // 
            this.viewMenu.Image = ((System.Drawing.Image)(resources.GetObject("viewMenu.Image")));
            this.viewMenu.Location = new System.Drawing.Point(4, 0);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(72, 65);
            this.viewMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewMenu.TabIndex = 3;
            this.viewMenu.TabStop = false;
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(71, 57);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(177, 597);
            this.panelSlide.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainAppForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1128, 654);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainAppForAdmin";
            this.Text = "MainAppForAdmin";
            this.Load += new System.EventHandler(this.MainAppForAdmin_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chatWC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusRecharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.PictureBox chatWC;
        private System.Windows.Forms.PictureBox cusRecharge;
        private System.Windows.Forms.PictureBox addAccount;
        private System.Windows.Forms.PictureBox addMore;
        private System.Windows.Forms.PictureBox viewMenu;
        private System.Windows.Forms.Timer timer1;
    }
}