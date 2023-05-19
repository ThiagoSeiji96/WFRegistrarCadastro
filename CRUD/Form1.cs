using System.Text;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public List<Pessoa> cadastros;
        public Form1()
        {
            InitializeComponent();
            cadastros = new List<Pessoa>();
            SetIndex();
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
                int id = cadastros.Count() + 1;

                string stringId = id.ToString();
                txtID.Text = stringId;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string cpf = txtCPF.Text;

                Pessoa pessoa = new Pessoa(id, nome, email, cpf);
                cadastros.Add(pessoa);

                LimparCampos();
                AtualizarGrid();
                SetIndex();
        }
        
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            int intID = int.Parse(id);

            var pessoa = cadastros.FirstOrDefault(x => x.Id == intID);

            txtID.Text = id;
            txtNome.Text = pessoa.Nome;
            txtEmail.Text = pessoa.Email;
            txtCPF.Text = pessoa.CPF;
            AtualizarGrid();
        }

        private void BotaoDeletar_Click(Object sender, EventArgs e)
        {
            string id = txtID.Text;
            int intID = int.Parse(id);

            var pessoa = cadastros.Find(x => x.Id == intID);
           
            cadastros.Remove(pessoa);
            AtualizarGrid();
        }

        private void BotaoSalvarMudancas_Click(Object sender, EventArgs e)
        {
            string id = txtID.Text;
            int intID = int.Parse(id);

            var pessoa = cadastros.FirstOrDefault(x => x.Id == intID);
            if(intID == 0)
            {
                var a = cadastros[intID];
                a.Email = txtEmail.Text;
                a.Nome = txtNome.Text;
            }
            else
            {
            var a = cadastros[intID - 1];
            a.Email = txtEmail.Text;
            a.Nome = txtNome.Text;
            }
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cadastros;
        }

        private void LimparCampos()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
        }

        private void SetIndex()
        {
            if (cadastros.Count == 0)
            {
                txtID.Text = "1";
            }
            else
            {
                int id = cadastros.Count() + 1;
                string stringId = id.ToString();
                txtID.Text = stringId;
            }
        }

    }
}