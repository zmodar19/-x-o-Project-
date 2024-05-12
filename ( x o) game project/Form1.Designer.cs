namespace __x_o__game_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn1player = new Guna.UI2.WinForms.Guna2Button();
            this.btn2player = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(124, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 166);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1player
            // 
            this.btn1player.Animated = true;
            this.btn1player.BackColor = System.Drawing.Color.Transparent;
            this.btn1player.BorderRadius = 36;
            this.btn1player.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn1player.BorderThickness = 3;
            this.btn1player.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1player.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1player.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1player.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1player.FillColor = System.Drawing.Color.Transparent;
            this.btn1player.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.btn1player.ForeColor = System.Drawing.Color.Transparent;
            this.btn1player.Location = new System.Drawing.Point(582, 63);
            this.btn1player.Name = "btn1player";
            this.btn1player.ShadowDecoration.BorderRadius = 36;
            this.btn1player.ShadowDecoration.Color = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1player.ShadowDecoration.Enabled = true;
            this.btn1player.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn1player.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btn1player.Size = new System.Drawing.Size(366, 200);
            this.btn1player.TabIndex = 5;
            this.btn1player.Text = "1 Player ";
            this.btn1player.Click += new System.EventHandler(this.btn1player_Click);
            // 
            // btn2player
            // 
            this.btn2player.Animated = true;
            this.btn2player.BackColor = System.Drawing.Color.Transparent;
            this.btn2player.BorderRadius = 36;
            this.btn2player.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn2player.BorderThickness = 3;
            this.btn2player.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2player.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2player.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2player.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2player.FillColor = System.Drawing.Color.Transparent;
            this.btn2player.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.btn2player.ForeColor = System.Drawing.Color.Transparent;
            this.btn2player.Location = new System.Drawing.Point(582, 289);
            this.btn2player.Name = "btn2player";
            this.btn2player.ShadowDecoration.BorderRadius = 0;
            this.btn2player.ShadowDecoration.Color = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2player.ShadowDecoration.Enabled = true;
            this.btn2player.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn2player.Size = new System.Drawing.Size(366, 200);
            this.btn2player.TabIndex = 6;
            this.btn2player.Text = "2 Players";
            this.btn2player.Click += new System.EventHandler(this.btn2player_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Animated = true;
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.BorderRadius = 80;
            this.btnexit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnexit.BorderThickness = 8;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(582, 539);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.BorderRadius = 0;
            this.btnexit.ShadowDecoration.Color = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.ShadowDecoration.Enabled = true;
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(366, 161);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit ";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(124, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 166);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(275, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 166);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tac ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn2player);
            this.Controls.Add(this.btn1player);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn1player;
        private Guna.UI2.WinForms.Guna2Button btn2player;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

