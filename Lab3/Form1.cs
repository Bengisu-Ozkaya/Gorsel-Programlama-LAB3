namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDers_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = textBoxAd.Text;
            ogrenci1.Soyad = textBoxSoyad.Text;
            ogrenci1.Ders = textBoxDers.Text;

            listBox1.Items.Clear();
            listBox1.Items.Add("** OGRENCI BILGILERI **");
            listBox1.Items.Add($"Adý ={ogrenci1.Ad} Soyadý ={ogrenci1.Soyad} Dersi ={ogrenci1.Ders} ");

            Notlar not = new Notlar();
            
            not.sinav1 = Convert.ToInt16(textBoxSinav1.Text);
            not.sinav2 = Convert.ToInt16(textBoxSinav2.Text);
            not.sinav3 = Convert.ToInt16(textBoxSinav3.Text);
            not.ortalama = not.OrtalamaHesapla();

            tbOrt.Text = not.ortalama.ToString();

            listBox1.Items.Add("** NOT BILGILERI **");
            listBox1.Items.Add($"1.Sinav ={not.sinav1} 2.Sinav ={not.sinav2} 3.Sinav ={not.sinav3} Ortalama ={not.ortalama} ");


        }

        private void gosterButon_Click(object sender, EventArgs e)
        {
            Ev ev_nesne = new Ev();
            ev_nesne.renk = "Pembe";
            ev_nesne.kat = "3";
            ev_nesne.fiyat = 50000;
            ev_nesne.yakit = 'D';

            label1.Text = ev_nesne.renk;
            label2.Text = ev_nesne.kat;
            label3.Text = ev_nesne.fiyat.ToString();
            label4.Text = ev_nesne.yakit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Papagan cicikus = new Papagan();
            cicikus.tur = textBoxTur.Text;
            cicikus.ayak = Convert.ToInt16(textBoxAyak.Text);
            textBoxSes.Text = cicikus.sesCikar();

            cicikus.renk = textBoxRenk.Text;
            cicikus.isim = textBoxIsim.Text;

            listBox2.Items.Clear();
            listBox2.Items.Add("** PAPAGAN **");
            listBox2.Items.Add($"Turu ={cicikus.tur} Ayak Sayýsý ={cicikus.ayak} Ses ={cicikus.sesCikar()} Renk ={cicikus.renk} Isim ={cicikus.isim} ");
        }
    }
}
