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
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
            lblidPers.Text = "Identificacion: ";
            btnAdd.Text = "Adicionar";
            txtnomPers.Focus();
            lblnomPers.Text = "Nombres: ";
            grBpersonas.Enabled = false;


        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            txtnomPers.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grBpersonas.Enabled=true;   
            txtidPers.Focus();
            if(btnAdd.Text.Equals("Adicionar")  || btnAdd.Text.Equals("a"))
                    {
                btnAdd.Text="Guardar";
                ttp1.IsBalloon = true;
                ttp1.Equals(btnAdd.Text);

            }else if(btnAdd.Text.Equals("Guardar") || btnAdd.Text.Equals("G"))
                {
                btnAdd.Text = "Adicionar";
                ttp1.Equals(btnAdd.Text);
                grBpersonas.Enabled=false;
                MessageBox.Show("id: " + txtidPers.Text + " \nNombres: " + txtnomPers.Text);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
    