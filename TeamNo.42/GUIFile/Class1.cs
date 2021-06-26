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
    class ExtentionExcep : Exception  // We Create this Class For Handling Extention Exceptions 
    {
        public ExtentionExcep(string Message) : base(Message)
        { }

        public void PrintExcep(){
             MessageBox.Show("Sorry Our Program Can Be Work On MP3 Files Only", "Extention Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    class NullPathExcep : Exception   // We Create this Class For Handling Null Path Exceptions 
    {
        public NullPathExcep(String Message) : base(Message) { }
        public void PrintExcep()
        {
            MessageBox.Show("Please Click On Browse Button and Select Your Folder To Sort it", "Null Path Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public class MP3Tag
    {
        public string Name_File;
        public string Title;
        public string Album;
        public string Artist;
        public string Year;
        public string Genere;
        public string Comment;
        public Double Duration;
      
    }
    public class MP3Reader
    {
        public string fileName;
        FileStream stream;
        public const int SIZE = 128;
        public byte[] tagData;

        public MP3Reader()
        {
        }
        public MP3Reader(string name)
        {
            tagData = new byte[SIZE];
            this.fileName = name;
            this.stream = new FileStream(this.fileName, FileMode.Open);
        }
        public MP3Tag getTag()
        {
            MP3Tag tag = new MP3Tag();
            tag.Name_File = Path.GetFileName(fileName);

            stream.Seek(stream.Length - 128, SeekOrigin.Begin);
            stream.Read(tagData, 0, SIZE);
            stream.Close();

          
            if ((char)tagData[0] != 'T' || (char)tagData[1] != 'A' || (char)tagData[2] != 'G')
            {
                throw new ExtentionExcep("Not an MP3 Format File");

            }
            
            

            for (int i = 3; i < 33; i++)
            {
                if (tagData[i] != 0)
                    tag.Title += (char)tagData[i];

            }
            for (int i = 33; i < 63; i++)
            {
                if (tagData[i] != 0)
                    tag.Artist += (char)tagData[i];
            }
            for (int i = 63; i < 93; i++)
            {
                if (tagData[i] != 0)
                    tag.Album += (char)tagData[i];
            }
            for (int i = 93; i < 97; i++)
            {
                if (tagData[i] != 0)
                    tag.Year += (char)tagData[i];
            }
            for (int i = 97; i < 127; i++)
            {
                if (tagData[i] != 0)
                    tag.Comment += (char)tagData[i];
            }
            tag.Genere = tagData[127].ToString();

            TagLib.File f = TagLib.File.Create(fileName, TagLib.ReadStyle.Average);
            tag.Duration = (int)f.Properties.Duration.TotalSeconds;  

            return tag;

        }
    }
}
