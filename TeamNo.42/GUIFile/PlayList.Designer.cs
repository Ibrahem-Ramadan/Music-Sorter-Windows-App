namespace GUIFile
{
    partial class PlayList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayList));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.Browse = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pause = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 78);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(43, 97);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(269, 48);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(43, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 10);
            this.panel1.TabIndex = 24;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play.Image = global::GUIFile.Properties.Resources.Circled_Play_48px;
            this.Play.ImageActive = null;
            this.Play.Location = new System.Drawing.Point(222, 38);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(90, 57);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play.TabIndex = 22;
            this.Play.TabStop = false;
            this.Play.Zoom = 10;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            this.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Browse.Image = global::GUIFile.Properties.Resources.Music_48px;
            this.Browse.ImageActive = null;
            this.Browse.Location = new System.Drawing.Point(43, 38);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(90, 57);
            this.Browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Browse.TabIndex = 19;
            this.Browse.TabStop = false;
            this.Browse.Zoom = 10;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pause.Image = global::GUIFile.Properties.Resources.Pause_48px;
            this.Pause.ImageActive = null;
            this.Pause.Location = new System.Drawing.Point(135, 38);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(90, 57);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 20;
            this.Pause.TabStop = false;
            this.Pause.Zoom = 10;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "PlayList";
            this.Size = new System.Drawing.Size(355, 209);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton Play;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuImageButton Pause;
        private Bunifu.Framework.UI.BunifuImageButton Browse;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
    }
}
