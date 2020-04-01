using MyPhotos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotosGUI
{
    public partial class EditForm : Form
    {
        public int id;
        public string title, description, location, path, persons, categories;

        private void EditForm_Load(object sender, EventArgs e)
        {
            List<string> extensions = new List<string>() { ".jpg", ".png", ".jpeg" };
            textBoxName.Text = title;
            textBox1.Text = description;
            textBox2.Text = location;
            string[] catg = categories.Split(',');
            foreach (var cat in catg)
                if(cat != "")
                    listBox1.Items.Add(cat);
            string[] perg = persons.Split(',');
            foreach (var per in perg)
                if(per != "")
                    listBox2.Items.Add(per);
            if (extensions.Contains(Path.GetExtension(path)))
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = path;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> categories = new List<string>();
            List<string> peoples = new List<string>();

            API api = new API();
            foreach(string item in listBox1.Items)
                categories.Add(item);
  
            foreach (string item in listBox2.Items)
                peoples.Add(item);

            api.updateEntry(id, textBoxName.Text, textBox1.Text, textBox2.Text,categories,peoples);
            this.Close();
            axWindowsMediaPlayer1.close();
        }

        public EditForm(int id, string title, string description, string location, string path, string persons, string categories)
        {
            InitializeComponent();
            this.id = id;
            this.title = title;
            this.description = description;
            this.location = location;
            this.path = path;
            this.persons = persons;
            this.categories = categories;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                listBox2.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
        }
    }
}
