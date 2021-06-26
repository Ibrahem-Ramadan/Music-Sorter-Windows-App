namespace GUIFile
{
    partial class BrowseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HeaderFormBrowse = new System.Windows.Forms.Panel();
            this.Definedestination = new Bunifu.Framework.UI.BunifuImageButton();
            this.NextSort = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.LabelBrowseForm = new System.Windows.Forms.Label();
            this.ExitButtonBrowseForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RadioArtist = new System.Windows.Forms.RadioButton();
            this.RadioTitle = new System.Windows.Forms.RadioButton();
            this.RadioAlbum = new System.Windows.Forms.RadioButton();
            this.RadioYear = new System.Windows.Forms.RadioButton();
            this.RadioGeneric = new System.Windows.Forms.RadioButton();
            this.BrowseComboBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.RadioDuration = new System.Windows.Forms.RadioButton();
            this.RadioD1 = new System.Windows.Forms.RadioButton();
            this.RadioD2 = new System.Windows.Forms.RadioButton();
            this.RadioD3 = new System.Windows.Forms.RadioButton();
            this.ContainerDuartion = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Location = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderFormBrowse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Definedestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonBrowseForm)).BeginInit();
            this.ContainerDuartion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // HeaderFormBrowse
            // 
            this.HeaderFormBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.HeaderFormBrowse.Controls.Add(this.Definedestination);
            this.HeaderFormBrowse.Controls.Add(this.NextSort);
            this.HeaderFormBrowse.Controls.Add(this.bunifuImageButton1);
            this.HeaderFormBrowse.Controls.Add(this.LabelBrowseForm);
            this.HeaderFormBrowse.Controls.Add(this.ExitButtonBrowseForm);
            this.HeaderFormBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderFormBrowse.Location = new System.Drawing.Point(0, 0);
            this.HeaderFormBrowse.Name = "HeaderFormBrowse";
            this.HeaderFormBrowse.Size = new System.Drawing.Size(775, 37);
            this.HeaderFormBrowse.TabIndex = 2;
            // 
            // Definedestination
            // 
            this.Definedestination.BackColor = System.Drawing.Color.Transparent;
            this.Definedestination.Image = global::GUIFile.Properties.Resources.Save_Archive_48px;
            this.Definedestination.ImageActive = null;
            this.Definedestination.Location = new System.Drawing.Point(661, 7);
            this.Definedestination.Name = "Definedestination";
            this.Definedestination.Size = new System.Drawing.Size(36, 24);
            this.Definedestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Definedestination.TabIndex = 16;
            this.Definedestination.TabStop = false;
            this.Definedestination.Zoom = 10;
            this.Definedestination.Click += new System.EventHandler(this.Definedestination_Click);
            this.Definedestination.MouseEnter += new System.EventHandler(this.Definedestination_MouseEnter);
            this.Definedestination.MouseLeave += new System.EventHandler(this.Definedestination_MouseLeave);
            // 
            // NextSort
            // 
            this.NextSort.BackColor = System.Drawing.Color.Transparent;
            this.NextSort.Image = global::GUIFile.Properties.Resources.Circled_Right_48px;
            this.NextSort.ImageActive = null;
            this.NextSort.Location = new System.Drawing.Point(703, 3);
            this.NextSort.Name = "NextSort";
            this.NextSort.Size = new System.Drawing.Size(28, 30);
            this.NextSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextSort.TabIndex = 9;
            this.NextSort.TabStop = false;
            this.NextSort.Zoom = 10;
            this.NextSort.Click += new System.EventHandler(this.NextSort_Click);
            this.NextSort.MouseEnter += new System.EventHandler(this.NextSort_MouseEnter);
            this.NextSort.MouseLeave += new System.EventHandler(this.NextSort_MouseLeave);
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
            // ExitButtonBrowseForm
            // 
            this.ExitButtonBrowseForm.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonBrowseForm.Image = global::GUIFile.Properties.Resources.sss;
            this.ExitButtonBrowseForm.ImageActive = null;
            this.ExitButtonBrowseForm.Location = new System.Drawing.Point(737, 4);
            this.ExitButtonBrowseForm.Name = "ExitButtonBrowseForm";
            this.ExitButtonBrowseForm.Size = new System.Drawing.Size(26, 27);
            this.ExitButtonBrowseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButtonBrowseForm.TabIndex = 3;
            this.ExitButtonBrowseForm.TabStop = false;
            this.ExitButtonBrowseForm.Zoom = 10;
            this.ExitButtonBrowseForm.Click += new System.EventHandler(this.ExitButtonBrowseForm_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.HeaderFormBrowse;
            this.bunifuDragControl2.Vertical = true;
            // 
            // RadioArtist
            // 
            this.RadioArtist.AutoSize = true;
            this.RadioArtist.BackColor = System.Drawing.Color.Transparent;
            this.RadioArtist.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioArtist.ForeColor = System.Drawing.Color.White;
            this.RadioArtist.Location = new System.Drawing.Point(124, 199);
            this.RadioArtist.Name = "RadioArtist";
            this.RadioArtist.Size = new System.Drawing.Size(64, 20);
            this.RadioArtist.TabIndex = 3;
            this.RadioArtist.TabStop = true;
            this.RadioArtist.Text = "Artist";
            this.RadioArtist.UseVisualStyleBackColor = false;
            this.RadioArtist.CheckedChanged += new System.EventHandler(this.RadioArtist_CheckedChanged);
            // 
            // RadioTitle
            // 
            this.RadioTitle.AutoSize = true;
            this.RadioTitle.BackColor = System.Drawing.Color.Transparent;
            this.RadioTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTitle.ForeColor = System.Drawing.Color.White;
            this.RadioTitle.Location = new System.Drawing.Point(424, 200);
            this.RadioTitle.Name = "RadioTitle";
            this.RadioTitle.Size = new System.Drawing.Size(53, 20);
            this.RadioTitle.TabIndex = 4;
            this.RadioTitle.TabStop = true;
            this.RadioTitle.Text = "Title";
            this.RadioTitle.UseVisualStyleBackColor = false;
            this.RadioTitle.CheckedChanged += new System.EventHandler(this.RadioTitle_CheckedChanged);
            // 
            // RadioAlbum
            // 
            this.RadioAlbum.AutoSize = true;
            this.RadioAlbum.BackColor = System.Drawing.Color.Transparent;
            this.RadioAlbum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAlbum.ForeColor = System.Drawing.Color.White;
            this.RadioAlbum.Location = new System.Drawing.Point(220, 200);
            this.RadioAlbum.Name = "RadioAlbum";
            this.RadioAlbum.Size = new System.Drawing.Size(66, 20);
            this.RadioAlbum.TabIndex = 5;
            this.RadioAlbum.TabStop = true;
            this.RadioAlbum.Text = "Album";
            this.RadioAlbum.UseVisualStyleBackColor = false;
            this.RadioAlbum.CheckedChanged += new System.EventHandler(this.RadioAlbum_CheckedChanged);
            // 
            // RadioYear
            // 
            this.RadioYear.AutoSize = true;
            this.RadioYear.BackColor = System.Drawing.Color.Transparent;
            this.RadioYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioYear.ForeColor = System.Drawing.Color.White;
            this.RadioYear.Location = new System.Drawing.Point(509, 200);
            this.RadioYear.Name = "RadioYear";
            this.RadioYear.Size = new System.Drawing.Size(57, 20);
            this.RadioYear.TabIndex = 6;
            this.RadioYear.TabStop = true;
            this.RadioYear.Text = "Year";
            this.RadioYear.UseVisualStyleBackColor = false;
            this.RadioYear.CheckedChanged += new System.EventHandler(this.RadioYear_CheckedChanged_1);
            // 
            // RadioGeneric
            // 
            this.RadioGeneric.AutoSize = true;
            this.RadioGeneric.BackColor = System.Drawing.Color.Transparent;
            this.RadioGeneric.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioGeneric.ForeColor = System.Drawing.Color.White;
            this.RadioGeneric.Location = new System.Drawing.Point(319, 201);
            this.RadioGeneric.Name = "RadioGeneric";
            this.RadioGeneric.Size = new System.Drawing.Size(74, 20);
            this.RadioGeneric.TabIndex = 7;
            this.RadioGeneric.TabStop = true;
            this.RadioGeneric.Text = "Generic";
            this.RadioGeneric.UseVisualStyleBackColor = false;
            this.RadioGeneric.CheckedChanged += new System.EventHandler(this.RadioGeneric_CheckedChanged);
            // 
            // BrowseComboBox
            // 
            this.BrowseComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.BrowseComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseComboBox.ForeColor = System.Drawing.Color.White;
            this.BrowseComboBox.FormattingEnabled = true;
            this.BrowseComboBox.Location = new System.Drawing.Point(284, 230);
            this.BrowseComboBox.Name = "BrowseComboBox";
            this.BrowseComboBox.Size = new System.Drawing.Size(173, 22);
            this.BrowseComboBox.Sorted = true;
            this.BrowseComboBox.TabIndex = 8;
            this.BrowseComboBox.Text = "Complete Your Choice";
            this.BrowseComboBox.Click += new System.EventHandler(this.BrowseComboBox_Click);
            // 
            // RadioDuration
            // 
            this.RadioDuration.AutoSize = true;
            this.RadioDuration.BackColor = System.Drawing.Color.Transparent;
            this.RadioDuration.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDuration.ForeColor = System.Drawing.Color.White;
            this.RadioDuration.Location = new System.Drawing.Point(597, 199);
            this.RadioDuration.Name = "RadioDuration";
            this.RadioDuration.Size = new System.Drawing.Size(82, 20);
            this.RadioDuration.TabIndex = 16;
            this.RadioDuration.TabStop = true;
            this.RadioDuration.Text = "Duration";
            this.RadioDuration.UseVisualStyleBackColor = false;
            this.RadioDuration.CheckedChanged += new System.EventHandler(this.RadioDuration_CheckedChanged);
            // 
            // RadioD1
            // 
            this.RadioD1.AutoSize = true;
            this.RadioD1.BackColor = System.Drawing.Color.Transparent;
            this.RadioD1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioD1.ForeColor = System.Drawing.Color.White;
            this.RadioD1.Location = new System.Drawing.Point(3, 7);
            this.RadioD1.Name = "RadioD1";
            this.RadioD1.Size = new System.Drawing.Size(55, 20);
            this.RadioD1.TabIndex = 18;
            this.RadioD1.TabStop = true;
            this.RadioD1.Text = "0 : 3";
            this.RadioD1.UseVisualStyleBackColor = false;
            this.RadioD1.CheckedChanged += new System.EventHandler(this.RadioD1_CheckedChanged);
            // 
            // RadioD2
            // 
            this.RadioD2.AutoSize = true;
            this.RadioD2.BackColor = System.Drawing.Color.Transparent;
            this.RadioD2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioD2.ForeColor = System.Drawing.Color.White;
            this.RadioD2.Location = new System.Drawing.Point(3, 33);
            this.RadioD2.Name = "RadioD2";
            this.RadioD2.Size = new System.Drawing.Size(63, 20);
            this.RadioD2.TabIndex = 19;
            this.RadioD2.TabStop = true;
            this.RadioD2.Text = "3 : 10";
            this.RadioD2.UseVisualStyleBackColor = false;
            this.RadioD2.CheckedChanged += new System.EventHandler(this.RadioD2_CheckedChanged);
            // 
            // RadioD3
            // 
            this.RadioD3.AutoSize = true;
            this.RadioD3.BackColor = System.Drawing.Color.Transparent;
            this.RadioD3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioD3.ForeColor = System.Drawing.Color.White;
            this.RadioD3.Location = new System.Drawing.Point(3, 59);
            this.RadioD3.Name = "RadioD3";
            this.RadioD3.Size = new System.Drawing.Size(101, 20);
            this.RadioD3.TabIndex = 20;
            this.RadioD3.TabStop = true;
            this.RadioD3.Text = "10 : Infinity";
            this.RadioD3.UseVisualStyleBackColor = false;
            this.RadioD3.CheckedChanged += new System.EventHandler(this.RadioD3_CheckedChanged);
            // 
            // ContainerDuartion
            // 
            this.ContainerDuartion.Controls.Add(this.pictureBox9);
            this.ContainerDuartion.Controls.Add(this.pictureBox8);
            this.ContainerDuartion.Controls.Add(this.RadioD1);
            this.ContainerDuartion.Controls.Add(this.RadioD3);
            this.ContainerDuartion.Controls.Add(this.RadioD2);
            this.ContainerDuartion.Location = new System.Drawing.Point(597, 225);
            this.ContainerDuartion.Name = "ContainerDuartion";
            this.ContainerDuartion.Size = new System.Drawing.Size(108, 100);
            this.ContainerDuartion.TabIndex = 21;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox9.Location = new System.Drawing.Point(63, 32);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(23, 26);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox8.Location = new System.Drawing.Point(59, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(23, 26);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox10.Location = new System.Drawing.Point(698, 282);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(23, 26);
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox7.Location = new System.Drawing.Point(682, 196);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 26);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox5.Location = new System.Drawing.Point(397, 196);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 26);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(482, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 28);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(290, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 28);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox2.Location = new System.Drawing.Point(571, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 26);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GUIFile.Properties.Resources.Checkmark_48px;
            this.pictureBox1.Location = new System.Drawing.Point(192, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseButton.BorderRadius = 0;
            this.BrowseButton.ButtonText = "Browse";
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.DisabledColor = System.Drawing.Color.Gray;
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BrowseButton.Iconimage = global::GUIFile.Properties.Resources.Music_Folder_48px;
            this.BrowseButton.Iconimage_right = null;
            this.BrowseButton.Iconimage_right_Selected = null;
            this.BrowseButton.Iconimage_Selected = null;
            this.BrowseButton.IconMarginLeft = 0;
            this.BrowseButton.IconMarginRight = 0;
            this.BrowseButton.IconRightVisible = true;
            this.BrowseButton.IconRightZoom = 0D;
            this.BrowseButton.IconVisible = true;
            this.BrowseButton.IconZoom = 90D;
            this.BrowseButton.IsTab = false;
            this.BrowseButton.Location = new System.Drawing.Point(254, 138);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BrowseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.BrowseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BrowseButton.selected = false;
            this.BrowseButton.Size = new System.Drawing.Size(241, 48);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.Textcolor = System.Drawing.Color.White;
            this.BrowseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(190, -18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(379, 210);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.BackColor = System.Drawing.Color.Transparent;
            this.Location.ForeColor = System.Drawing.Color.White;
            this.Location.Location = new System.Drawing.Point(622, 36);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(119, 13);
            this.Location.TabIndex = 25;
            this.Location.Text = "Choose Folder Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(695, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Next Page";
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.ContainerDuartion);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.RadioDuration);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BrowseComboBox);
            this.Controls.Add(this.RadioGeneric);
            this.Controls.Add(this.RadioYear);
            this.Controls.Add(this.RadioAlbum);
            this.Controls.Add(this.RadioTitle);
            this.Controls.Add(this.RadioArtist);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.HeaderFormBrowse);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowseForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Sorting";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            this.HeaderFormBrowse.ResumeLayout(false);
            this.HeaderFormBrowse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Definedestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonBrowseForm)).EndInit();
            this.ContainerDuartion.ResumeLayout(false);
            this.ContainerDuartion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton BrowseButton;
        private System.Windows.Forms.Panel HeaderFormBrowse;
        private Bunifu.Framework.UI.BunifuImageButton ExitButtonBrowseForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label LabelBrowseForm;
        private System.Windows.Forms.RadioButton RadioGeneric;
        private System.Windows.Forms.RadioButton RadioYear;
        private System.Windows.Forms.RadioButton RadioAlbum;
        private System.Windows.Forms.RadioButton RadioTitle;
        private System.Windows.Forms.RadioButton RadioArtist;
        private System.Windows.Forms.ComboBox BrowseComboBox;
        private Bunifu.Framework.UI.BunifuImageButton NextSort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Bunifu.Framework.UI.BunifuImageButton Definedestination;
        private System.Windows.Forms.RadioButton RadioDuration;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel ContainerDuartion;
        private System.Windows.Forms.RadioButton RadioD1;
        private System.Windows.Forms.RadioButton RadioD3;
        private System.Windows.Forms.RadioButton RadioD2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label label1;
    }
}

