
namespace Car_Simulationcs
{
    partial class CarSimulationcs
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnGear1 = new System.Windows.Forms.Button();
            this.btnGear2 = new System.Windows.Forms.Button();
            this.btnGear3 = new System.Windows.Forms.Button();
            this.btnGear4 = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(180, 658);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(116, 39);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.BackColor = System.Drawing.Color.Lime;
            this.btnBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrake.Location = new System.Drawing.Point(312, 658);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(116, 39);
            this.btnBrake.TabIndex = 0;
            this.btnBrake.Text = "BRAKE";
            this.btnBrake.UseVisualStyleBackColor = false;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnGear1
            // 
            this.btnGear1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear1.Location = new System.Drawing.Point(446, 658);
            this.btnGear1.Name = "btnGear1";
            this.btnGear1.Size = new System.Drawing.Size(116, 39);
            this.btnGear1.TabIndex = 0;
            this.btnGear1.Text = "GEAR1";
            this.btnGear1.UseVisualStyleBackColor = false;
            this.btnGear1.Click += new System.EventHandler(this.btnGear1_Click);
            // 
            // btnGear2
            // 
            this.btnGear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear2.Location = new System.Drawing.Point(580, 658);
            this.btnGear2.Name = "btnGear2";
            this.btnGear2.Size = new System.Drawing.Size(116, 39);
            this.btnGear2.TabIndex = 0;
            this.btnGear2.Text = "GEAR2";
            this.btnGear2.UseVisualStyleBackColor = false;
            this.btnGear2.Click += new System.EventHandler(this.btnGear2_Click);
            // 
            // btnGear3
            // 
            this.btnGear3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear3.Location = new System.Drawing.Point(712, 658);
            this.btnGear3.Name = "btnGear3";
            this.btnGear3.Size = new System.Drawing.Size(116, 39);
            this.btnGear3.TabIndex = 0;
            this.btnGear3.Text = "GEAR3";
            this.btnGear3.UseVisualStyleBackColor = false;
            this.btnGear3.Click += new System.EventHandler(this.btnGear3_Click);
            // 
            // btnGear4
            // 
            this.btnGear4.BackColor = System.Drawing.Color.Red;
            this.btnGear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear4.Location = new System.Drawing.Point(844, 658);
            this.btnGear4.Name = "btnGear4";
            this.btnGear4.Size = new System.Drawing.Size(116, 39);
            this.btnGear4.TabIndex = 0;
            this.btnGear4.Text = "GEAR4";
            this.btnGear4.UseVisualStyleBackColor = false;
            this.btnGear4.Click += new System.EventHandler(this.btnGear4_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Purple;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(977, 658);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(130, 39);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "LAUNCH";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // Car1
            // 
            this.Car1.Image = global::RegistrationForm.Properties.Resources.Toyata_matrix0_removebg_preview;
            this.Car1.Location = new System.Drawing.Point(17, 491);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(181, 149);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 3;
            this.Car1.TabStop = false;
            // 
            // Car4
            // 
            this.Car4.Image = global::RegistrationForm.Properties.Resources.Toyota_Matrix2_removebg_preview;
            this.Car4.Location = new System.Drawing.Point(17, 12);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(147, 144);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 3;
            this.Car4.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::RegistrationForm.Properties.Resources.Toyota_Matrix3_removebg_preview;
            this.Car2.Location = new System.Drawing.Point(1118, 501);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(165, 139);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = global::RegistrationForm.Properties.Resources.Toyata_matrix1_removebg_preview;
            this.Car3.Location = new System.Drawing.Point(1085, 12);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(198, 144);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 1;
            this.Car3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // CarSimulationcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1308, 704);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnGear4);
            this.Controls.Add(this.btnGear2);
            this.Controls.Add(this.btnGear3);
            this.Controls.Add(this.btnGear1);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnPlay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CarSimulationcs";
            this.Text = "CarSimulationcs";
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnGear1;
        private System.Windows.Forms.Button btnGear2;
        private System.Windows.Forms.Button btnGear3;
        private System.Windows.Forms.Button btnGear4;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}