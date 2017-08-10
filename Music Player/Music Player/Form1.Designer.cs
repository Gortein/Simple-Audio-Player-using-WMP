namespace Music_Player
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
            this.components = new System.ComponentModel.Container();
            this.songSelect = new System.Windows.Forms.Button();
            this.songPlay = new System.Windows.Forms.Button();
            this.songPause = new System.Windows.Forms.Button();
            this.songCurrent = new System.Windows.Forms.Label();
            this.songVolume = new System.Windows.Forms.Label();
            this.songVolSelect = new System.Windows.Forms.TrackBar();
            this.songProgress = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.songRepeat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.songVolSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // songSelect
            // 
            this.songSelect.Location = new System.Drawing.Point(264, 226);
            this.songSelect.Name = "songSelect";
            this.songSelect.Size = new System.Drawing.Size(75, 23);
            this.songSelect.TabIndex = 1;
            this.songSelect.Text = "Select Song";
            this.songSelect.UseVisualStyleBackColor = true;
            this.songSelect.Click += new System.EventHandler(this.songSelect_Click);
            // 
            // songPlay
            // 
            this.songPlay.Location = new System.Drawing.Point(385, 226);
            this.songPlay.Name = "songPlay";
            this.songPlay.Size = new System.Drawing.Size(75, 23);
            this.songPlay.TabIndex = 2;
            this.songPlay.Text = "Play";
            this.songPlay.UseVisualStyleBackColor = true;
            this.songPlay.Click += new System.EventHandler(this.songPlay_Click);
            // 
            // songPause
            // 
            this.songPause.Location = new System.Drawing.Point(506, 226);
            this.songPause.Name = "songPause";
            this.songPause.Size = new System.Drawing.Size(75, 23);
            this.songPause.TabIndex = 3;
            this.songPause.Text = "Pause";
            this.songPause.UseVisualStyleBackColor = true;
            this.songPause.Click += new System.EventHandler(this.songPause_Click);
            // 
            // songCurrent
            // 
            this.songCurrent.Location = new System.Drawing.Point(12, 91);
            this.songCurrent.Name = "songCurrent";
            this.songCurrent.Size = new System.Drawing.Size(820, 20);
            this.songCurrent.TabIndex = 4;
            this.songCurrent.Text = "No Song is Playing!";
            this.songCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songVolume
            // 
            this.songVolume.Location = new System.Drawing.Point(372, 285);
            this.songVolume.Name = "songVolume";
            this.songVolume.Size = new System.Drawing.Size(100, 23);
            this.songVolume.TabIndex = 5;
            this.songVolume.Text = "Volume: 50%";
            this.songVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songVolSelect
            // 
            this.songVolSelect.Location = new System.Drawing.Point(264, 330);
            this.songVolSelect.Name = "songVolSelect";
            this.songVolSelect.Size = new System.Drawing.Size(317, 45);
            this.songVolSelect.TabIndex = 6;
            this.songVolSelect.TickFrequency = 10;
            this.songVolSelect.Scroll += new System.EventHandler(this.songVolSelect_Scroll);
            // 
            // songProgress
            // 
            this.songProgress.Location = new System.Drawing.Point(264, 146);
            this.songProgress.Name = "songProgress";
            this.songProgress.Size = new System.Drawing.Size(317, 45);
            this.songProgress.TabIndex = 7;
            this.songProgress.TickFrequency = 0;
            this.songProgress.Scroll += new System.EventHandler(this.songProgress_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // songRepeat
            // 
            this.songRepeat.AutoSize = true;
            this.songRepeat.Location = new System.Drawing.Point(392, 184);
            this.songRepeat.Name = "songRepeat";
            this.songRepeat.Size = new System.Drawing.Size(61, 17);
            this.songRepeat.TabIndex = 9;
            this.songRepeat.Text = "Repeat";
            this.songRepeat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 474);
            this.Controls.Add(this.songRepeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.songProgress);
            this.Controls.Add(this.songVolSelect);
            this.Controls.Add(this.songVolume);
            this.Controls.Add(this.songCurrent);
            this.Controls.Add(this.songPause);
            this.Controls.Add(this.songPlay);
            this.Controls.Add(this.songSelect);
            this.Name = "Form1";
            this.Text = "Simple Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.songVolSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button songSelect;
        private System.Windows.Forms.Button songPlay;
        private System.Windows.Forms.Button songPause;
        private System.Windows.Forms.Label songCurrent;
        private System.Windows.Forms.Label songVolume;
        private System.Windows.Forms.TrackBar songVolSelect;
        private System.Windows.Forms.TrackBar songProgress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox songRepeat;
    }
}

