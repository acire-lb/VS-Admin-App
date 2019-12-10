namespace Dat602_ConnectFour
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Square1 = new System.Windows.Forms.PictureBox();
            this.Square5 = new System.Windows.Forms.PictureBox();
            this.Square9 = new System.Windows.Forms.PictureBox();
            this.Square13 = new System.Windows.Forms.PictureBox();
            this.Square2 = new System.Windows.Forms.PictureBox();
            this.Square3 = new System.Windows.Forms.PictureBox();
            this.Square4 = new System.Windows.Forms.PictureBox();
            this.Square6 = new System.Windows.Forms.PictureBox();
            this.Square7 = new System.Windows.Forms.PictureBox();
            this.Square8 = new System.Windows.Forms.PictureBox();
            this.Square10 = new System.Windows.Forms.PictureBox();
            this.Square11 = new System.Windows.Forms.PictureBox();
            this.Square12 = new System.Windows.Forms.PictureBox();
            this.Square14 = new System.Windows.Forms.PictureBox();
            this.Square15 = new System.Windows.Forms.PictureBox();
            this.Square16 = new System.Windows.Forms.PictureBox();
            this.tmGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Square1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square16)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(72, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOpponent
            // 
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(51, 27);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(275, 29);
            this.lblOpponent.TabIndex = 2;
            this.lblOpponent.Text = "Oponnent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "point: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "point: 0";
            // 
            // Square1
            // 
            this.Square1.Image = ((System.Drawing.Image)(resources.GetObject("Square1.Image")));
            this.Square1.Location = new System.Drawing.Point(72, 121);
            this.Square1.Name = "Square1";
            this.Square1.Size = new System.Drawing.Size(43, 41);
            this.Square1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square1.TabIndex = 8;
            this.Square1.TabStop = false;
            // 
            // Square5
            // 
            this.Square5.Image = ((System.Drawing.Image)(resources.GetObject("Square5.Image")));
            this.Square5.Location = new System.Drawing.Point(72, 168);
            this.Square5.Name = "Square5";
            this.Square5.Size = new System.Drawing.Size(43, 41);
            this.Square5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square5.TabIndex = 9;
            this.Square5.TabStop = false;
            // 
            // Square9
            // 
            this.Square9.Image = ((System.Drawing.Image)(resources.GetObject("Square9.Image")));
            this.Square9.Location = new System.Drawing.Point(72, 215);
            this.Square9.Name = "Square9";
            this.Square9.Size = new System.Drawing.Size(43, 41);
            this.Square9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square9.TabIndex = 10;
            this.Square9.TabStop = false;
            // 
            // Square13
            // 
            this.Square13.Image = ((System.Drawing.Image)(resources.GetObject("Square13.Image")));
            this.Square13.Location = new System.Drawing.Point(72, 262);
            this.Square13.Name = "Square13";
            this.Square13.Size = new System.Drawing.Size(43, 41);
            this.Square13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square13.TabIndex = 11;
            this.Square13.TabStop = false;
            // 
            // Square2
            // 
            this.Square2.Image = ((System.Drawing.Image)(resources.GetObject("Square2.Image")));
            this.Square2.Location = new System.Drawing.Point(121, 121);
            this.Square2.Name = "Square2";
            this.Square2.Size = new System.Drawing.Size(43, 41);
            this.Square2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square2.TabIndex = 14;
            this.Square2.TabStop = false;
            // 
            // Square3
            // 
            this.Square3.Image = ((System.Drawing.Image)(resources.GetObject("Square3.Image")));
            this.Square3.Location = new System.Drawing.Point(170, 121);
            this.Square3.Name = "Square3";
            this.Square3.Size = new System.Drawing.Size(43, 41);
            this.Square3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square3.TabIndex = 15;
            this.Square3.TabStop = false;
            // 
            // Square4
            // 
            this.Square4.Image = ((System.Drawing.Image)(resources.GetObject("Square4.Image")));
            this.Square4.Location = new System.Drawing.Point(219, 121);
            this.Square4.Name = "Square4";
            this.Square4.Size = new System.Drawing.Size(43, 41);
            this.Square4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square4.TabIndex = 16;
            this.Square4.TabStop = false;
            // 
            // Square6
            // 
            this.Square6.Image = ((System.Drawing.Image)(resources.GetObject("Square6.Image")));
            this.Square6.Location = new System.Drawing.Point(121, 168);
            this.Square6.Name = "Square6";
            this.Square6.Size = new System.Drawing.Size(43, 41);
            this.Square6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square6.TabIndex = 20;
            this.Square6.TabStop = false;
            // 
            // Square7
            // 
            this.Square7.Image = ((System.Drawing.Image)(resources.GetObject("Square7.Image")));
            this.Square7.Location = new System.Drawing.Point(170, 168);
            this.Square7.Name = "Square7";
            this.Square7.Size = new System.Drawing.Size(43, 41);
            this.Square7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square7.TabIndex = 21;
            this.Square7.TabStop = false;
            // 
            // Square8
            // 
            this.Square8.Image = ((System.Drawing.Image)(resources.GetObject("Square8.Image")));
            this.Square8.Location = new System.Drawing.Point(219, 168);
            this.Square8.Name = "Square8";
            this.Square8.Size = new System.Drawing.Size(43, 41);
            this.Square8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square8.TabIndex = 22;
            this.Square8.TabStop = false;
            // 
            // Square10
            // 
            this.Square10.Image = ((System.Drawing.Image)(resources.GetObject("Square10.Image")));
            this.Square10.Location = new System.Drawing.Point(121, 215);
            this.Square10.Name = "Square10";
            this.Square10.Size = new System.Drawing.Size(43, 41);
            this.Square10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square10.TabIndex = 26;
            this.Square10.TabStop = false;
            // 
            // Square11
            // 
            this.Square11.Image = ((System.Drawing.Image)(resources.GetObject("Square11.Image")));
            this.Square11.Location = new System.Drawing.Point(170, 215);
            this.Square11.Name = "Square11";
            this.Square11.Size = new System.Drawing.Size(43, 41);
            this.Square11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square11.TabIndex = 27;
            this.Square11.TabStop = false;
            // 
            // Square12
            // 
            this.Square12.Image = ((System.Drawing.Image)(resources.GetObject("Square12.Image")));
            this.Square12.Location = new System.Drawing.Point(219, 215);
            this.Square12.Name = "Square12";
            this.Square12.Size = new System.Drawing.Size(43, 41);
            this.Square12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square12.TabIndex = 28;
            this.Square12.TabStop = false;
            // 
            // Square14
            // 
            this.Square14.Image = ((System.Drawing.Image)(resources.GetObject("Square14.Image")));
            this.Square14.Location = new System.Drawing.Point(121, 262);
            this.Square14.Name = "Square14";
            this.Square14.Size = new System.Drawing.Size(43, 41);
            this.Square14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square14.TabIndex = 32;
            this.Square14.TabStop = false;
            // 
            // Square15
            // 
            this.Square15.Image = ((System.Drawing.Image)(resources.GetObject("Square15.Image")));
            this.Square15.Location = new System.Drawing.Point(170, 262);
            this.Square15.Name = "Square15";
            this.Square15.Size = new System.Drawing.Size(43, 41);
            this.Square15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square15.TabIndex = 33;
            this.Square15.TabStop = false;
            // 
            // Square16
            // 
            this.Square16.Image = ((System.Drawing.Image)(resources.GetObject("Square16.Image")));
            this.Square16.Location = new System.Drawing.Point(219, 262);
            this.Square16.Name = "Square16";
            this.Square16.Size = new System.Drawing.Size(43, 41);
            this.Square16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square16.TabIndex = 34;
            this.Square16.TabStop = false;
            // 
            // tmGameTimer
            // 
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 360);
            this.Controls.Add(this.Square16);
            this.Controls.Add(this.Square15);
            this.Controls.Add(this.Square14);
            this.Controls.Add(this.Square12);
            this.Controls.Add(this.Square11);
            this.Controls.Add(this.Square10);
            this.Controls.Add(this.Square8);
            this.Controls.Add(this.Square7);
            this.Controls.Add(this.Square6);
            this.Controls.Add(this.Square4);
            this.Controls.Add(this.Square3);
            this.Controls.Add(this.Square2);
            this.Controls.Add(this.Square13);
            this.Controls.Add(this.Square9);
            this.Controls.Add(this.Square5);
            this.Controls.Add(this.Square1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.btnExit);
            this.Name = "FrmGame";
            ((System.ComponentModel.ISupportInitialize)(this.Square1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Square1;
        private System.Windows.Forms.PictureBox Square5;
        private System.Windows.Forms.PictureBox Square9;
        private System.Windows.Forms.PictureBox Square13;
        private System.Windows.Forms.PictureBox Square2;
        private System.Windows.Forms.PictureBox Square3;
        private System.Windows.Forms.PictureBox Square4;
        private System.Windows.Forms.PictureBox Square6;
        private System.Windows.Forms.PictureBox Square7;
        private System.Windows.Forms.PictureBox Square8;
        private System.Windows.Forms.PictureBox Square10;
        private System.Windows.Forms.PictureBox Square11;
        private System.Windows.Forms.PictureBox Square12;
        private System.Windows.Forms.PictureBox Square14;
        private System.Windows.Forms.PictureBox Square15;
        private System.Windows.Forms.PictureBox Square16;
        private System.Windows.Forms.Timer tmGameTimer;
    }
}