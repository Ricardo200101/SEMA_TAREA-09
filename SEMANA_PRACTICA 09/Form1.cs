using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA_PRACTICA_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creacion de la instacia de la clase escritor

            Escritor escritor = new Escritor();

            // Creacion del objecto

            escritor.setname("Alberto Masferrer");
            escritor.setcountry("EL SALVADOR");
            escritor.setdate("Vicente Alberto Masferrer Mónico (Alegría, antes Tecapa, 24 de julio de 1868-San Salvador, 4 de septiembre de 19323​) fue un maestro, filósofo, periodista, ensayista, poeta y político salvadoreño. Como escritor marcó con sus letras toda una época de la literatura salvadoreña a través de la definición de su pensamiento inclinado a la defensa de los más desposeídos y de denuncia social.");


            // Mostrar los datos del libro. 

            /*MessageBox.Show(
                 "DATOS DEL ESCRITOR\n" + 
                "\nNONBRE: " + escritor.getname() +
                " \nNACIONALIDAD: " + escritor.getcountry() +
                " \nDATOS: " + escritor.getdate ()
                ); 
            */
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Utilizado constructor

            Escritor escritor1 = new Escritor(textName.Text, textNacionalidad.Text, textDatos.Text);

            // Agregar datos a listbox

            listBox1.Items.Add("MEDIANTE COSTRUCTOR INICIALIZANDO LAS PROPIEDADES:\n " + escritor1.getEscritorInfor());

        }
    }
    }

