namespace julyform13
{
    public partial class Classic : Form
    {
        public Classic()
        {
            InitializeComponent();
        }

        private void classic_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Section section = new Section();
            section.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createaccount ss = new Createaccount();
            ss.Show();
        }
    }
}