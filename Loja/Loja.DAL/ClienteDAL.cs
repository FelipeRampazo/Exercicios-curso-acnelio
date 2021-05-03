using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
    public class ClienteDAL
    {
        public IList<ClienteDTO> cargaCliente() { 

            try
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT * FROM tb_cliente ";
                cm.Connection = con;

                SqlDataReader er;

                IList<ClienteDTO> listClienteDTO = new List<ClienteDTO>();

                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {

                    while(er.Read())
                    {
                        ClienteDTO cli = new ClienteDTO();

                        cli.cod_cliente = Convert.ToInt32(er["cod_cliente"]);
                        cli.nome = Convert.ToString(er["nome"]);
                        cli.endereco = Convert.ToString(er["endereco"]);
                        cli.cidade = Convert.ToString(er["cidade"]);
                        cli.telefone = Convert.ToString(er["telefone"]);
                        cli.situacao = Convert.ToString(er["situacao"]);

                        listClienteDTO.Add(cli);




                    }







                }

               return listClienteDTO;


        }


            catch(Exception ex)
            {
                throw ex;
            }
                

            }
    }
}
