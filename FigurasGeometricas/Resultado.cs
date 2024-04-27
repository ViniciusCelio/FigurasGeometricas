using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util;

namespace FigurasGeometricas
{
    public partial class Resultado : Form
    {
        public Resultado(Forma objForma)
        {
            InitializeComponent();
            labelResultado.Text = objForma.Mostrar().resultadoStr;
            imgBoxResultado.Image = (Image)Properties.Resources.ResourceManager.GetObject(objForma.Mostrar().imgNome);
        }
    }
}
