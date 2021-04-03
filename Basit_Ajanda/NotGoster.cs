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
    public partial class NotGoster : UserControl
    {
        public NotGoster()
        {
            InitializeComponent();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            Not_Ekle fr = new Not_Ekle();
            fr.txt_kayit_no.Text = lbl_id.Text;
            fr.ShowDialog();
            // buradaki sıkıntımız güncellemeden sonra son halini ekrana yazmaması. Şimdi bir yöntemi deneyelim.

            lbl_Baslik.Text = fr.txt_baslik.Text;
            rtxt_icerk.Text = fr.txt_icerik.Text;
            // istediğimiz gibi oldu. O yüzden sıkıntı yok :)

        }
    }
}
