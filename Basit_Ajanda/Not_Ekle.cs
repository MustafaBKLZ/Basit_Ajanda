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
    public partial class Not_Ekle : Form
    {
        public Not_Ekle()
        {
            InitializeComponent();
        }
        private void Not_Ekle_Load(object sender, EventArgs e)
        {
           
            not_oku();
        }
        void not_oku()
        {
            if (Convert.ToInt32(txt_kayit_no.Text) > 0)
            {
                DataTable dt = Cls.SQLConnectionClass.Table("select not_RECno, not_Baslik, not_Icerik from NOTLAR  where not_RECno = " + Convert.ToInt32(txt_kayit_no.Text) + " ");
                txt_baslik.Text = dt.Rows[0]["not_Baslik"].ToString();
                txt_icerik.Text = dt.Rows[0]["not_Icerik"].ToString();
            }
            else
            {
                
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_kayit_no.Text) == 0)
            {
                Cls.SQLConnectionClass.Command(""
                          + "      INSERT INTO [dbo].[NOTLAR] "
                          + "             ([not_KayitTarih] "
                          + "             ,[not_Baslik] "
                          + "             ,[not_Tarih] "
                          + "             ,[not_Icerik]) "
                          + "       VALUES "
                          + "             ( getdate() "
                          + "             ,'" + txt_baslik.Text + "'"
                          + "             ,'" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyyMMdd HH:mm") + "'"
                          + "             ,'" + txt_icerik.Text + "') "
                                ); // bu insert komutu şu şekilde alınabiliyor.
                if (Cls.SQLConnectionClass.exception == null)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    Close();
                }
            }
            else
            {

                Cls.SQLConnectionClass.Command(""
                      + "     update [dbo].[NOTLAR]  set "
                      + "              not_DegistirmeTarih = getdate()  "
                      + "             ,[not_Baslik] = '" + txt_baslik.Text + "' "
                      + "             ,[not_Icerik] = '" + txt_icerik.Text + "' "
                      + "             ,[not_Tarih] = '" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyyMMdd HH:mm") + "' "
                      + "       where not_RECno = " + Convert.ToInt32(txt_kayit_no.Text) + " "

                            ); // not_DegistirmeTarih sonradan ekşlediğim bir kolondur.
                if (Cls.SQLConnectionClass.exception == null)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    Close();
                }
                // bir keydetme denemesi yaptım. sql connection class çalışlıypor. :)
            }


            // Bu tarihi bu şekilde yapmamızın nedeni insert yöntemimizde parametre kullanmıyor oluşumuzdandır. 
            // Bu yöntemle insert yapabilmek için sql'e yukarıdaki gibi göndermemiz gerekiyor.
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            Cls.SQLConnectionClass.Command("delete from [dbo].[NOTLAR]    where not_RECno = " + Convert.ToInt32(txt_kayit_no.Text) + " ");
            if (Cls.SQLConnectionClass.exception == null)
            {
                MessageBox.Show("Silme Başarılı");
                Close();
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
            // cancel button u çıkış butonu seçtiğimiz için ESC tuşuna bastığımızda form kapanacaktır.
        }
    }
}
