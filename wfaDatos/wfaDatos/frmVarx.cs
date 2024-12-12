using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfaDatos
{
    public partial class frmVarx : Form

    {
        private static int idPers = 7896;
        public static String nomPers = "jheison castillo";

        public frmVarx()
        {
            InitializeComponent();
        }
        private void frmVarx_load(Object sender, EventArgs e)
        {
            this.Text = "Datos personales";
            MessageBox.Show("\nId: " + idPers + "\nNombre: " + nomPers, "Datos personales");
        }

    }
}