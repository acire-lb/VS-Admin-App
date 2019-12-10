namespace Dat602_ConnectFour
{
   
    partial class FrmAdmin
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lstOnlinePlayers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnKillGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCurrentGames = new System.Windows.Forms.ListBox();
            this.tmAdminScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(14, 345);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 27);
            this.btnLogOut.TabIndex = 35;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lstOnlinePlayers
            // 
            this.lstOnlinePlayers.FormattingEnabled = true;
            this.lstOnlinePlayers.ItemHeight = 15;
            this.lstOnlinePlayers.Location = new System.Drawing.Point(14, 81);
            this.lstOnlinePlayers.Name = "lstOnlinePlayers";
            this.lstOnlinePlayers.ScrollAlwaysVisible = true;
            this.lstOnlinePlayers.Size = new System.Drawing.Size(424, 259);
            this.lstOnlinePlayers.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Connect4 Administration";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(748, 114);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(129, 27);
            this.btnRemovePlayer.TabIndex = 32;
            this.btnRemovePlayer.Text = "Remove  Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(748, 148);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(129, 27);
            this.btnUpdatePlayer.TabIndex = 31;
            this.btnUpdatePlayer.Text = "Update Player";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(748, 81);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(129, 27);
            this.btnAddPlayer.TabIndex = 30;
            this.btnAddPlayer.Text = "Add New Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnKillGame
            // 
            this.btnKillGame.Location = new System.Drawing.Point(748, 209);
            this.btnKillGame.Name = "btnKillGame";
            this.btnKillGame.Size = new System.Drawing.Size(129, 27);
            this.btnKillGame.TabIndex = 29;
            this.btnKillGame.Text = "Kill running games";
            this.btnKillGame.UseVisualStyleBackColor = true;
            this.btnKillGame.Click += new System.EventHandler(this.btnKillGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Current Players Online";
            // 
            // lstCurrentGames
            // 
            this.lstCurrentGames.FormattingEnabled = true;
            this.lstCurrentGames.ItemHeight = 15;
            this.lstCurrentGames.Location = new System.Drawing.Point(453, 81);
            this.lstCurrentGames.Name = "lstCurrentGames";
            this.lstCurrentGames.ScrollAlwaysVisible = true;
            this.lstCurrentGames.Size = new System.Drawing.Size(289, 259);
            this.lstCurrentGames.TabIndex = 36;
            // 
            // tmAdminScreenTimer
            // 
            this.tmAdminScreenTimer.Interval = 1000;
            this.tmAdminScreenTimer.Tick += new System.EventHandler(this.tmAdminScreenTimer_Tick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 385);
            this.Controls.Add(this.lstCurrentGames);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lstOnlinePlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnKillGame);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListBox lstOnlinePlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnKillGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCurrentGames;
        private System.Windows.Forms.Timer tmAdminScreenTimer;
    }
}