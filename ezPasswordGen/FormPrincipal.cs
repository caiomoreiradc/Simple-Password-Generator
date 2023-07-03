namespace ezPasswordGen
{
    public partial class FormPrincipal : Form
    {
        Funcao funcao;
        public FormPrincipal(Funcao repositorio)
        {
            InitializeComponent();
            this.funcao = repositorio;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            MostrarSenha();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSenha.Text);
        }
        private int GerarTamanho()
        {
            if (txtTamanho.Text == string.Empty)
                txtTamanho.Text = "8";

            int tamanho = Convert.ToInt32(txtTamanho.Text);
            return tamanho;
        }
        private void FormatarCaracteres()
        {
            if (chbSpecial.Checked == true)
                funcao.chars = funcao.chars + "!@#$%&*";
            else if (chbSpecial.Checked == false)
                funcao.chars = funcao.chars.Replace("!@#$%&*", string.Empty);
        }
        private string GerarSenha()
        {
            FormatarCaracteres();

            string senhaGerada = funcao.GerarSenha(GerarTamanho());

            return senhaGerada;
        }
        private void MostrarSenha()
        {
            txtSenha.Text = GerarSenha();
        }

    }
}