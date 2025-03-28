using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesSortedListDictionary_IvánRodríguez
{
    internal class Superheroe
    {

        private String nombre;
        private String descripcion;
        private bool capa;

        public Superheroe(String nombre) { 
        
            this.nombre = nombre;
        
        }

        public Superheroe(String nombre, String descripcion, bool capa) 
        { 
        
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.capa = capa;

        }

        public String Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Descripcion 
        { 
            get { return descripcion; } 
            set { descripcion = value; } 
        }

        public bool Capa 
        { 
            get { return capa; } 
            set { capa = value; } 
        }

        public override String ToString() {

            return $"Nombre: {this.nombre} |-| Descripción: {this.descripcion} |-| ¿Tiene capa? {this.capa}";    
        
        }

        public String ToStringList() {

            return $"Descripcion: {this.descripcion} ¿Tiene capa? {this.capa}";
        
        }

    }
}
