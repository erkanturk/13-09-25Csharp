using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HesapMakinesi
{
    public partial class Login : Form
    {
        public Login()
        { /// <summary>
          /// 
          /// </summary>
          ///<see href="https://coderspace.io/mulakat-sorulari/"/>
          /// <param name="sender"></param>
          /// <param name="e"></param>
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Kullanici.Text=="Admin"&&txt_Sifre.Text=="1453")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
                if (form1.Soru()==DialogResult.Yes)
                {
                    form1.mtxt_sayi1.Visible=true;
                    form1.mtxt_sayi2.Visible=true;
                    form1.label1.Visible=true;
                    form1.label2.Visible=true;
                    form1.label3.Visible=true;
                    form1.cmb_Islem.Visible=true;
                    form1.lst_sonuc.Visible=true;
                    form1.btn_Islem.Visible =true;
                    form1.btn_Temizle.Enabled=true;
                }
                else
                {
                    form1.mtxt_sayi1.Visible=false;
                    form1.mtxt_sayi2.Visible=false;
                    form1.label1.Visible=false;
                    form1.label2.Visible=false;
                    form1.label3.Visible=false;
                    form1.cmb_Islem.Visible=false;
                    form1.lst_sonuc.Visible=false;
                    form1.btn_Islem.Visible =false;
                    form1.btn_Temizle.Enabled=false;
                }
            }
        }
    }
}
