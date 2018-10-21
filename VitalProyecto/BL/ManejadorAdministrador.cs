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
    }





}
