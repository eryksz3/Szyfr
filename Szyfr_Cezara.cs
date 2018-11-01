using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrCezara
{
    public partial class Szyfr_Cezara : Form
    {
        public Szyfr_Cezara()
        {
            InitializeComponent();
        }

        private void Odszyfruj_Click(object sender, EventArgs e)
        {
            string tbText = Zakodowany.Text;
            char[] bufor = tbText.ToCharArray();
            int przes = (int)Przesunięcie.Value;
            

            for (int i = 0; i < bufor.Length; i++)

            {
                char litera = bufor[i];

                if (litera == ' ' || litera == ',' || litera == '.')
                {
                    continue;
                }

                if ('A' <= litera && litera <= 'Z')
                {
                    litera = (char)(litera + przes);
                    if (litera > 'Z')
                    {
                        litera = (char)(litera - 26);
                    }
                    if (litera < 'A')
                    {
                        litera = (char)(litera + 26);
                    }
                }

                if ('a' <= litera && litera <= 'z')
                {
                    litera = (char)(litera + przes);
                    if (litera > 'z')
                    {
                        litera = (char)(litera - 26);
                    }
                    if (litera < 'a')
                    {
                        litera = (char)(litera + 26);
                    }
                }

                bufor[i] = litera;

            }
            
            Normalny.Text = new string(bufor);
        }
    }
         
}