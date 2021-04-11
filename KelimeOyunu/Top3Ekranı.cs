using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class Top3Ekranı : Form
    {
        public Top3Ekranı()
        {
            InitializeComponent();
            Veritabani.Top3Cek();
            top1Lbl.Text = Veritabani.isim1 + "-" + Veritabani.maxpuan;
            top2Lbl.Text = Veritabani.isim2 + "-" + Veritabani.maxpuan2;
            top3Lbl.Text = Veritabani.isim3 + "-" + Veritabani.maxpuan3;
        }

        
    }
}
