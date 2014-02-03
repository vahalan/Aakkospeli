using System;
using System.Windows.Forms;

namespace Aakkospeli
{
  public partial class Form1 : Form
  {
    String teksti = "The quick brown fox jumps over the lazy dog";

    int oikein = 0;
    int vaarin = 0;
    int kohta = 0;
    int aika = 0;
    const int AIKARAJA = 2000; // Suurin aika jonka kirjoittamiseen saa käyttää, 10ms kerrannaisina

    bool valmis = true;
    
    public Form1()
    {
      InitializeComponent();
      this.KeyPreview = true;
      this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);  // Käsitellään kaikki sovellukselle tulevat näppäinpainallukset
      
      tbOikein.Text = "0";
      tbVaarin.Text = "0";
     
      tbOikein.Enabled = false;
      tbVaarin.Enabled = false;
      tbAika.Enabled = false;
      
      tbText1.Enabled = false;
      tbText2.ReadOnly = true;
      tbText3.Enabled = false;
    }

    void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      char merkki = e.KeyChar;

      e.Handled = true;

      if (valmis == false)
      {
        if (merkki == teksti[kohta])
        {
          oikein++;
          tbOikein.Text = oikein.ToString();
          kohta++;

          if (kohta >= teksti.Length) // merkit loppu, viimeinen merkki on käsitelty
          {
            valmis = true;
            timer1.Enabled = false;  // pysäytä aika
            button1.Enabled = true;  // salli nappi

            System.Media.SystemSounds.Beep.Play();


            MessageBox.Show("Kaikki kirjoitettu, sait " + oikein.ToString() + 
              " oikein, väärin meni " + vaarin.ToString() + 
              ". Aikasi oli " + tbAika.Text+" sekuntia.", "Valmis!");

          }
          else
          {
            tbText1.Text = teksti.Substring(0, kohta);
            tbText2.Text = teksti.Substring(kohta, 1);
            tbText3.Text = teksti.Substring(kohta + 1);
          }
        }
        else
        {
          vaarin++;
          tbVaarin.Text = vaarin.ToString();
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      aika = 0;
      kohta = 0;
      valmis = false;

      tbText1.Text = "";
      tbText2.Text = teksti.Substring(0,1);
      tbText3.Text = teksti.Substring(1);
      
      timer1.Enabled = true;
      button1.Enabled = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      aika++;
      tbAika.Text = (aika / 100).ToString() + "," + (aika % 100).ToString("00");

      if (aika > AIKARAJA)
      {
        button1.Enabled = true;
        timer1.Enabled = false;
        kohta = 0;


        MessageBox.Show("Aikaa meni liian kauan, eli yli " + (AIKARAJA/100).ToString() + " sekuntia. Paras jatkaa harjoittelua!", "Etana!");

      }
    }
  }
}
