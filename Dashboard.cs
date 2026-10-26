namespace NT106_Lab2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Bai1 formBai1 = new Bai1();
            formBai1.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Bai2 formBai2 = new Bai2();
            formBai2.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Bai3 formBai3 = new Bai3();
            formBai3.ShowDialog();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Bai4 formBai4 = new Bai4();
            formBai4.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Bai5 formBai5 = new Bai5();
            formBai5.ShowDialog();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Bai6 formBai6 = new Bai6();
            formBai6.ShowDialog();
        }

        private void btnBai07_Click(object sender, EventArgs e)
        {
            Bai7 formBai7 = new Bai7();
            formBai7.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
