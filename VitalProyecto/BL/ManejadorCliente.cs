
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class ManejadorCliente
    {
		public ManejadorCliente()
		{

		}

        DAOCliente clienteDAO = new DAOCliente();

		public List<Cliente> listaClientes()
        {
            List<TOCliente> listaTO = clienteDAO.ListaCliente();
            List<Cliente> listaBLCliente = new List<Cliente>();
            foreach (TOCliente toClient in listaTO)
            {
                Cliente c = new Cliente();
                c.Cedula = toClient.Cedula;
                c.Nombre = toClient.Nombre;
                c.Apellido1 = toClient.Apellido1;
                c.Apellido2 = toClient.Apellido2;
                c.Fecha_Mensualidad = toClient.Fecha_Mensualidad;
                c.Telefono = toClient.Telefono;

                listaBLCliente.Add(c);

                //listaBLCliente.Add(new Cliente(toClient.Cedula, toClient.Nombre, toClient.Apellido1,
                //    toClient.Apellido2, toClient.Fecha_Nacimiento, 
                //    toClient.Telefono, toClient.Correo, toClient.Observacion));
            }
            return listaBLCliente;
        }


        public Cliente verificarClienteBL(Cliente cliente) {

            Boolean exist = clienteDAO.verificarCliente(cliente.Cedula);

            if (!exist)
            {
                TOCliente clienteTO = clienteDAO.filtrarDatosCliente(cliente.Cedula);
                cliente = parsearClienteTO(clienteTO);
            }
            else {
                cliente.Cedula = "!";
            }
            return cliente;
        }

        //public Cliente verificarClienteBLMod(Cliente cliente)
        //{

        //    Boolean exist = clienteDAO.verificarCliente(cliente.Cedula);

        //    if (!exist)
        //    {
        //        TOCliente clienteTO = clienteDAO.filtrarDatosCliente(cliente.Cedula);
        //        cliente = parsearClienteTO(clienteTO);
        //    }
        //    else
        //    {
        //        cliente.Cedula = "!";
        //    }
        //    return cliente;
        //}


        public Boolean registrarClienteBL(Cliente c) {

            if (c.Cedula.Equals("") || c.Nombre.Equals("")) {
                return false;
            }

            TOCliente cliente = new TOCliente(c.Cedula, c.Nombre, c.Apellido1, c.Apellido2, c.Fecha_Nacimiento, c.Telefono,c.Correo, c.Observacion);
            return clienteDAO.registrarClienteDAO(cliente);
        }

        //public void llenarPersona() {
        //    Class1 c = new Class1();
        //    c.ActualizarRegistroPersona();
        //}


        private Cliente parsearClienteTO (TOCliente tocliente) {
            Cliente c = new Cliente
            {
                Cedula = tocliente.Cedula,
                Nombre = tocliente.Nombre,
                Apellido1 = tocliente.Apellido1,
                Apellido2 = tocliente.Apellido2
            };

            return c;
        }

		public Cliente buscarCliente(string cedula)
		{
			TOCliente clienTO = clienteDAO.buscarCliente(cedula);
			if (clienTO == null)
			{
				return null;
			}
			return new Cliente(clienTO.Cedula, clienTO.Nombre, clienTO.Apellido1, 
				clienTO.Apellido2, clienTO.Fecha_Nacimiento, clienTO.Telefono, clienTO.Correo,
				clienTO.Observacion, clienTO.Fecha_Mensualidad);
		}

        public bool modificarCliente(String ced, String corr, String obs, int tel, String clave)
        {
            //TOCliente clienTO = new TOCliente(cliente.Cedula, cliente.Nombre, cliente.Apellido1,
            //    cliente.Apellido2, cliente.Fecha_Nacimiento, cliente.Telefono, cliente.Correo,
            //    cliente.Observacion, cliente.Fecha_Mensualidad);
            return clienteDAO.modificarClienteDAO(ced,corr,obs, tel, clave);
        }
    

        public Boolean existeCliente(string correo) {
            return clienteDAO.existeCliente(correo);
        }

        public void eliminarCliente(string id, string correo)
        {
            clienteDAO.eliminarCliente(id,correo);
        }
    }
}
