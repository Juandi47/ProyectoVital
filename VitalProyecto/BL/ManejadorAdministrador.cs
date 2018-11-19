using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorAdministrador
    {
        DAOAdministrador administradorDAO = new DAOAdministrador();

        public List<Administrador> listaAdministrador()
        {
            List<TOAdministrador> listaTO = administradorDAO.ListaAdministrador();
            List<Administrador> listaBLAdministrador = new List<Administrador>();
            foreach (TOAdministrador toAdministrador in listaTO)
            {
                listaBLAdministrador.Add(new Administrador(toAdministrador.Cedula, toAdministrador.Nombre,
                    toAdministrador.Clave, toAdministrador.Apellido1, toAdministrador.Apellido2));
            }
            return listaBLAdministrador;
        }




        public string agregarAdministrador(string cedula, string nombre, string clave, string apellido1, string apellido2) {
            return administradorDAO.agregarAdmin(new TOAdministrador( cedula, nombre, clave, apellido1, apellido2));
        }


        public string modificarAdmin(string cedula, string nombre, string clave, string apellido1, string apellido2) {
            string mensaje = administradorDAO.modificarAdmin(new TOAdministrador(cedula, nombre, clave, apellido1, apellido2));
            return mensaje;

        }


        public void eliminarAdministrador(string cedula) {
           int eliminado = administradorDAO.eliminarAdmin(cedula);
            if (eliminado > 1)
            {
                //eliminado
            }
            else {
                if (eliminado < 1)
                {
                    //error de ejecucion
                }
                else {
                    //NonSerializedAttribute es posible eliminar as
                }
            }
        }

        public Administrador consultaAdministrador(string cedula) {

            TOAdministrador admin = administradorDAO.consultaAdmin(cedula);
            Administrador administrador = new Administrador(admin.Cedula, admin.Nombre, admin.Apellido1, admin.Apellido2, admin.Clave);

            return administrador;
        }


    }





}
