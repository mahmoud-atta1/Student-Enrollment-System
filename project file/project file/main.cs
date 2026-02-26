namespace project_file
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student sf = new student(); 
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course cf = new course();
            cf.Show();
        }
    }
}
