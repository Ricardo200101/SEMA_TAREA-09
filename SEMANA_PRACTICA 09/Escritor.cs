using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_PRACTICA_09
{
    class Escritor
    {
        // DEFINICIO DE LOS MIEMBROS DE LA CLASES
        // PROPIEDADES. 

        private string _name;
        private string _date;
        private string _country;

        // METODO CONSTRUTOR. 

        public Escritor() // Metodo vacio 
        {

        }

        // Soporte de sobrecarga de construtor. 
        public Escritor(string name, string country, string date)
        {
            _name = name;
            _country = country;
            _date = date;
        }



        // Metodos de propiedad. 

        // get
        // Obtiene el nombre del escritor. 

        public string getname()
        {
            return _name;
        }


        // set 

        public void setname(string name)
        {
            _name = name;
        }

        // Obtiene la fecha de nacimiento/defuncion del actor.

        public string getdate()
        {
            return _date;
        }

        public void setdate(string date)
        {
            _date = date;
        }

        public string getcountry()
        {
            return _country;

        }

        public void setcountry(string country)
        {
            _country = country;
        }

        // Metodo para mostrar la informacion del libro 

        public string getEscritorInfor()
        {
            return "NOMBRE: " + _name + " NACIONALIDAD: " + _country + " DATOS: " + _date;
        }
    }
}
