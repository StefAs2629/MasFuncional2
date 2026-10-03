namespace MasFuncional3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfunc_Click(object sender, EventArgs e)
        {
            clFunc func = new clFunc();
            func.Ejecutar();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            
            clAction.Ejecutar();

        }
    }
}
