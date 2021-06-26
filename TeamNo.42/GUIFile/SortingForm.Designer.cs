namespace GUIFile
{
    partial class SortingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingForm));
            this.HeaderFormSorting = new System.Windows.Forms.Panel();
            this.LabelBrowseForm = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SortingListBox = new System.Windows.Forms.CheckedListBox();
            this.PlayBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OpenFolderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StartSroting = new Bunifu.Framework.UI.BunifuImageButton();
            this.BackBrowseForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitButtonSortingForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.playList1 = new GUIFile.PlayList();
            this.HeaderFormSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartSroting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBrowseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonSortingForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderFormSorting
            // 
            this.HeaderFormSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.HeaderFormSorting.Controls.Add(this.BackBrowseForm);
            this.HeaderFormSorting.Controls.Add(this.ExitButtonSortingForm);
            this.HeaderFormSorting.Controls.Add(this.bunifuImageButton1);
            this.HeaderFormSorting.Controls.Add(this.LabelBrowseForm);
            this.HeaderFormSorting.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderFormSorting.Location = new System.Drawing.Point(0, 0);
            this.HeaderFormSorting.Name = "HeaderFormSorting";
            this.HeaderFormSorting.Size = new System.Drawing.Size(775, 37);
            this.HeaderFormSorting.TabIndex = 3;
            // 
            // LabelBrowseForm
            // 
            this.LabelBrowseForm.AutoSize = true;
            this.LabelBrowseForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBrowseForm.ForeColor = System.Drawing.Color.White;
            this.LabelBrowseForm.Location = new System.Drawing.Point(40, 9);
            this.LabelBrowseForm.Name = "LabelBrowseForm";
            this.LabelBrowseForm.Size = new System.Drawing.Size(130, 16);
            this.LabelBrowseForm.TabIndex = 4;
            this.LabelBrowseForm.Text = "M u s i c  S o r t e r";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.HeaderFormSorting;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(96, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Sorting";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SortingListBox
            // 
            this.SortingListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.SortingListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortingListBox.CheckOnClick = true;
            this.SortingListBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortingListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.SortingListBox.FormattingEnabled = true;
            this.SortingListBox.Items.AddRange(new object[] {
            "Album",
            "Artist",
            "Duration",
            "Genre",
            "Title",
            "Year"});
            this.SortingListBox.Location = new System.Drawing.Point(229, 82);
            this.SortingListBox.Name = "SortingListBox";
            this.SortingListBox.Size = new System.Drawing.Size(128, 168);
            this.SortingListBox.Sorted = true;
            this.SortingListBox.TabIndex = 4;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.PlayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.BorderRadius = 0;
            this.PlayBtn.ButtonText = "  Mp3  Player";
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.PlayBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PlayBtn.Iconimage = global::GUIFile.Properties.Resources.Windows_Media_Player_alt;
            this.PlayBtn.Iconimage_right = null;
            this.PlayBtn.Iconimage_right_Selected = null;
            this.PlayBtn.Iconimage_Selected = null;
            this.PlayBtn.IconMarginLeft = 0;
            this.PlayBtn.IconMarginRight = 0;
            this.PlayBtn.IconRightVisible = true;
            this.PlayBtn.IconRightZoom = 0D;
            this.PlayBtn.IconVisible = true;
            this.PlayBtn.IconZoom = 90D;
            this.PlayBtn.IsTab = false;
            this.PlayBtn.Location = new System.Drawing.Point(422, 184);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.PlayBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.PlayBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayBtn.selected = false;
            this.PlayBtn.Size = new System.Drawing.Size(241, 48);
            this.PlayBtn.TabIndex = 19;
            this.PlayBtn.Text = "  Mp3  Player";
            this.PlayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayBtn.Textcolor = System.Drawing.Color.White;
            this.PlayBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // OpenFolderBtn
            // 
            this.OpenFolderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.OpenFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.OpenFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFolderBtn.BorderRadius = 0;
            this.OpenFolderBtn.ButtonText = " Show  Sorted  Folder";
            this.OpenFolderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolderBtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.OpenFolderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OpenFolderBtn.Iconimage = global::GUIFile.Properties.Resources.Open_Folder_50;
            this.OpenFolderBtn.Iconimage_right = null;
            this.OpenFolderBtn.Iconimage_right_Selected = null;
            this.OpenFolderBtn.Iconimage_Selected = null;
            this.OpenFolderBtn.IconMarginLeft = 0;
            this.OpenFolderBtn.IconMarginRight = 0;
            this.OpenFolderBtn.IconRightVisible = true;
            this.OpenFolderBtn.IconRightZoom = 0D;
            this.OpenFolderBtn.IconVisible = true;
            this.OpenFolderBtn.IconZoom = 90D;
            this.OpenFolderBtn.IsTab = false;
            this.OpenFolderBtn.Location = new System.Drawing.Point(422, 82);
            this.OpenFolderBtn.Name = "OpenFolderBtn";
            this.OpenFolderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.OpenFolderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.OpenFolderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenFolderBtn.selected = false;
            this.OpenFolderBtn.Size = new System.Drawing.Size(241, 48);
            this.OpenFolderBtn.TabIndex = 18;
            this.OpenFolderBtn.Text = " Show  Sorted  Folder";
            this.OpenFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFolderBtn.Textcolor = System.Drawing.Color.White;
            this.OpenFolderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // StartSroting
            // 
            this.StartSroting.BackColor = System.Drawing.Color.Transparent;
            this.StartSroting.Image = global::GUIFile.Properties.Resources.Button;
            this.StartSroting.ImageActive = null;
            this.StartSroting.Location = new System.Drawing.Point(43, 82);
            this.StartSroting.Name = "StartSroting";
            this.StartSroting.Size = new System.Drawing.Size(170, 133);
            this.StartSroting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartSroting.TabIndex = 5;
            this.StartSroting.TabStop = false;
            this.StartSroting.Zoom = 10;
            this.StartSroting.Click += new System.EventHandler(this.StartSroting_Click);
            // 
            // BackBrowseForm
            // 
            this.BackBrowseForm.BackColor = System.Drawing.Color.Transparent;
            this.BackBrowseForm.Image = global::GUIFile.Properties.Resources.Circled_Left_48px;
            this.BackBrowseForm.ImageActive = null;
            this.BackBrowseForm.Location = new System.Drawing.Point(705, 5);
            this.BackBrowseForm.Name = "BackBrowseForm";
            this.BackBrowseForm.Size = new System.Drawing.Size(28, 30);
            this.BackBrowseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBrowseForm.TabIndex = 10;
            this.BackBrowseForm.TabStop = false;
            this.BackBrowseForm.Zoom = 10;
            this.BackBrowseForm.Click += new System.EventHandler(this.BackBrowseForm_Click);
            // 
            // ExitButtonSortingForm
            // 
            this.ExitButtonSortingForm.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonSortingForm.Image = global::GUIFile.Properties.Resources.sss;
            this.ExitButtonSortingForm.ImageActive = null;
            this.ExitButtonSortingForm.Location = new System.Drawing.Point(737, 6);
            this.ExitButtonSortingForm.Name = "ExitButtonSortingForm";
            this.ExitButtonSortingForm.Size = new System.Drawing.Size(26, 27);
            this.ExitButtonSortingForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButtonSortingForm.TabIndex = 10;
            this.ExitButtonSortingForm.TabStop = false;
            this.ExitButtonSortingForm.Zoom = 10;
            this.ExitButtonSortingForm.Click += new System.EventHandler(this.ExitButtonSortingForm_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::GUIFile.Properties.Resources.Music_48px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::GUIFile.Properties.Resources.rrrr;
            this.pictureBox6.Location = new System.Drawing.Point(295, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(490, 301);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // playList1
            // 
            this.playList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.playList1.Location = new System.Drawing.Point(363, 70);
            this.playList1.Name = "playList1";
            this.playList1.Size = new System.Drawing.Size(355, 234);
            this.playList1.TabIndex = 17;
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.OpenFolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortingListBox);
            this.Controls.Add(this.StartSroting);
            this.Controls.Add(this.HeaderFormSorting);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.playList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortingForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortingForm";
            this.Load += new System.EventHandler(this.SortingForm_Load);
            this.HeaderFormSorting.ResumeLayout(false);
            this.HeaderFormSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartSroting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBrowseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonSortingForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderFormSorting;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label LabelBrowseForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton ExitButtonSortingForm;
        private Bunifu.Framework.UI.BunifuImageButton BackBrowseForm;
        private Bunifu.Framework.UI.BunifuImageButton StartSroting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PlayList playList1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckedListBox SortingListBox;
        private Bunifu.Framework.UI.BunifuFlatButton PlayBtn;
        private Bunifu.Framework.UI.BunifuFlatButton OpenFolderBtn;

    }
}