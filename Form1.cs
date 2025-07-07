namespace soru6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Bu iþlemi yapmak istediðinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                textBox1.Text = "Kullanýcý Evet'e Týkladý.";
            }
            else 
            {
                textBox1.Text = "Kullanýcý Hayýr'a týkladý.";
            }
        }
    } 
}
