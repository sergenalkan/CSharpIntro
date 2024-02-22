namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Single thread, bir �ocuk kayd�ra�a girer ikincisi onun ��k���n� bekler
        //Multi thread, ayn� anda birden fazla kayd�rak vard�r. Hepsi girmi� olur farkl� yerlere
        //Asenkron programlama ise multi thread� kapsar ve �st�ne sadece tek kayd�rak olsa
        //bile bir �ocuk kayd�rak i�indeyken di�eri girebilir
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 1 �al��t�");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�");
        }
    }
}
