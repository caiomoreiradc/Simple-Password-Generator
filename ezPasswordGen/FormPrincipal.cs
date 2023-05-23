namespace ezPasswordGen
{
    public partial class FormPrincipal : Form
    {
        Repositorio repositorio;
        public FormPrincipal(Repositorio repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            MostrarSenha();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopiarSenha();
        }
        private void MostrarSenha()
        {
            txtSenha.Text = repositorio.GerarSenha(PegarTamanho());
        }
        private int PegarTamanho()
        {
            if(txtTamanho.Text == string.Empty)
                txtTamanho.Text = "8";
            
            int tamanho = Convert.ToInt32(txtTamanho.Text);
            return tamanho;
        }
        private void CopiarSenha()
        {
            Clipboard.SetText(txtSenha.Text);
        }
    }
}