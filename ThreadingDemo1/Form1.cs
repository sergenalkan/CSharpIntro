namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Single thread, bir çocuk kaydýraða girer ikincisi onun çýkýþýný bekler
        //Multi thread, ayný anda birden fazla kaydýrak vardýr. Hepsi girmiþ olur farklý yerlere
        //Asenkron programlama ise multi threadý kapsar ve üstüne sadece tek kaydýrak olsa
        //bile bir çocuk kaydýrak içindeyken diðeri girebilir
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}
