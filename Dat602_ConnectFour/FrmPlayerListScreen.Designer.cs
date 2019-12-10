namespace Dat602_ConnectFour
{
    partial class FrmPlayerListScreen
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
            this.label4 = new System.Windows.Forms.Label();
            this.lstOnlinePlayers = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tmPlayerScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Currently Online";
            // 
            // lstOnlinePlayers
            // 
            this.lstOnlinePlayers.FormattingEnabled = true;
            this.lstOnlinePlayers.Location = new System.Drawing.Point(53, 72);
            this.lstOnlinePlayers.Name = "lstOnlinePlayers";
            this.lstOnlinePlayers.ScrollAlwaysVisible = true;
            this.lstOnlinePlayers.Size = new System.Drawing.Size(342, 212);
            this.lstOnlinePlayers.TabIndex = 21;
            this.lstOnlinePlayers.SelectedIndexChanged += new System.EventHandler(this.lstOnlinePlayers_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(15, 306);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 23);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(257, 16);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerName.TabIndex = 23;
            // 
            // tmPlayerScreenTimer
            // 
            this.tmPlayerScreenTimer.Tick += new System.EventHandler(this.tmPlayerScreenTimer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(377, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FrmPlayerListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 341);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lstOnlinePlayers);
            this.Controls.Add(this.label4);
            this.Name = "FrmPlayerListScreen";
            this.Text = "PlayerView_CurrentPlayersOnline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstOnlinePlayers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Timer tmPlayerScreenTimer;
        private System.Windows.Forms.Button btnStart;
    }
}