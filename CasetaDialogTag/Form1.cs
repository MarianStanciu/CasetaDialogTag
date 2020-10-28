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
          //  AfiseazaMesaj();
           CasetaDialog.AfiseazaMesaj("Adrian", "Afisare Adrian",CasetaDialog.ButonMesaj.Ok, CasetaDialog.ButonMesaj.Nimic, CasetaDialog.ButonMesaj.Anuleaza, CasetaDialog.IconitaMesaj.Eroare);
        }


        private void AfiseazaMesaj()
        {
            DialogResult res = CasetaDialog.AfiseazaMesaj("Marian stanciu", "afisare proba", CasetaDialog.ButonMesaj.Ok,  CasetaDialog.ButonMesaj.Reincearca,CasetaDialog.ButonMesaj.Anuleaza, CasetaDialog.IconitaMesaj.Informare);
            switch (res)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    CasetaDialog.AfiseazaMesaj("ia de aici", "nu vreau",CasetaDialog.ButonMesaj.Ok);
                    break;
                case DialogResult.Cancel:
                    CasetaDialog.AfiseazaMesaj("ai selectat Anuleaza");
                    break;
                case DialogResult.Abort:
                    MessageBox.Show("ai selectat Abort");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("ai selectat Reincearca");
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
