using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;



namespace GNote
{

    public partial class Form1 : Form
    {

        string GNotePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GNote";
        public Form1()
        {
            InitializeComponent();
            var results = Directory.GetFiles(GNotePath, "*.txt")
                          .Select(file => Path.GetFileName(file)).ToArray();
            noteslist.Items.AddRange(results);
        }


        private void button_save_Click(object sender, EventArgs e)
        {

            string title = tB_title.Text;
            string content = tB_content.Text;



            // Writing a note to a file

            string userName = Environment.UserName;
            MessageBox.Show(GNotePath);
            Directory.CreateDirectory(GNotePath);
            string fileName = GNotePath+ "\\" + title + ".txt";
           
            MessageBox.Show(fileName);



            try
            {
                if (File.Exists(fileName))
                {
                    DialogResult dialogResult = MessageBox.Show("Note exist!",
                        "Using the same name will result in deletion of the old note?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(fileName);
                        using (FileStream fs = File.Create(fileName))
                        {
                            Byte[] notecontent = new UTF8Encoding(true).GetBytes(content);
                            fs.Write(notecontent, 0, content.Length);
                        }
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Try to change name of the note to different one");
                    }

                }
                else
                {
                    using (FileStream fs = File.Create(fileName))
                    {
                        Byte[] notecontent = new UTF8Encoding(true).GetBytes(content);
                        fs.Write(notecontent, 0, content.Length);


                        noteslist.Items.Add(title);

                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            tB_title.Clear();
            tB_content.Clear();

        }


        private void button_read_Click(object sender, EventArgs e)
        {


            string filefromlist = noteslist.SelectedItem.ToString();
            using (StreamReader sr = File.OpenText( GNotePath + "\\" + filefromlist))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    tB_content.Text = s;
                }

            }
        }
    }
}