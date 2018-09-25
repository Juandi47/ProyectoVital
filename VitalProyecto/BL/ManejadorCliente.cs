using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorCliente
    {
        DAOCliente clienteDAO = new DAOCliente();

        public List<Cliente> listaClientes()
        {
            List<TOCliente> listaTO = clienteDAO.ListaCliente();
            List<Cliente> listaBLCliente = new List<Cliente>();
            foreach (TOCliente toClient in listaTO)
            {
                listaBLCliente.Add(new Cliente(toClient.Cedula, toClient.Nombre, toClient.Apellido1,
                    toClient.Apellido2, toClient.Clave, toClient.Fecha_Nacimiento, 
                    toClient.Telefono, toClient.Correo, toClient.Observacion));
            }
            return listaBLCliente;
        }
    }
}
