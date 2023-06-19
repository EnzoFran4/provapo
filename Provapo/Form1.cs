namespace Provapo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarefa c = new Tarefa();    
            c.ShowDialog();
        }
    }
}