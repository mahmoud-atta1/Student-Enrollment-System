using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_file
{
    public partial class student : Form
    {
        string path = "student.txt";

        public student()
        {
            InitializeComponent();
        }


        // --> Bottons 

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            string id = textBox3.Text;

            if (name == "" || age == "" || id == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string line = $"{id},{name},{age}";
            File.AppendAllText(path, line + Environment.NewLine);

            MessageBox.Show("Student Added Successfully!");
        }
       
        // Delete
        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text.Trim();

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

                if (data[0].Trim() != id)
                    newList.Add(line);
                else
                    deleted = true;
            }

            File.WriteAllLines(path, newList);

            if (deleted)
                MessageBox.Show("Student Deleted!");
            else
                MessageBox.Show("ID Not Found!");
        }

        // search
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text.Trim();

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

                if (data[0].Trim() == id)
                {
                    
                    listBox1.Items.Add($"ID: {data[0].Trim()} | Name: {data[1].Trim()} | Age: {data[2].Trim()}");
                    found = true;
                    break; 
                }
            }

            if (!found)
                MessageBox.Show("Student not found!");
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

                if (data.Length >= 3) // نتأكد ان فيه كل البيانات
                {
                    listBox1.Items.Add($"ID: {data[0].Trim()} | Name: {data[1].Trim()} | Age: {data[2].Trim()}");
                }
            }
        }




        // --> textboxs
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // --> Labels
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }  
        // listBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
