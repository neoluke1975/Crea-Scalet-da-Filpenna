using System;
using System.Windows.Forms;
using System.IO;

namespace Crea_Scalet_da_Filpenna
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "ciao", "ciao",ToolTipIcon.Info);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F10)
            {
                this.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string riga;
            try
            {
                using (StreamReader lettore = new StreamReader("c:/lettore/filpenna.txt"))

                {
                    using (StreamWriter scrivi_riga = new StreamWriter("c:/lettore/scalet.txt"))
                    {
                        while ((riga = lettore.ReadLine()) != null)
                        {


                            string scrivi = ((riga.Replace("C   ", "")).Replace("   ", "*"));
                            scrivi_riga.WriteLine(scrivi);

                        }
                    }


                }
            }
            catch (Exception)
            {

               
            }
            if (File.Exists("c:/lettore/filpenna.txt"))
            {
                File.Delete("c:/lettore/filpenna.txt");
            }
        }
    }
}
