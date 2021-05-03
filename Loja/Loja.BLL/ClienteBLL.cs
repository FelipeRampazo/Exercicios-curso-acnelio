using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
  public  class ClienteBLL
    {

        public IList<ClienteDTO> cargaCliente()
        {

            try{

                return new ClienteDAL().cargaCliente();

            }

            catch(Exception ex)
            {
                throw ex;
            }
        





        }











    }
}
