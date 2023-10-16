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
    public partial class frmLuaj : Form
    {
        public frmLuaj()
        {
            InitializeComponent();
            cbLojtari.SelectedIndexChanged += new EventHandler(cbLojtari_SelectedIndexChanged);

        }

        private void cbLojtari_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillLuaj();
        }


        private void frmLuaj_Load(object sender, EventArgs e)
        {
           
            FillZgjedhja();
            FillLuaj();
         
        }


        private List<int> GenerateRandomNumbers()
        {
            List<int> numbers = new List<int>();

            if (isValid())
            {
                Random random = new Random();

                while (numbers.Count <= 7)
                {
                    int randomNumber = random.Next(1, 39 + 1);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        lstNumratFitues.Items.Add(randomNumber);
                    }
                }
            }

            return numbers;
        }



        public void FillZgjedhja(string searchText = null)
        {
            using (var context = new Model22())
            {
                var numrat = (from Lojtari in context.Lojtaris
                             
                              select new { Lojtari.Emri, Lojtari.LuajId }).ToList();
                

                cbLojtari.DataSource = numrat;
                cbLojtari.ValueMember = "LuajId";
                cbLojtari.DisplayMember = "Emri";
            }

           
        }


        public int GetLuajIdBySelectedEmri()
        {
            string selectedEmri = cbLojtari.Text; 

            using (var context = new Model22())
            {
                var lojtari = context.Lojtaris.SingleOrDefault(l => l.Emri == selectedEmri);
                if (lojtari != null)
                {
                    return lojtari.LuajId;
                }
                else
                {
                    return -1; 
                }
            }
        }



        public void FillLuaj()
        {
            using (var context = new Model22())
            {
                int luajId = GetLuajIdBySelectedEmri();

                Console.WriteLine("Selected Lojtari ID: " + luajId);

                var luaj = (from LuajLojen in context.LuajLojens
                            where LuajLojen.LojtariId == luajId
                            select new 
                            { 
                            LuajLojen.Numri_i_pare,
                            LuajLojen.Numri_i_dyte,
                            LuajLojen.Numri_i_trete,
                            LuajLojen.Numri_i_katert,
                            LuajLojen.Numri_i_peste,
                            LuajLojen.Numri_i_gjashte,
                            LuajLojen.Numri_i_shtate
                            }).ToList();

            

                IstNumratEPerzgjedhur.DataSource = luaj;
                Console.WriteLine("Number of matching records: " + luaj.Count);

            }


        }

        public void CleanAll()
        {

            txtNumri1.Text = "";
            txtNumri2.Text = "";
            txtNumri3.Text = "";
            txtNumri4.Text = "";
            txtNumri5.Text = "";
            txtNumri6.Text = "";
            txtNumri7.Text = "";

            lstNumratFitues.Items.Clear();

        }

   
    

            public bool isValid()
            {


            if (txtNumri1.Text == "")
            {
                MessageBox.Show("Jepni numri 1");
                return false;
            }

            if (txtNumri2.Text == "")
            {
                MessageBox.Show("Jepni numri 2");
                return false;
            }


            if (txtNumri3.Text == "")
            {
                MessageBox.Show("Jepni numri 3");
                return false;
            }
            if (txtNumri4.Text == "")
            {
                MessageBox.Show("Jepni numri 4");
                return false;
            }
            if (txtNumri5.Text == "")
            {
                MessageBox.Show("Jepni numri 5");
                return false;
            }
            if (txtNumri6.Text == "")
            {
                MessageBox.Show("Jepni numri 6");
                return false;
            }

            if (txtNumri7.Text == "")
            {
                MessageBox.Show("Jepni numri 7");
                return false;
            }

            return true;
            }


        



        public bool KrahasoListat(List<int> lista1, List<int> lista2)
        {
            int numratEPërbashkët = lista1.Count(numri => lista2.Contains(numri));

            if (numratEPërbashkët >= 3)
            {
                return true;
            }

            return false;
        }





        private void btnLuaj_Click(object sender, EventArgs e)
        {
            using (var context = new Model22())
            {
                if (isValid())
                {
                    try
                    {
                        int luajId = GetLuajIdBySelectedEmri();
                        Console.WriteLine("Selected Lojtari ID: " + luajId);


                       
                        List<int> numratEPerzgjedhur = new List<int>
                        {
                            int.Parse(txtNumri1.Text),
                            int.Parse(txtNumri2.Text),
                            int.Parse(txtNumri3.Text),
                            int.Parse(txtNumri4.Text),
                            int.Parse(txtNumri5.Text),
                            int.Parse(txtNumri6.Text),
                            int.Parse(txtNumri7.Text)
                        };

                        bool jeFitues = KrahasoListat(numratEPerzgjedhur, GenerateRandomNumbers());

                        if (jeFitues)
                        {
                            string mesazhi = $"Fituesi është Emri: {cbLojtari.Text} me numrat: {string.Join(", ", numratEPerzgjedhur)}";
                            lblRezultati.Text = mesazhi;
                            
                            
                            LojtaretFitue fituesi = new LojtaretFitue();
                            fituesi.EmriFitues = cbLojtari.Text;
                            context.LojtaretFitues.Add(fituesi);
                            context.SaveChanges();
                        }
                        else
                        {
                            lblRezultati.Text = "Ju deshirojmë fat në herat e tjera";
                        }

                        Console.WriteLine("Selected Lojtari ID: " + luajId);

                             LuajLojen loja = new LuajLojen();
                            loja.Numri_i_pare = int.Parse(txtNumri1.Text);
                            loja.Numri_i_dyte = int.Parse(txtNumri2.Text);
                            loja.Numri_i_trete = int.Parse(txtNumri3.Text);
                            loja.Numri_i_katert = int.Parse(txtNumri4.Text);
                            loja.Numri_i_peste = int.Parse(txtNumri5.Text);
                            loja.Numri_i_gjashte = int.Parse(txtNumri6.Text);
                            loja.Numri_i_shtate = int.Parse(txtNumri7.Text);
                            loja.LojtariId= luajId;

                            context.LuajLojens.Add(loja);

                            context.SaveChanges();
                            MessageBox.Show("U shtuan zgjedhjet");
                            FillLuaj();
                            CleanAll(); 



                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Gabim" + ex.Message);
                    }
                }
            }
            List<int> generatedNumbers = GenerateRandomNumbers();


        }



   


        private void frmLuaj_Leave(object sender, EventArgs e)
        {
            
        }

       
    }



}
