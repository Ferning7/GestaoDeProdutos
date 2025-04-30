namespace GestãoDeProduto
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panelCentral.Controls.Clear
        }
    }
}
