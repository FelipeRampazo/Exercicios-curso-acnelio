using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DTO;
namespace Loja
{
    public partial class cadastro_cliente : Form
    {
        string modo = "";
        public cadastro_cliente()
        {
            InitializeComponent();
        }

        private void cadastro_cliente_Load(object sender, EventArgs e)
        {
            IList<ClienteDTO> listClienteDTO = new List<ClienteDTO>();
            listClienteDTO = new ClienteBLL().cargaCliente();

            dtgCli.DataSource = listClienteDTO;
        }

        private void dtgCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dtgCli.CurrentRow.Index;

            txtNome.Text = Convert.ToString(dtgCli["nome", sel].Value);
            txtEndereço.Text = Convert.ToString(dtgCli["endereco", sel].Value);
            txtCidade.Text = Convert.ToString(dtgCli["cidade", sel].Value);
            txtTelefone.Text = Convert.ToString(dtgCli["telefone", sel].Value);

            if (Convert.ToString(dtgCli["situacao", sel].Value) == "1")
            {
                cboSituacao.Text = "Ativo";
            }

            else
            {
                cboSituacao.Text = "Inativo";
            }


        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampo();
            modo = "novo";
        }

        public void limpaCampo()
        {
            txtNome.Text = "";
            txtEndereço.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            cboSituacao.Text = "";



        }
    }
}
