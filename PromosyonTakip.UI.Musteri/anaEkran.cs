using PromosyonTakip.Core.businessLogicService;
using PromosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromosyonTakip.UI.Musteri
{
    public partial class anaEkran : Form
    {
        potansiyelMusteri data;
        public anaEkran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox musteriBilgileri = (GroupBox)this.Controls["gpMusteriBilgileri"];
            foreach (Control item in musteriBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            potansiyelMusteriServis servisPotansiyeMusteri = new potansiyelMusteriServis();
            int tcKontrol = servisPotansiyeMusteri.TCSorgula(txtTcKimlikNo.Text);
            if (tcKontrol > 0)
            {
                MessageBox.Show("Daha önce kayıt oldunuz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                data = new potansiyelMusteri();
                data.tcKimlikNumara = txtTcKimlikNo.Text;
                data.isim = txtIsim.Text;
                data.soyisim = txtSoyisim.Text;
                data.dogumTarih = txtDogumTarih.Value;
                data.cinsiyet = ((cinsiyet)cmbCinsiyet.SelectedItem).id;
                data.meslek = txtMeslek.Text;
                data.emailAdres = txtEposta.Text;
                data.emailBildirimOnay = chkEpostaOnay.Checked;
                data.telefon = txtTelefon.Text;
                data.telefonBildirimOnay = chkSmsOnay.Checked;

                int musteriKayit = servisPotansiyeMusteri.kayitYeni(data);
                if (musteriKayit > 0)
                {
                    MessageBox.Show("Kayıt işleminiz başarılı. Lütfen hediye seçiminizi yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sistemsel hata !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
