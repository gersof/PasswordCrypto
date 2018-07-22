using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCrypto
{
    public partial class PasswordCryptoForm : Form
    {
        private CryptoUtilities crypto = new CryptoUtilities();
        public PasswordCryptoForm()
        {
            InitializeComponent();            
        }

        private void encriptarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordSEIn.Text))
                notificacionLbl.Text = "Ingrese valor en el campo de la izquierda";
            else
                txtPasswordCEOut.Text = crypto.Encriptar(txtPasswordSEIn.Text);                     
        }

        private void DesencriptarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordCEIn.Text))
                notificacionLbl.Text = "Ingrese valor en el campo de la izquierda";
            else
                txtPasswordSEOut.Text = crypto.Desencriptar(txtPasswordCEIn.Text);   
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtPasswordCEIn.Text = string.Empty;
            txtPasswordCEOut.Text = string.Empty;
            txtPasswordSEIn.Text = string.Empty;
            txtPasswordSEOut.Text = string.Empty;
            notificacionLbl.Text = string.Empty;
        }
    }
}
