using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Resources;
namespace GUIFile
{
    public partial class BrowseForm : Form
    {
        private static bool Stop = false;
        private string browsecombox;
        private String Path = "";
        private String Destination;
        List<MP3Tag> TagsList = new List<MP3Tag>();
        public BrowseForm()
        {
            if (!Stop)
            {
                Thread t = new Thread(new ThreadStart(Threading));
                t.Start();
                Thread.Sleep(4300);
                Application.Exit();
            }
            InitializeComponent();
            Stop = true;
            Destination = @"E:\Music Sorter";
        }
        public String getRadioButton()
        {
            if (RadioArtist.Checked)
                return "Artist";
            else if (RadioTitle.Checked)
                return "Title";
            else if (RadioAlbum.Checked)
                return "Album";
            else if (RadioYear.Checked)
                return "Year";
            else if (RadioGeneric.Checked)
                return "Genere";
            else if (RadioD1.Checked)
                return "0 : 3";
            else if (RadioD2.Checked)
                return "3 : 10";
            else if (RadioD3.Checked)
                return "10 : Infinity";
                 
            return "";
        }
        public List<MP3Tag> LoadFilesTag(String path)
        {
            MP3Reader Reader;
            MP3Tag objTag;
            FileInfo Fi;
            List<string> ListFileNames = new List<string>();
            ListFileNames.Clear();
            TagsList.Clear();
            if (path != "")
            { 

                try
                {
                    foreach (string item in Directory.GetFiles(path))
                    {
                        objTag = new MP3Tag();
                        Fi = new FileInfo(item);
                        ListFileNames.Add(Fi.Name);
                        Reader = new MP3Reader(Path + "\\" + Fi.Name);
                        TagsList.Add(Reader.getTag());
                    }

                   
                }
                
                catch (ExtentionExcep Ex)
                {
                    Ex.PrintExcep();
                }
            }
                   
            else
                throw new NullPathExcep("Please Click On Browse Button and Select Your Folder To Sort it");

            return TagsList;

        }     
        public void Threading()
        {
            Application.Run(new StartForm());
        }
        private void ExitButtonBrowseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            BrowseComboBox.Items.Clear();
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.ShowDialog();
            Path = folderBrowserDialog1.SelectedPath; 
        }
        private void BrowseComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                TagsList = LoadFilesTag(Path);
            }
             catch (NullPathExcep Ex){
                Ex.PrintExcep();
            }
           

            if (getRadioButton() == "Artist")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Artist != null)
                    {
                        if (!BrowseComboBox.Items.Contains(TagsList[i].Artist))
                            BrowseComboBox.Items.Add(TagsList[i].Artist);
                    }
                }
            }

            else if (getRadioButton() == "Title")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Title != null)
                    {
                        if (!BrowseComboBox.Items.Contains(TagsList[i].Title))
                            BrowseComboBox.Items.Add(TagsList[i].Title);
                    }
                    
                }
            }
            else if (getRadioButton() == "Year")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Year != null)
                    {
                        if (!BrowseComboBox.Items.Contains(TagsList[i].Year))
                            BrowseComboBox.Items.Add(TagsList[i].Year);

                    }
                    
                }
            }
            else if (getRadioButton() == "Genere")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Genere != null)
                    {
                        if (!BrowseComboBox.Items.Contains(TagsList[i].Genere))
                            BrowseComboBox.Items.Add(TagsList[i].Genere);
                    }
                    
                }
            }
            else if (getRadioButton() == "Album")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Album != null)
                    {
                        if (!BrowseComboBox.Items.Contains(TagsList[i].Album))
                            BrowseComboBox.Items.Add(TagsList[i].Album);
                    }
                   
                }
            }

            else if (getRadioButton() == "0 : 3")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Duration >= 0 && TagsList[i].Duration <=3*60)
                    {
                        if (Math.Ceiling(TagsList[i].Duration / 60.0).ToString() != Math.Floor(TagsList[i].Duration / 60.0).ToString())
                        {
                            if (!BrowseComboBox.Items.Contains(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString()))
                            {
                                BrowseComboBox.Items.Add(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString());
                            }
   
                        }
                           
                    }
                }
            }
            else if (getRadioButton() == "3 : 10")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Duration >= 3*60 && TagsList[i].Duration <= 10*60)
                    {
                        if (Math.Ceiling(TagsList[i].Duration / 60.0).ToString() != Math.Floor(TagsList[i].Duration / 60.0).ToString())
                        {
                            if (!BrowseComboBox.Items.Contains(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString()))
                            {
                                BrowseComboBox.Items.Add(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString());
                            }

                        }
                    }

                }
            }
            else if (getRadioButton() == "10 : Infinity")
            {
                BrowseComboBox.Items.Clear();
                for (int i = 0; i < TagsList.Count; i++)
                {
                    if (TagsList[i].Duration >= 10*60 )
                    {
                        if (Math.Ceiling(TagsList[i].Duration / 60.0).ToString() != Math.Floor(TagsList[i].Duration / 60.0).ToString())
                        {
                            if (!BrowseComboBox.Items.Contains(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString()))
                            {
                                BrowseComboBox.Items.Add(Math.Floor(TagsList[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(TagsList[i].Duration / 60.0).ToString());
                            }

                        }
                    }

                }
            }
        }   
        private void NextSort_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (Path != "")
                {

                    SortingForm Obj = new SortingForm(TagsList,getRadioButton(), Path, Destination , BrowseComboBox.Text);  // Passing  to the Next Form
                    Obj.Show();
                    this.Hide();
                }
                else
                    throw new NullPathExcep("Null Path Exception");
            }
            catch(NullPathExcep Ex)
            { Ex.PrintExcep(); }
         } 
        private void BrowseForm_Load(object sender, EventArgs e)
        {
            Location.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            ContainerDuartion.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }
        private void RadioArtist_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioArtist.Checked)
            {
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox1.Show();
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                ContainerDuartion.Visible = false;
                RadioD1.Checked = false;
                RadioD2.Checked = false;
                RadioD3.Checked = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void RadioAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAlbum.Checked)
            {
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox3.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                ContainerDuartion.Visible = false;
                RadioD1.Checked = false;
                RadioD2.Checked = false;
                RadioD3.Checked = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void RadioTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTitle.Checked)
            {
                pictureBox4.Show();
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                ContainerDuartion.Visible = false;
                RadioD1.Checked = false;
                RadioD2.Checked = false;
                RadioD3.Checked = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void RadioGeneric_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioGeneric.Checked)
            { 
                pictureBox5.Show();
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                ContainerDuartion.Visible = false;
                RadioD1.Checked = false;
                RadioD2.Checked = false;
                RadioD3.Checked = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void BrowseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            browsecombox = BrowseComboBox.Text;
        }
        private void Definedestination_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.Description = "Create Folder Or Choose Folder Location";
            folderBrowserDialog1.ShowDialog();
            this.Destination = folderBrowserDialog1.SelectedPath;
            if (folderBrowserDialog1.SelectedPath == "")
            {
              Destination = @"E:\Music Sorter";
            } 
            else
            {
                    System.IO.Directory.CreateDirectory(Destination +"\\Music Sorter");
            }
        }
        private void RadioYear_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioYear.Checked)
            {
                pictureBox2.Show();
                ContainerDuartion.Visible = false;
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                RadioD1.Checked = false;
                RadioD2.Checked = false;
                RadioD3.Checked = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void RadioDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioDuration.Checked)
            {
                BrowseComboBox.Text = "Complete Your Choice";
                pictureBox7.Show();
                ContainerDuartion.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
        }
        private void RadioD1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }
        private void RadioD2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
        }
        private void RadioD3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
        }
        private void Definedestination_MouseEnter(object sender, EventArgs e)
        {
            Location.Visible = true;
        }
        private void Definedestination_MouseLeave(object sender, EventArgs e)
        {
            Location.Visible = false;
        }
        private void NextSort_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
        private void NextSort_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
 