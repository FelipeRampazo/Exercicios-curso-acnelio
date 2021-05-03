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
    
    public partial class cadastro_usuario : Form
    {
        public string modo = "";

        public cadastro_usuario()
        {
            InitializeComponent();
        }

        private void cadastro_usuario_Load(object sender, EventArgs e)
        {
            carregaGrid();

        }

        private void carregaGrid() {
                IList<UsuarioDTO> listUsuarioDTO = new List<UsuarioDTO>();
                listUsuarioDTO = new UsuarioBLL().cargaUsuario();


                dataGridView1.DataSource = listUsuarioDTO;


            }



      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridView1.CurrentRow.Index;

            txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
            txtLogin.Text = Convert.ToString(dataGridView1["login", sel].Value);
            txtEmail.Text = Convert.ToString(dataGridView1["email", sel].Value);
            txtSenha.Text = Convert.ToString(dataGridView1["senha", sel].Value);
            txtCadastro.Text = Convert.ToString(dataGridView1["cadastro", sel].Value);

            if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
            {

                cboSituacao.Text = "Ativo";

            }
            else
            {
                cboSituacao.Text = "Inativo";

            
            }

            switch (Convert.ToString(dataGridView1["perfil",sel].Value))
            {

                case "1":

                    cboPerfil.Text = "Administrador";

                    break;

                case "2":

                    cboPerfil.Text = "Operador";

                    break;

                case "3":

                    cboPerfil.Text = "Gerencial";

                    break;






            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampo();
            modo = "novo";
            txtCadastro.Text = Convert.ToString(System.DateTime.Now);



        }

        public void limpaCampo()
        {
            txtCadastro.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            cboPerfil.Text = "";
            cboSituacao.Text = "";


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                try
                {

                    UsuarioDTO USU = new UsuarioDTO();

                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.senha = txtSenha.Text;
                    USU.email = txtEmail.Text;
                    USU.cadastro = DateTime.Now;

                    if (cboSituacao.Text == "Ativo")
                    {

                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }


                    switch (cboPerfil.Text)
                    {

                        case "Administrado":

                            USU.perfil = 1;

                            break;

                        case "Operador":

                            USU.perfil = 2;

                            break;

                        case "Administrador":


                            USU.perfil = 3;

                            break;

                    }


                    int x = new UsuarioBLL().insereUsuario(USU);
                    if (x > 0) {

                        MessageBox.Show("gravado com sucesso");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("erro inesperado" + ex.Message);

                }


            }

            modo = "";
            carregaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = "alterar";

        }
    }


}

