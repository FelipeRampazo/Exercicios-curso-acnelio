using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
    public class UsuarioDAL
    {

        public IList<UsuarioDTO> cargaUsuario() {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT * FROM tb_usuarios";

                cm.Connection = con;

                SqlDataReader  er;

                IList<UsuarioDTO> listUsuaroDTO = new List<UsuarioDTO>();

                con.Open();
                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    while (er.Read()) {



                        UsuarioDTO usu = new UsuarioDTO();

                        usu.cod_usuario = Convert.ToInt32(er["cod_usuario"]);
                        usu.perfil = Convert.ToInt32(er["perfil"]);
                        usu.cadastro = Convert.ToDateTime(er["cadastro"]);
                        usu.nome = Convert.ToString(er["nome"]);
                        usu.login = Convert.ToString(er["login"]);
                        usu.email = Convert.ToString(er["email"]);
                        usu.senha = Convert.ToString(er["senha"]);
                        usu.situacao = Convert.ToString(er["situacao"]);

                        listUsuaroDTO.Add(usu);





                    }



                }
                return listUsuaroDTO;




            }

            catch (Exception ex) {

                throw ex;

            }

            }

        public int insereUsuario(UsuarioDTO USU)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;

                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Insert into tb_usuarios (nome, login, email, senha, cadastro, situacao, perfil) " +
                    "VALUES (@nome, @login, @email, @senha, @cadastro, @situacao, @perfil )";

                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = USU.login;
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = USU.email;
                cm.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = USU.senha;
                cm.Parameters.Add("cadastro", System.Data.SqlDbType.DateTime).Value = USU.cadastro;
                cm.Parameters.Add("situacao", System.Data.SqlDbType.VarChar).Value = USU.situacao;
                cm.Parameters.Add("perfil", System.Data.SqlDbType.NVarChar).Value = USU.perfil;

                cm.Connection = con;
                con.Open();

               
                int qtd = cm.ExecuteNonQuery();

                return qtd;
            }

            catch (Exception ex)
            {

                throw ex;

            }





        }

        public int editarUsuario(UsuarioDTO USU)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "UPDATE tb_usuarios SET perfil = @perfil," + "nome = @nome," + " login = @login,"
                    +"email = @email" + "senha = @senha," + "cadastro = @cadastro," + "situacao = @situacao" + "where cod_usuario = @cod_usuario";

                cm.Parameters.Add("perfil", System.Data.SqlDbType.Int).Value = USU.perfil;
                cm.Parameters.Add("nome", System.Data.SqlDbType.Int).Value = USU.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.Int).Value = USU.login;
                cm.Parameters.Add("email", System.Data.SqlDbType.Int).Value = USU.email;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Int).Value = USU.senha;
                cm.Parameters.Add("cadastro", System.Data.SqlDbType.Int).Value = USU.cadastro;
                cm.Parameters.Add("situacao", System.Data.SqlDbType.Int).Value = USU.situacao;

                con.Open();

                int qtd = cm.ExecuteNonQuery();
                return qtd;


            }

            catch(Exception ex)
            {

                throw ex;
            }




        }


        public int deletarUsuario(UsuarioDTO USU)
        {
            try {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "DELETE FROM tb_usuarios where cod_usuario = @cod_usuario";

                cm.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = USU.cod_usuario;


                con.Open();
                int qtd = cm.ExecuteNonQuery();

                return qtd;


            }
            catch(Exception ex)
            {

                throw ex;

            }

        }

        







    }
}
