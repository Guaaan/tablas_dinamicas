using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas_Dinamicas
{
    class Productos
    {
        private int id;
        private string codigo;
        private string nombre;
        private string description;
        private double precio_publico;
        private int existencias;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Description { get => description; set => description = value; }
        public double Precio_publico { get => precio_publico; set => precio_publico = value; }
        public int Existencias { get => existencias; set => existencias = value; }
    }
}
