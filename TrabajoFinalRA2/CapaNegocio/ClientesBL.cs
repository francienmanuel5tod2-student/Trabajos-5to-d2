using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class ClientesBL
    {
        ClientesDAL dal = new ClientesDAL(); // 👈 AQUÍ está la clave

        public List<Cliente> Listar()
        {
            return dal.Listar();
        }
    }
}

