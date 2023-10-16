using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiLoja
{
    public partial class frmLojtari : Form
    {
        public frmLojtari()
        {
            InitializeComponent();
        }

        public void FillLojtari()
        {
            using (var context = new Model22())
            {
                var projketet = (from Lojtari in context.Lojtaris.AsNoTracking()
                                 orderby Lojtari.Id descending
                                 select new
                                 {
                                     Lojtari.Id,
                                     Lojtari.Emri,
                                     Lojtari.Mbiemri,
                                     Lojtari.LuajId,
                                     Lojtari.Qyteti,
                                     Lojtari.DataELindjes,
                     

                                 }).ToList();


                dgvLojtaret.DataSource = projketet;
                dgvLojtaret.AutoGenerateColumns = false;
            }
        }

        private void frmLojtari_Load(object sender, EventArgs e)
        {
            FillLojtari();
        }



        private void CleanAll()
        {
            txtEmri.Text = "";
            txtId.Text = "";
            txtMbiemri.Text = "";
            txtNumriPerLoje.Text = "";
            txtQyteti.Text = "";
        }


        public bool isValid()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Jepni Id");
                return false;
            }

            if (txtEmri.Text == "")
            {
                MessageBox.Show("Jepni Emrin");
                return false;
            }

            if (txtMbiemri.Text == "")
            {
                MessageBox.Show("Jepni Mbiemrin");
                return false;
            }

            if (txtQyteti.Text == "")
            {
                MessageBox.Show("Jepni Qytetin");
                return false;
            }


            DateTime dataLindjes = dtpDate.Value;
            DateTime dataAktuale = DateTime.Now;
            int mosha = dataAktuale.Year - dataLindjes.Year;

            
            if (mosha < 18)
            {
                MessageBox.Show("Personi duhet të jetë 18 vjeç ose më i madh.");
                return false;
            }

            return true;


           
        }


        public bool isEditing()
        {
            return dgvLojtaret.SelectedRows.Count > 0;
        }

        public int FindId()
        {
            return Convert.ToInt32(dgvLojtaret.SelectedRows[0].Cells["Id"].Value);
        }

      

        private void btnRegjistrohu_Click(object sender, EventArgs e)
        {
            using (var context = new Model22())
            {
                if (isValid())
                {
                    try
                    {
                        if (isEditing())
                        {
                            int lojtariId = FindId();

                            var lojtari = context.Lojtaris.FirstOrDefault(t => t.Id == lojtariId);

                            if (lojtari != null)
                            {
                                lojtari.Emri = txtEmri.Text;
                                lojtari.Mbiemri = txtMbiemri.Text;
                                lojtari.DataELindjes = DateTime.Parse(dtpDate.Text);
                                lojtari.Qyteti = txtQyteti.Text;
                                lojtari.Id = int.Parse(txtId.Text);
                               



                                context.SaveChanges();
                                MessageBox.Show("U editua");
                                FillLojtari();
                                CleanAll();
                            }
                        }

                        else
                        {
                            Lojtari lojtari1 = new Lojtari();
                            lojtari1.Emri = txtEmri.Text;
                            lojtari1.Mbiemri = txtMbiemri.Text;
                            lojtari1.DataELindjes = DateTime.Parse(dtpDate.Text);
                            lojtari1.Qyteti = txtQyteti.Text;
                            lojtari1.Id = int.Parse(txtId.Text);
                            lojtari1.LuajId = int.Parse(txtId.Text);
                            context.Lojtaris.Add(lojtari1);

                            context.SaveChanges();
                            MessageBox.Show("U shtua");
                            FillLojtari();
                            CleanAll();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Gabim" + ex.Message);
                    }
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            frmLuaj luajFrom = new frmLuaj();

            luajFrom.ShowDialog();
        }

        private void dgvLojtaret_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLojtaret.SelectedRows.Count)
            {
                DataGridViewRow selectedRow = dgvLojtaret.Rows[e.RowIndex];

                txtEmri.Text = selectedRow.Cells["Emri"].Value.ToString();
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtMbiemri.Text = selectedRow.Cells["Mbiemri"].Value.ToString();
                txtQyteti.Text = selectedRow.Cells["Qyteti"].Value.ToString();
                dtpDate.Text = selectedRow.Cells["DataELindjes"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLojtaretFitues lojtaretfitues = new frmLojtaretFitues();

            lojtaretfitues.ShowDialog();
        }
    }
}
