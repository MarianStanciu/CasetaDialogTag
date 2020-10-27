using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDialogTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfiseazaMesaj();
        }
        private void AfiseazaMesaj()
        {
            DialogResult res = CasetaDialog.AfiseazaMesaj("Marian stanciu", "afisare proba", CasetaDialog.ButonMesaj.Ok,  CasetaDialog.ButonMesaj.Anuleaza, CasetaDialog.IconitaMesaj.Intrebare);
            switch (res)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    CasetaDialog.AfiseazaMesaj("ia de aici", "nu vreau",CasetaDialog.ButonMesaj.Ok);
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("ai selectat Anuleaza");
                    break;
                case DialogResult.Abort:
                    MessageBox.Show("ai selectat Abort");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("ai selectat Retry");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("ai selectat Ignora");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("ai selectat DA");
                    break;
                case DialogResult.No:
                    MessageBox.Show("ai selectat NU");
                    break;
                default:
                    break;
            }
        }
    }
}
