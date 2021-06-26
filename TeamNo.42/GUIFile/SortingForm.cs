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
using System.Diagnostics;

namespace GUIFile
{
    public partial class SortingForm : Form
    {
        static bool Stop = false;
        List<MP3Tag> Tags = new List<MP3Tag>();
        public List<string> CheckedItem = new List<string>();
        string Selected;
        string Path1;
        string Destination ;
        string ComboText;
        public void Threading()
        {
            Application.Run(new StartForm());
        }
        public void BrowseForm()
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
        }
        private void BackBrowseForm_Click(object sender, EventArgs e)
        {
            Tags.Clear();
            CheckedItem.Clear();
            Selected = null;
            Path1 = null;
            Destination = null;
            ComboText = null;
            
            /////////////////////////////////////////////
            BrowseForm Obj = new BrowseForm();
            Obj.Show();
            this.Hide();
            timer1.Stop();
        }
        public SortingForm(List<MP3Tag> MyTags,string Slected, string FolderPath, string Destination, string ComboBoxText)
        {
            this.Path1 = FolderPath;
            this.Selected = Slected;
            this.ComboText = ComboBoxText;
            this.Destination = Destination;
            this.Tags = MyTags;
            InitializeComponent();
            CheckBox_Disable();
        }    
        private void SortingForm_Load(object sender, EventArgs e)
        {
            OpenFolderBtn.Visible = false;
            PlayBtn.Visible = false;
            pictureBox6.Visible = false;
            playList1.Visible = false;
            timer1.Stop();
        }
        private void CheckBox_Disable()
        {
            for (int j = 0; j < SortingListBox.Items.Count; j++)
            {
                if (SortingListBox.Items[j].Equals(Selected))
                {
                    SortingListBox.Items.RemoveAt(j);
                }
            }
            Remove_from_List();
        }
        private void Remove_from_List()
        {
            if(Selected == "" || ComboText == "")
            {
                MessageBox.Show("Sorting Will Be On All Files","Warning" , MessageBoxButtons.OKCancel , MessageBoxIcon.Warning); 
            }
            else if (Selected == "Artist")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Tags[i].Artist != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
            else if (Selected == "Album")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Tags[i].Album != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
            else if (Selected == "Genere")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Tags[i].Genere != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
            else if (Selected == "Title")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Tags[i].Title != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
            else if (Selected == "Year")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Tags[i].Year != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
            else if (Selected == "0 : 3" || Selected == "3 : 10" || Selected == "10 : Infinity")
            {
                for (int i = 0; i < Tags.Count; i++)
                {
                    if (Math.Floor(Tags[i].Duration / 60.0).ToString() + " - " + Math.Ceiling(Tags[i].Duration / 60.0).ToString() != ComboText)
                    {
                        Tags.RemoveAt(i);                // Remove Tag and Shift All Followed Tags
                        i--;                             // Back one Step For Adapting to The Change in List After Removing Tags
                    }
                }
            }
        }
        private void Copy_to_folder()
        {
            
            foreach (MP3Tag item in Tags)
            {
                FileInfo f1 = new FileInfo(Path1 + "\\" + item.Name_File);
             //   f1.CopyTo(Destination +"\\"+ item.Name_File);
                File.Copy(Path1 + "\\" + item.Name_File, Destination + "\\" + item.Name_File, true);
            }

            // Insert The Order of The audio File in The Comment Section of File Tag

            foreach (string item in Directory.GetFiles(Destination))
            {
                
                TagLib.File f = TagLib.File.Create(item);
                int i = Tags.FindIndex(T => T.Name_File == Path.GetFileName(item)) + 1;
                f.Tag.Comment = i.ToString();                
                f.Save();
            }
             
        }
        private void Sort()
        {
            foreach (string item in SortingListBox.CheckedItems)
            {
                CheckedItem.Add(item);
            }
             

            if (CheckedItem.Count == 0)
            {
                //Default Sort By File Name
                var newList2 = Tags.OrderBy(x => x.Name_File).ToList();
                Tags = newList2;
            }
            else if (CheckedItem.Count == 1)
            {
                if (CheckedItem[0] == "Album")
                {
                    var newList2 = Tags.OrderBy(x => x.Album).ToList();
                    Tags = newList2;
                }
                else if (CheckedItem[0] == "Artist")
                {
                    var newList2 = Tags.OrderBy(x => x.Artist).ToList();
                    Tags = newList2;
                }
                else if (CheckedItem[0] == "Duration")
                {
                    var newList2 = Tags.OrderBy(x => x.Duration).ToList();
                    Tags = newList2;
                }
                else if (CheckedItem[0] == "Genre")
                {
                    var newList2 = Tags.OrderBy(x => x.Genere).ToList();
                    Tags = newList2;
                }
                else if (CheckedItem[0] == "Title")
                {
                    var newList2 = Tags.OrderBy(x => x.Title).ToList();
                    Tags = newList2;
                }
                else if (CheckedItem[0] == "Year")
                {
                    var newList2 = Tags.OrderBy(x => x.Year).ToList();
                    Tags = newList2;
                }
            }



            else if (CheckedItem.Count == 2)
            {
                if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ToList();
                    Tags = Tags2;
                }
                
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ToList();
                    Tags = Tags2;
                }
                   
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }

                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }

                    /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Genre" && CheckedItem[1] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Genre" && CheckedItem[1] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Title" && CheckedItem[1] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
            }
                
            else if (CheckedItem.Count == 3)
            {
                if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Genere" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Genere" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Title" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }

                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genre")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Genre" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Genre" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Title" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Genre" && CheckedItem[2] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Genre" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Title" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                /*///////////////////////////////////////////////////////*/
                else if (CheckedItem[0] == "Genre" && CheckedItem[1] == "Title" && CheckedItem[2] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
            }

            else if (CheckedItem.Count == 4)
            {

                if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Genere")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }

                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }

                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Genere" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Genere" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Duration" && CheckedItem[1] == "Genere" && CheckedItem[2] == "Title" && CheckedItem[3] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }

            }
            else if (CheckedItem.Count == 5)
            {

                if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Genere" && CheckedItem[4] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Genere" && CheckedItem[4] == "Title")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title" && CheckedItem[4] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Artist" && CheckedItem[2] == "Duration" && CheckedItem[3] == "Title" && CheckedItem[4] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Album" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title" && CheckedItem[4] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
                else if (CheckedItem[0] == "Artist" && CheckedItem[1] == "Duration" && CheckedItem[2] == "Genere" && CheckedItem[3] == "Title" && CheckedItem[4] == "Year")
                {
                    var Tags2 = Tags.OrderBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                    Tags = Tags2;
                }
            }
            else if (CheckedItem.Count == 6)
            {
                
                var Tags2 = Tags.OrderBy(x => x.Album).ThenBy(x => x.Artist).ThenBy(x => x.Duration).ThenBy(x => x.Genere).ThenBy(x => x.Title).ThenBy(x => x.Year).ToList();
                Tags = Tags2;
            }
            Copy_to_folder();
        }
        private void StartSroting_Click(object sender, EventArgs e)
        {
            Sort();
            pictureBox6.Show();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox6.Visible = false;
            MessageBox.Show("Files Sorted Successfully");
            PlayBtn.Visible = true;
            SortingListBox.ClearSelected();
            foreach (int i in SortingListBox.CheckedIndices)
            {
                SortingListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
            OpenFolderBtn.Visible = true;
            playList1.Visible = false;
        } 
        private void ExitButtonSortingForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Destination);
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            OpenFolderBtn.Visible = false;
            PlayBtn.Visible = false;
            playList1.Visible = true;

        }

    }
}

