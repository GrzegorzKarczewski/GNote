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
            Directory.CreateDirectory(GNotePath);
            string fileName = GNotePath+ "\\" + title + ".txt";
        
            try
            {
                if (File.Exists(fileName))
                {
                    DialogResult dialogResult = MessageBox.Show("Using the same name will result in deletion of the old note!",
                        "Note exist!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //File.Delete(fileName);
                        using (FileStream fs = File.Create(fileName))
                        {
                            Byte[] notecontent = new UTF8Encoding(true).GetBytes(content);
                            fs.Write(notecontent, 0, content.Length);
                            if (!noteslist.Items.Contains(title + ".txt"))
                            {
                                if (title.Length > 0)
                                {
                                    noteslist.Items.Add(title + ".txt");
                                }
                                else
                                    MessageBox.Show("Note title cannot be empty!");


                            }
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


                        if (title.Length > 0)
                        {
                            noteslist.Items.Add(title + ".txt");
                        }
                        else
                            MessageBox.Show("Note title cannot be empty!");
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


      
        private void noteslist_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            if (noteslist.SelectedItem != null)      
            {
                string filefromlist = noteslist.SelectedItem.ToString();
                tB_title.Text = filefromlist.Remove(filefromlist.Length - 4);
                using StreamReader sr = File.OpenText(GNotePath + "\\" + noteslist.SelectedItem.ToString());
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    tB_content.Text = s;
                }
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            string filefromlist = noteslist.SelectedItem.ToString();
            File.Delete(GNotePath+ "\\" + filefromlist);
           
            if (noteslist.SelectedItems.Count != 0)
            {
                while (noteslist.SelectedIndex != -1)
                {
                    noteslist.Items.RemoveAt(noteslist.SelectedIndex);
                    if (noteslist.Items.Count == 0)
                    {
                        tB_title.Clear();
                        tB_content.Clear();
                    }
                }
            }

        }
    }
}