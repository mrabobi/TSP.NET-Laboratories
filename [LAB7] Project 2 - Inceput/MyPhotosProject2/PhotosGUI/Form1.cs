using MyPhotos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PhotosGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDataGrid()
        {
            API api = new API();
            var items = api.GetAllPicsForLoad();
            //dataGridView1.DataSource = items;

            dataGridView1.DataSource = items.Select(itm => new
            {
                ID = itm.ID_IMG,
                Nume = itm.Name_img,
                Description = itm.Description,
                Category = string.Join(",",itm.Categories.Select(c=> c.CategoryName.ToString())),
                Location = itm.Location,
                Persons = string.Join(",", itm.Person.Select(x => x.FirstName.ToString())),
                Date = itm.Data_create,
                Path = itm.Path
            }).ToList();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            UpdateDataGrid();   
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|MKV (*.mkv)|*.mkv|MP4 (*.mp4)|*.mp4|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                foreach (var file in openFileDialog1.FileNames)
                {
                    string ext = Path.GetExtension(file);
                    List<string> extensions = new List<string>() { ".jpg", ".png", ".mp4",".mkv", ".jpeg" };
                    if (extensions.Contains(ext))
                    {

                        var details = new FileInfo(file);
                        AddForm addform = new AddForm(file, details.Name, details.CreationTime,ext);
                        addform.ShowDialog();
                    }
                }
                UpdateDataGrid();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            API api = new API();
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {   //EditForm(int id, string title, string description, string location, string path, string persons, string categories)
                if (File.Exists(item.Cells[7].Value.ToString()))
                {
                    EditForm editform = new EditForm(Int32.Parse(item.Cells[0].Value.ToString()), item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[7].Value.ToString(),
                    item.Cells[5].Value.ToString(), item.Cells[3].Value.ToString());
                    editform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fisierul nu mai exista pe acest path!", "Eroare la deschidere",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    api.RemoveEntry(Int32.Parse(item.Cells[0].Value.ToString()));
                    UpdateDataGrid();
                }
            }
            UpdateDataGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            API api = new API();
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string picName = item.Cells[1].Value.ToString();
                var confirmDelete = MessageBox.Show("Are you sure to delete " + picName + " ?",
                                     "Delete picture",
                                     MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    api.RemoveEntry(Int32.Parse(item.Cells[0].Value.ToString()));
                    
                }
                
            }
            UpdateDataGrid();
        }


        private void dataGrid_PicturePreview(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                List<string> extensions = new List<string>() { ".jpg", ".png", ".jpeg" };
                if (File.Exists(selectedRow.Cells[7].Value.ToString()))
                {
                    if (extensions.Contains(Path.GetExtension(selectedRow.Cells[7].Value.ToString())))
                    {
                        pictureBox.Image = Image.FromFile(selectedRow.Cells[7].Value.ToString());
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.close();
                    }
                    else
                    {
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = selectedRow.Cells[7].Value.ToString();
                        
                    }
                }
                else
                {
                    pictureBox.Image = PhotosGUI.Properties.Resources._404error;
                }
                }
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            API api = new API();
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string path = item.Cells[7].Value.ToString();
                if (File.Exists(path))
                {
                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("Fisierul nu mai exista pe acest path!", "Eroare la deschidere",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    api.RemoveEntry(Int32.Parse(item.Cells[0].Value.ToString()));
                    UpdateDataGrid();
                }
            }
        }

        private void filtertext_TextChanged(object sender, EventArgs e)
        {
            API api = new API();
            if (textBox1.Text == "")
                UpdateDataGrid();
            else
            {
                var items = api.getDataFiltered(comboBox1.Text, textBox1.Text);
                dataGridView1.DataSource = items.Select(itm => new
                {
                    ID = itm.ID_IMG,
                    Nume = itm.Name_img,
                    Description = itm.Description,
                    Category = string.Join(",", itm.Categories.Select(c => c.CategoryName.ToString())),
                    Location = itm.Location,
                    Persons = string.Join(",", itm.Person.Select(x => x.FirstName.ToString())),
                    Date = itm.Data_create,
                    Path = itm.Path
                }).ToList();
            }
        }
    }
}
