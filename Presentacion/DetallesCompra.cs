using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class DetallesCompra : Presentacion.Metro_Template
    {
        Compra c;

        /// TODO: HACER ESTO

        public DetallesCompra(Compra C)
        {
            InitializeComponent();
            c = C;
        }
    }
}
