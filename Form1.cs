using System.Reflection;

namespace AutomacaoDeskTop
{
    public partial class Form1 : Form
    {
        List<COMANDOS> COMANDOS = new List<COMANDOS>();
        private bool start_mapeamento = false;
        public int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmMapear_Click(object sender, EventArgs e)
        {
            start_mapeamento = true;
            btmMapear.Visible = false;
            btnParar.Visible = true;
            new Thread(new ThreadStart(Mapear)).Start();
        }

        private void Mapear()
        {
            while (start_mapeamento)
            {
                int X = MousePosition.X;
                int Y = MousePosition.Y;

                this.Invoke(delegate
                {
                    this.label1.Text = "X:" + X.ToString();
                    this.label2.Text = "Y:" + Y.ToString();
                });

        }
        }
    } 
}
