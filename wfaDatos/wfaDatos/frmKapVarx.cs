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
    public partial class frmKapVarx : Form
    {
        public frmKapVarx()
        {
            InitializeComponent();
        }
        private void frmKapVarx_load(Object sender, EventArgs e)
        {
            string oDatos = Microsoft.VisualBasic.Interaction.InputBox("Digite Valores: ");
            MessageBox.Show(oDatos);    
        }

    }
}

