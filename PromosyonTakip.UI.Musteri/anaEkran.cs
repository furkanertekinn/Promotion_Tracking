﻿using PromosyonTakip.Core.businessLogicService;
using PromosyonTakip.Core.entities;
using PromosyonTakip.Core.helper;
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
                data.olusturmaTarih = DateTime.Now;


                int musteriKayit = servisPotansiyeMusteri.kayitYeni(data);
                if (musteriKayit > 0)
                {
                    MessageBox.Show("Kayıt işleminiz başarılı. Lütfen hediye seçiminizi yapınız",
                        "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HediyeSecimHazirla();
                }
                else
                {
                    MessageBox.Show("Sistemsel hata !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HediyeSecimHazirla()
        {
            List<promosyonUrun> hediyeUrunListesi = new List<promosyonUrun>();
            promosyonUrunServis servisPromosyon = new promosyonUrunServis();
            hediyeUrunListesi = servisPromosyon.urunListeGetir();
            if (hediyeUrunListesi != null && hediyeUrunListesi.Count > 0)
            {
                for (int i = 0; i < hediyeUrunListesi.Count; i++)
                {
                    PictureBox pctBox = new PictureBox();
                    pctBox.Width = 62;
                    pctBox.Height = 67;

                    pctBox.Image = Image.FromFile(@"C:\resimWindowsForms\gift.png");

                    pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctBox.Tag = hediyeUrunListesi[i];
                    pctBox.Click += PctBox_Click;
                    hediyePanel.Controls.Add(pctBox);
                }
            }
            else
            {
                MessageBox.Show("Kampanya Bitmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PctBox_Click(object sender, EventArgs e)
        {
            PictureBox secilenHediye = (PictureBox)sender;
            promosyonUrun kazanilanUrun = (promosyonUrun)secilenHediye.Tag;
            if (kazanilanUrun != null && kazanilanUrun.id > 0)
            {
                katilimciPromosyonServis servisKatilimci = new katilimciPromosyonServis();
                promosyonUrunServis servisPromosyon = new promosyonUrunServis();
                potansiyelMusteriServis servisPotansiyelMusteri = new potansiyelMusteriServis();

                servisPromosyon.urunKullanildiIsaretle(kazanilanUrun.id);
                servisKatilimci.kayitYeni(new katilimciPromosyon()
                {
                    magazaId = staticFieldList.magazaID,
                    olusturmaTarih = DateTime.Now,
                    promosyonUrunId = kazanilanUrun.id,
                    potansiyelMusteriId = servisPotansiyelMusteri.TCSorgula(txtTcKimlikNo.Text)
                });

                hediyeGoster hediyeGosterFrm = new hediyeGoster(kazanilanUrun);
                hediyeGosterFrm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kampanya Bitmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = staticFieldList.cinsiyetYukle();
        }
    }
}
