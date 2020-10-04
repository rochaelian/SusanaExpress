using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susana.Entity
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
      //  [Display(Name = "Apelido Materno")]
        private string apUno;

        private string apDos;
        private string direccion;
        private string telefono;
        private List<Venta> ventas;
        private int estado;

        public int Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
  //      [Display(Name = "Codigo")]
        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }
    //    [Required(ErrorMessage = "Este Campo es Requerido")]
     //   [Display(Name = "Nombre")]
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    //    [Required(ErrorMessage = "Este Campo es Requerido")]
    //    [Display(Name = "Apelido Materno")]
        public string ApUno
        {
            get
            {
                return apUno;
            }

            set
            {
                apUno = value;
            }
        }
       // [Required(ErrorMessage = "Este Campo es Requerido")]
       // [Display(Name = "Aoellido Paterno")]
        public string ApDos
        {
            get
            {
                return apDos;
            }

            set
            {
                apDos = value;
            }
        }

        //[Display(Name = "Dirección")]
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }
        //[Required(ErrorMessage = "Este Campo es Requerido")]
        //[Display(Name = "Telefóno")]
        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
        //[Required(ErrorMessage = "Este Campo es Requerido")]
        public List<Venta> Ventas
        {
            get
            {
                return ventas;
            }

            set
            {
                ventas = value;
            }
        }

        public Cliente()
        {

        }
        public Cliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public Cliente(int idCliente, string nombre, string apuno, string apdos, string direccion, string telefono)
        {
            this.idCliente = idCliente;
            this.Nombre = nombre;
            this.apUno = apuno;
            this.apDos = apdos;
            this.Direccion = direccion;
            this.Telefono = telefono;
        } 

    }
}
