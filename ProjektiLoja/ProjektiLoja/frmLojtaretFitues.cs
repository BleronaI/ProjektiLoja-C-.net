using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiLoja
{
    public partial class frmLojtaretFitues : Form
    {
        public frmLojtaretFitues()
        {
            InitializeComponent();


            FillLojtari();
        }

        public void FillLojtari()
        {
            using (var context = new Model22())
            {
                var lojtaret = (from lojtari in context.LojtaretFitues

                                select new
                                {
                                    lojtari.EmriFitues
                                  


                                }).ToList();

                dgvLojtaretFitues.DataSource = lojtaret;

                dgvLojtaretFitues.AutoGenerateColumns = false;
  
            }
        }

      
    }


  

}
