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
            var x = MessageBox.Show("Bu i�lemi yapmak istedi�inize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                textBox1.Text = "Kullan�c� Evet'e T�klad�.";
            }
            else 
            {
                textBox1.Text = "Kullan�c� Hay�r'a t�klad�.";
            }
        }
    } 
}
