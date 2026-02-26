using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace project_file
{
    public partial class course : Form
    {
        string path = "course.txt";

        public course()
        {
            InitializeComponent();
        }

        // -> Buttons

        // Add
        private void button1_Click(object sender, EventArgs e) 
        {
            string courseId = textBox1.Text.Trim();
            string courseName = textBox3.Text.Trim();
            string duration = textBox2.Text.Trim();

            if (courseId == "" || courseName == "" || duration == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string line = $"{courseId},{courseName},{duration}";
            File.AppendAllText(path, line + Environment.NewLine);

            MessageBox.Show("Course Added Successfully!");
        }

        // Delete
        private void button2_Click(object sender, EventArgs e) 
        {
            string courseId = textBox1.Text.Trim();

            if (!File.Exists(path))
            {
                MessageBox.Show("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(path);
            List<string> newList = new List<string>();
            bool deleted = false;

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data[0].Trim() != courseId)
                    newList.Add(line);
                else
                    deleted = true;
            }

            File.WriteAllLines(path, newList);

            if (deleted)
                MessageBox.Show("Course Deleted!");
            else
                MessageBox.Show("Course ID Not Found!");
        }

        // Search
        private void button3_Click(object sender, EventArgs e)
        {
            string courseId = textBox1.Text.Trim();

            if (!File.Exists(path))
            {
                MessageBox.Show("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(path);
            bool found = false;

            listBox1.Items.Clear();

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data[0].Trim() == courseId)
                {
                    listBox1.Items.Add($"ID: {data[0].Trim()} | Name: {data[1].Trim()} | Duration: {data[2].Trim()}");
                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Course not found!");
        }

        // Display
        private void button4_Click(object sender, EventArgs e) 
        {
            listBox1.Items.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length >= 3) 
                {
                    listBox1.Items.Add($"ID: {data[0].Trim()} | Name: {data[1].Trim()} | Age: {data[2].Trim()}");
                }
        
            }
        }

        // textbox
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        // list box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        //label
        private void label5_Click(object sender, EventArgs e) { }
    }
}
