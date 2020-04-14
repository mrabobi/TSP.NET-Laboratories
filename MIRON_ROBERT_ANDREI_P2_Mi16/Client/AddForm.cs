using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PhotosGUI
{
    public partial class AddForm : Form
    {
        public string path = "";
        public string name, description, location = " ";
        public DateTime dt;
        public bool isPicture = false;
        public AddForm(string path, string name, DateTime dt,string ext)
        {
            InitializeComponent();
            this.path = path;
            this.name = name;
            this.dt = dt;
            if (ext != ".mp4" && ext != ".mkv")
            {
                Console.WriteLine(ext);
                isPicture = true;
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = path;
            }


            labelPath.Text = path;
            textBox2.Text = name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxCategory.Text != "")
            {
                listBox1.Items.Add(textBoxCategory.Text);
                textBoxCategory.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox2.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void Location_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                this.description = textBoxDescription.Text;
                this.location = textBoxLocation.Text;
                List<string> categorys = new List<string>();
                List<string> peoplys = new List<string>();
                foreach (var item in listBox1.Items)
                {
                    categorys.Add(item.ToString());
                }

                foreach(var item in listBox2.Items)
                {
                    peoplys.Add(item.ToString());
                }

                MyPhotosServiceClient api = new MyPhotosServiceClient();
                api.AddEntry(textBox2.Text, path, description,location,dt,categorys.ToArray(),peoplys.ToArray());

            }
            axWindowsMediaPlayer1.close();
            this.Close();
        }
    }
}
