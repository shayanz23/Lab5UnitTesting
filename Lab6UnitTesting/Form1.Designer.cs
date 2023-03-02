namespace Lab6UnitTesting
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
            this.btn_l_sound = new System.Windows.Forms.Button();
            this.btn_b_sound = new System.Windows.Forms.Button();
            this.btn_play_mediaPlayer = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Sounds Together";
            // 
            // btn_l_sound
            // 
            this.btn_l_sound.Location = new System.Drawing.Point(657, 924);
            this.btn_l_sound.Name = "btn_l_sound";
            this.btn_l_sound.Size = new System.Drawing.Size(247, 194);
            this.btn_l_sound.TabIndex = 1;
            this.btn_l_sound.Text = "PlayLSound";
            this.btn_l_sound.UseVisualStyleBackColor = true;
            // 
            // btn_b_sound
            // 
            this.btn_b_sound.Location = new System.Drawing.Point(171, 924);
            this.btn_b_sound.Name = "btn_b_sound";
            this.btn_b_sound.Size = new System.Drawing.Size(247, 194);
            this.btn_b_sound.TabIndex = 2;
            this.btn_b_sound.Text = "PlayBMusic";
            this.btn_b_sound.UseVisualStyleBackColor = true;
            this.btn_b_sound.Click += new System.EventHandler(this.PlayBSound);
            // 
            // btn_play_mediaPlayer
            // 
            this.btn_play_mediaPlayer.Location = new System.Drawing.Point(1167, 924);
            this.btn_play_mediaPlayer.Name = "btn_play_mediaPlayer";
            this.btn_play_mediaPlayer.Size = new System.Drawing.Size(247, 194);
            this.btn_play_mediaPlayer.TabIndex = 3;
            this.btn_play_mediaPlayer.Text = "MediaPlayer";
            this.btn_play_mediaPlayer.UseVisualStyleBackColor = true;
            this.btn_play_mediaPlayer.Click += new System.EventHandler(this.PlayMediaPlayer);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(407, 266);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(756, 432);
            this.WMP.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 1151);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.btn_play_mediaPlayer);
            this.Controls.Add(this.btn_b_sound);
            this.Controls.Add(this.btn_l_sound);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PlaySound";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.PlayLSound);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_l_sound;
        private System.Windows.Forms.Button btn_b_sound;
        private System.Windows.Forms.Button btn_play_mediaPlayer;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}