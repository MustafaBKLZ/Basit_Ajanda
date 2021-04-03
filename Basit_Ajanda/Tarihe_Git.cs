using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basit_Ajanda
{
    public partial class Tarihe_Git : Form
    {
        public Tarihe_Git()
        {
            InitializeComponent();
        }
        public DateTime Tarih = DateTime.Now;
        public int Devam = 0;
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            Devam = 1;
            Tarih = Convert.ToDateTime(dateTimePicker1.Value);
            Close();
        }
    }
}
