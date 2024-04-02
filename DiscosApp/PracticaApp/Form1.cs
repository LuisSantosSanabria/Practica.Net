using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaApp
{
    public partial class Form1 : Form
    {
        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //invoco la base de datos lectura
            DiscosNegocio negocio = new DiscosNegocio();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos; //enlaza datos en clumnas
            cargarImagen(listaDiscos[0].UrlImagenTapa);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;// de la grilla /dame/ el objeto
            cargarImagen(seleccionado.UrlImagenTapa);
        }
        private void cargarImagen(string imagem)
        {
            try
            {
                pbxDiscos.Load(imagem);
            }
            catch (Exception ex)
            {
                pbxDiscos.Load("https://th.bing.com/th/id/OIP.F00dCf4bXxX0J-qEEf4qIQHaD6?rs=1&pid=ImgDetMain");
            }
        }
    }
}
