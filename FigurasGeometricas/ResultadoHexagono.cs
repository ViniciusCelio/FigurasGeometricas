﻿using System;
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
    public partial class ResultadoHexagono : Form
    {
        public ResultadoHexagono(Forma objForma)
        {
            InitializeComponent();
            labelResultadoHexagono.Text = objForma.Mostrar();
        }
    }
}
