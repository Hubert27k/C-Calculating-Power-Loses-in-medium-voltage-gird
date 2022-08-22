using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int PFF25 = 70;
        int PCU25 = 900;

        int PFF40 = 82;
        int PCU40 = 1020;

        int PFF63 = 104;
        int PCU63 = 1269;

        int PFF100 = 145;
        int PCU100 = 1750;

        int PFF160 = 210;
        int PCU160 = 2350;

        double AFL16 = 1.8763;
        double AFL25 = 1.2010;
        double AFL35 = 0.8343;
        double AFL50 = 0.5939;
        double AFL70 = 0.4324;

    

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string transformator1 = comboBox1.SelectedItem.ToString();
            double mocGPZ = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text) * Math.Sqrt(3);
            textBox10.Text = mocGPZ.ToString();
            double moct1=0,moct2=0, moct3=0, moct4=0, moct5=0, moct6=0, moct7=0, moct8=0 ;
            int pcut1 = 0, pcut2 = 0, pcut3 = 0, pcut4 = 0, pcut5 = 0, pcut6 = 0, pcut7 = 0, pcut8 = 0 ;
            int pfet1 = 0, pfet2 = 0, pfet3 = 0, pfet4 = 0, pfet5 = 0, pfet6 = 0, pfet7 = 0, pfet8 = 0;
            switch (transformator1)
            {
                case "TR 25kVA":
                    moct1 = 25;
                    pcut1 = PCU25;
                    pfet1 = PFF25;
                    break;
                case "TR 40kVA":
                    moct1 = 40;
                    pcut1 = PCU40;
                    pfet1 = PFF40;
                    break;
                case "TR 63kVA":
                    moct1 = 63;
                    pcut1 = PCU63;
                    pfet1 = PFF63;
                    break;
                case "TR 100kVA":
                    moct1 = 100;
                    pcut1 = PCU100;
                    pfet1 = PFF100;
                    break;
                case "TR 160kVA":
                    moct1 = 160;
                    pcut1 = PCU160;
                    pfet1 = PFF160;
                    break;
                case "-":
                    moct1 = 0;
                    pfet1 = 0;
                    pcut1 = 0;
                    break;
            }

            string transformator2 = comboBox8.SelectedItem.ToString();
            switch (transformator2)
            {
                case "TR 25kVA":
                    moct2 = 25;
                    pcut2 = PCU25;
                    pfet2 = PFF25;
                    break;
                case "TR 40kVA":
                    moct2 = 40;
                    pcut2 = PCU40;
                    pfet2 = PFF40;
                    break;
                case "TR 63kVA":
                    moct2 = 63;
                    pcut2 = PCU63;
                    pfet2 = PFF63;
                    break;
                case "TR 100kVA":
                    moct2 = 100;
                    pcut2 = PCU100;
                    pfet2 = PFF100;
                    break;
                case "TR 160kVA":
                    moct2 = 160;
                    pcut2 = PCU160;
                    pfet2 = PFF160;
                    break;
                case "-":
                    moct2 = 0;
                    pcut2 = 0;
                    pfet2 = 0;
                    break;
            }

            string transformator3 = comboBox9.SelectedItem.ToString();
            switch (transformator3)
            {
                case "TR 25kVA":
                    moct3 = 25;
                    pcut3 = PCU25;
                    pfet3 = PFF25;
                    break;
                case "TR 40kVA":
                    moct3 = 40;
                    pcut3 = PCU40;
                    pfet3 = PFF40;
                    break;
                case "TR 63kVA":
                    moct3 = 63;
                    pcut3 = PCU63;
                    pfet3 = PFF63;
                    break;
                case "TR 100kVA":
                    moct3 = 100;
                    pcut3 = PCU100;
                    pfet3 = PFF100;
                    break;
                case "TR 160kVA":
                    moct3 = 160;
                    pcut3 = PCU160;
                    pfet3 = PFF160;
                    break;
                case "-":
                    moct3 = 0;
                    pcut3 = 0;
                    pfet3 = 0;
                    break;
            }

            string transformator4 = comboBox10.SelectedItem.ToString();
            switch (transformator4)
            {
                case "TR 25kVA":
                    moct4 = 25;
                    pcut4 = PCU25;
                    pfet4 = PFF25;
                    break;
                case "TR 40kVA":
                    moct4 = 40;
                    pcut4 = PCU40;
                    pfet4 = PFF40;
                    break;
                case "TR 63kVA":
                    moct4 = 63;
                    pcut4 = PCU63;
                    pfet4 = PFF63;
                    break;
                case "TR 100kVA":
                    moct4 = 100;
                    pcut4 = PCU100;
                    pfet4 = PFF100;
                    break;
                case "TR 160kVA":
                    moct4 = 160;
                    pcut4 = PCU160;
                    pfet4 = PFF160;
                    break;
                case "-":
                    moct4 = 0;
                    pcut4 = 0;
                    pfet4 = 0;
                    break;
            }

            string transformator5 = comboBox11.SelectedItem.ToString();
            switch (transformator5)
            {
                case "TR 25kVA":
                    moct5 = 25;
                    pcut5 = PCU25;
                    pfet5 = PFF25;
                    break;
                case "TR 40kVA":
                    moct5 = 40;
                    pcut5 = PCU40;
                    pfet5 = PFF40;
                    break;
                case "TR 63kVA":
                    moct5 = 63;
                    pcut5 = PCU63;
                    pfet5 = PFF63;
                    break;
                case "TR 100kVA":
                    moct5 = 100;
                    pcut5 = PCU100;
                    pfet5 = PFF100;
                    break;
                case "TR 160kVA":
                    moct5 = 160;
                    pcut5 = PCU160;
                    pfet5 = PFF160;
                    break;
                case "-":
                    moct5 = 0;
                    pcut5 = 0;
                    pfet5 = 0;
                    break;
            }

            string transformator6 = comboBox12.SelectedItem.ToString();
            switch (transformator6)
            {
                case "TR 25kVA":
                    moct6 = 25;
                    pcut6 = PCU25;
                    pfet6 = PFF25;
                    break;
                case "TR 40kVA":
                    moct6 = 40;
                    pcut6 = PCU40;
                    pfet6 = PFF40;
                    break;
                case "TR 63kVA":
                    moct6 = 63;
                    pcut6 = PCU63;
                    pfet6 = PFF63;
                    break;
                case "TR 100kVA":
                    moct6 = 100;
                    pcut6 = PCU100;
                    pfet6 = PFF100;
                    break;
                case "TR 160kVA":
                    moct6 = 160;
                    pcut6 = PCU160;
                    pfet6 = PFF160;
                    break;
                case "-":
                    moct6 = 0;
                    pcut6 = 0;
                    pfet6 = 0;
                    break;
            }

            string transformator7 = comboBox13.SelectedItem.ToString();
            switch (transformator7)
            {
                case "TR 25kVA":
                    moct7 = 25;
                    pcut7 = PCU25;
                    pfet7 = PFF25;
                    break;
                case "TR 40kVA":
                    moct7 = 40;
                    pcut7 = PCU40;
                    pfet7 = PFF40;
                    break;
                case "TR 63kVA":
                    moct7 = 63;
                    pcut7 = PCU63;
                    pfet7 = PFF63;
                    break;
                case "TR 100kVA":
                    moct7 = 100;
                    pcut7 = PCU100;
                    pfet7 = PFF100;
                    break;
                case "TR 160kVA":
                    moct7 = 160;
                    pcut7 = PCU160;
                    pfet7 = PFF160;
                    break;
                case "-":
                    moct7 = 0;
                    pcut7 = 0;
                    pfet7 = 0;
                    break;
            }

            string transformator8 = comboBox14.SelectedItem.ToString();
            switch (transformator8)
            {
                case "TR 25kVA":
                    moct8 = 25;
                    pcut8 = PCU25;
                    pfet8 = PFF25;
                    break;
                case "TR 40kVA":
                    moct8 = 40;
                    pcut8 = PCU40;
                    pfet8 = PFF40;
                    break;
                case "TR 63kVA":
                    moct8 = 63;
                    pcut8 = PCU63;
                    pfet8 = PFF63;
                    break;
                case "TR 100kVA":
                    moct8 = 100;
                    pcut8 = PCU100;
                    pfet8 = PFF100;
                    break;
                case "TR 160kVA":
                    moct8 = 160;
                    pcut8 = PCU160;
                    pfet8 = PFF160;
                    break;
                case "-":
                    moct8 = 0;
                    pcut8 = 0;
                    pfet8 = 0;
                    break;
            }
            double moct = moct1 + moct2 + moct3 + moct4 + moct5 + moct6 + moct7 + moct8 ;
            double wsput1 = moct1 / moct;
            double wsput2 = moct2 / moct;
            double wsput3 = moct3 / moct;
            double wsput4 = moct4 / moct;
            double wsput5 = moct5 / moct;
            double wsput6 = moct6 / moct;
            double wsput7 = moct7 / moct;
            double wsput8 = moct8 / moct;
            textBox11.Text = (wsput1 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox12.Text = (wsput2 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox13.Text = (wsput3 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox14.Text = (wsput4 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox15.Text = (wsput5 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox27.Text = (wsput6 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox29.Text = (wsput7 * Convert.ToDouble(textBox1.Text)).ToString();
            textBox30.Text = (wsput8 * Convert.ToDouble(textBox1.Text)).ToString();
            double stobtr = mocGPZ / moct;
            textBox16.Text = stobtr.ToString();
            textBox35.Text = textBox30.Text;
            textBox34.Text = (Convert.ToDouble(textBox29.Text) + Convert.ToDouble(textBox35.Text)).ToString();
            textBox33.Text = (Convert.ToDouble(textBox27.Text) + Convert.ToDouble(textBox34.Text)).ToString();
            textBox36.Text = (Convert.ToDouble(textBox33.Text) + Convert.ToDouble(textBox15.Text)).ToString();
            textBox17.Text = (Convert.ToDouble(textBox14.Text) + Convert.ToDouble(textBox36.Text)).ToString();
            textBox18.Text = (Convert.ToDouble(textBox13.Text) + Convert.ToDouble(textBox17.Text)).ToString();
            textBox20.Text = textBox12.Text;
            textBox19.Text = (Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox20.Text)).ToString();
            textBox21.Text = (Convert.ToDouble(textBox18.Text) + Convert.ToDouble(textBox19.Text)).ToString();

            double linia1 = 0, linia2 = 0, linia3 = 0, linia4 = 0, linia5 = 0, linia6 = 0, linia7 = 0, linia8 = 0, linia9 = 0;
            string rodzajlini1 = comboBox2.SelectedItem.ToString();
            switch (rodzajlini1)
            {
                case "AFL-6/16mm":
                    linia1 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia1 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia1 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia1 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia1 = AFL70;
                    break;
            }

            string rodzajlini2 = comboBox6.SelectedItem.ToString();
            switch (rodzajlini2)
            {
                case "AFL-6/16mm":
                    linia2 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia2 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia2 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia2 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia2 = AFL70;
                    break;
            }

            string rodzajlini3 = comboBox4.SelectedItem.ToString();
            switch (rodzajlini3)
            {
                case "AFL-6/16mm":
                    linia3 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia3 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia3 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia3 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia3 = AFL70;
                    break;
            }

            string rodzajlini4 = comboBox3.SelectedItem.ToString();
            switch (rodzajlini4)
            {
                case "AFL-6/16mm":
                    linia4 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia4 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia4 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia4 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia4 = AFL70;
                    break;
            }

            string rodzajlini5 = comboBox5.SelectedItem.ToString();
            switch (rodzajlini5)
            {
                case "AFL-6/16mm":
                    linia5 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia5 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia5 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia5 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia5 = AFL70;
                    break;
            }

            string rodzajlini6 = comboBox7.SelectedItem.ToString();
            switch (rodzajlini6)
            {
                case "AFL-6/16mm":
                    linia6 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia6 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia6 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia6 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia6 = AFL70;
                    break;
            }

            string rodzajlini7 = comboBox15.SelectedItem.ToString();
            switch (rodzajlini7)
            {
                case "AFL-6/16mm":
                    linia7 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia7 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia7 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia7 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia7 = AFL70;
                    break;
            }

            string rodzajlini8 = comboBox16.SelectedItem.ToString();
            switch (rodzajlini8)
            {
                case "AFL-6/16mm":
                    linia8 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia8 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia8 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia8 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia8 = AFL70;
                    break;
            }

            string rodzajlini9 = comboBox17.SelectedItem.ToString();
            switch (rodzajlini9)
            {
                case "AFL-6/16mm":
                    linia9 = AFL16;
                    break;
                case "AFL-6/25mm":
                    linia9 = AFL25;
                    break;
                case "AFL-6/35mm":
                    linia9 = AFL35;
                    break;
                case "AFL-6/50mm":
                    linia9 = AFL50;
                    break;
                case "AFL-6/70mm":
                    linia9 = AFL70;
                    break;
            }

            double stratamocylinie1 = 3 * Convert.ToDouble(textBox21.Text) * Convert.ToDouble(textBox21.Text) * linia1 * Convert.ToDouble(textBox5.Text);
            double stratamocylinie2 = 3 * Convert.ToDouble(textBox19.Text) * Convert.ToDouble(textBox19.Text) * linia2 * Convert.ToDouble(textBox4.Text);
            double stratamocylinie3 = 3 * Convert.ToDouble(textBox20.Text) * Convert.ToDouble(textBox20.Text) * linia3 * Convert.ToDouble(textBox6.Text);
            double stratamocylinie4 = 3 * Convert.ToDouble(textBox18.Text) * Convert.ToDouble(textBox18.Text) * linia4 * Convert.ToDouble(textBox7.Text);
            double stratamocylinie5 = 3 * Convert.ToDouble(textBox17.Text) * Convert.ToDouble(textBox17.Text) * linia5 * Convert.ToDouble(textBox8.Text);
            double stratamocylinie6 = 3 * Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox36.Text) * linia6 * Convert.ToDouble(textBox9.Text);
            double stratamocylinie7 = 3 * Convert.ToDouble(textBox33.Text) * Convert.ToDouble(textBox33.Text) * linia7 * Convert.ToDouble(textBox37.Text);
            double stratamocylinie8 = 3 * Convert.ToDouble(textBox34.Text) * Convert.ToDouble(textBox34.Text) * linia8 * Convert.ToDouble(textBox38.Text);
            double stratamocylinie9 = 3 * Convert.ToDouble(textBox35.Text) * Convert.ToDouble(textBox35.Text) * linia9 * Convert.ToDouble(textBox39.Text);
            double sumastratmocylinie = stratamocylinie1 + stratamocylinie2 + stratamocylinie3 + stratamocylinie4 + stratamocylinie5 + stratamocylinie6 + stratamocylinie7 +stratamocylinie8 +stratamocylinie9;
            textBox23.Text = sumastratmocylinie.ToString();

            double stratyobctr1 = stobtr * stobtr * pcut1;
            double stratyobctr2 = stobtr * stobtr * pcut2;
            double stratyobctr3 = stobtr * stobtr * pcut3;
            double stratyobctr4 = stobtr * stobtr * pcut4;
            double stratyobctr5 = stobtr * stobtr * pcut5;
            double stratyobctr6 = stobtr * stobtr * pcut6;
            double stratyobctr7 = stobtr * stobtr * pcut7;
            double stratyobctr8 = stobtr * stobtr * pcut8;

            double sumastratobctr = stratyobctr1 + stratyobctr2 + stratyobctr3 + stratyobctr4 + stratyobctr5 + stratyobctr6 + stratyobctr7 + stratyobctr8;

            textBox22.Text = sumastratobctr.ToString();

            double przeliczcos = 1 -  Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox40.Text);
            double sinusfi = Math.Sqrt(przeliczcos);
            

            double sincos01 = Convert.ToDouble(textBox40.Text) * linia1 * Convert.ToDouble(textBox5.Text) + 0.4 * Convert.ToDouble(textBox5.Text) * sinusfi;
            double stratynap01 = Math.Sqrt(3) * Convert.ToDouble(textBox21.Text) * sincos01 * 0.001;
            double sincos12 = Convert.ToDouble(textBox40.Text) * linia2 * Convert.ToDouble(textBox4.Text) + 0.4 * Convert.ToDouble(textBox4.Text) * sinusfi;
            double stratynap12 = Math.Sqrt(3) * Convert.ToDouble(textBox19.Text) * sincos12 * 0.001;
            double sincos23 = Convert.ToDouble(textBox40.Text) * linia3 * Convert.ToDouble(textBox6.Text) + 0.4 * Convert.ToDouble(textBox6.Text) * sinusfi;
            double stratynap23 = Math.Sqrt(3) * Convert.ToDouble(textBox20.Text) * sincos23 * 0.001;
            double sincos14 = Convert.ToDouble(textBox40.Text) * linia4 * Convert.ToDouble(textBox7.Text) + 0.4 * Convert.ToDouble(textBox7.Text) * sinusfi;
            double stratynap14 = Math.Sqrt(3) * Convert.ToDouble(textBox18.Text) * sincos14 * 0.001;
            double sincos45 = Convert.ToDouble(textBox40.Text) * linia5 * Convert.ToDouble(textBox8.Text) + 0.4 * Convert.ToDouble(textBox8.Text) * sinusfi;
            double stratynap45 = Math.Sqrt(3) * Convert.ToDouble(textBox17.Text) * sincos45 * 0.001;
            double sincos56 = Convert.ToDouble(textBox40.Text) * linia6 * Convert.ToDouble(textBox9.Text) + 0.4 * Convert.ToDouble(textBox9.Text) * sinusfi;
            double stratynap56 = Math.Sqrt(3) * Convert.ToDouble(textBox36.Text) * sincos56 * 0.001;
            double sincos67 = Convert.ToDouble(textBox40.Text) * linia7 * Convert.ToDouble(textBox37.Text) + 0.4 * Convert.ToDouble(textBox37.Text) * sinusfi;
            double stratynap67 = Math.Sqrt(3) * Convert.ToDouble(textBox33.Text) * sincos67 * 0.001;
            double sincos78 = Convert.ToDouble(textBox40.Text) * linia8 * Convert.ToDouble(textBox38.Text) + 0.4 * Convert.ToDouble(textBox38.Text) * sinusfi;
            double stratynap78 = Math.Sqrt(3) * Convert.ToDouble(textBox34.Text) * sincos78 * 0.001;
            double sincos89 = Convert.ToDouble(textBox40.Text) * linia9 * Convert.ToDouble(textBox39.Text) + 0.4 * Convert.ToDouble(textBox39.Text) * sinusfi;
            double stratynap89 = Math.Sqrt(3) * Convert.ToDouble(textBox35.Text) * sincos89 * 0.001;

            double napiecieodb1 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap12;
            double napiecieodb2 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap12 - stratynap23;
            double napiecieodb3 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14;
            double napiecieodb4 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14 - stratynap45;
            double napiecieodb5 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14 - stratynap45 - stratynap56;
            double napiecieodb6 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14 - stratynap45 - stratynap56 - stratynap67;
            double napiecieodb7 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14 - stratynap45 - stratynap56 - stratynap67 - stratynap78;
            double napiecieodb8 = Convert.ToDouble(textBox2.Text) - stratynap01 - stratynap14 - stratynap45 - stratynap56 - stratynap67 - stratynap78 -stratynap89;

            textBox41.Text = napiecieodb1.ToString();
            textBox42.Text = napiecieodb2.ToString();
            textBox24.Text = napiecieodb3.ToString();
            textBox25.Text = napiecieodb4.ToString();
            textBox26.Text = napiecieodb5.ToString();
            textBox28.Text = napiecieodb6.ToString();
            textBox32.Text = napiecieodb7.ToString();
            textBox31.Text = napiecieodb8.ToString();

            double UNt = 15.75 * 15.75;
            double Uzt1 = Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox41.Text);
            double Uzt2 = Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox42.Text);
            double Uzt3 = Convert.ToDouble(textBox24.Text) * Convert.ToDouble(textBox24.Text);
            double Uzt4 = Convert.ToDouble(textBox25.Text) * Convert.ToDouble(textBox25.Text);
            double Uzt5 = Convert.ToDouble(textBox26.Text) * Convert.ToDouble(textBox26.Text);
            double Uzt6 = Convert.ToDouble(textBox28.Text) * Convert.ToDouble(textBox28.Text);
            double Uzt7 = Convert.ToDouble(textBox32.Text) * Convert.ToDouble(textBox32.Text);
            double Uzt8 = Convert.ToDouble(textBox31.Text) * Convert.ToDouble(textBox31.Text);

            double wpsPj1 = Uzt1 / UNt;
            double wpsPj2 = Uzt2 / UNt;
            double wpsPj3 = Uzt3 / UNt;
            double wpsPj4 = Uzt4 / UNt;
            double wpsPj5 = Uzt5 / UNt;
            double wpsPj6 = Uzt6 / UNt;
            double wpsPj7 = Uzt7 / UNt;
            double wpsPj8 = Uzt8 / UNt;

            double stratyjalowetr1 = wpsPj1 * pfet1;
            double stratyjalowetr2 = wpsPj2 * pfet2;
            double stratyjalowetr3 = wpsPj3 * pfet3;
            double stratyjalowetr4 = wpsPj4 * pfet4;
            double stratyjalowetr5 = wpsPj5 * pfet5;
            double stratyjalowetr6 = wpsPj6 * pfet6;
            double stratyjalowetr7 = wpsPj7 * pfet7;
            double stratyjalowetr8 = wpsPj8 * pfet8;

            double sumastratjalowych = stratyjalowetr1 + stratyjalowetr2 + stratyjalowetr3 + stratyjalowetr4 + stratyjalowetr5 + stratyjalowetr6 + stratyjalowetr7 + stratyjalowetr8;
            textBox43.Text = sumastratjalowych.ToString();

            double calkowitasumastrat = sumastratjalowych + sumastratmocylinie + sumastratobctr;
            double calkowitasumastratkW = calkowitasumastrat * 0.001;
            double mocczynnaGPZ = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox40.Text);
            double procentowestratymocy = calkowitasumastratkW / mocczynnaGPZ * 100;

            textBox44.Text = calkowitasumastratkW.ToString();
            textBox45.Text = mocczynnaGPZ.ToString();
            textBox46.Text = procentowestratymocy.ToString();


            double podkreskadlam = 8760 * mocczynnaGPZ * 1000;
            double m = Convert.ToDouble(textBox3.Text) * 1000000 / podkreskadlam;
            textBox47.Text = m.ToString();

            double modelm3 = 2 / 3 * m;
            double nawias1m4 = m * m * 2;
            double calynawiasm4 = m + nawias1m4;
            double modelm4 =   calynawiasm4 / 3;
            double cz2model5 = m * m * 0.7;
            double cz1model5 = 0.3 * m;
            double modelm5 = cz1model5 + cz2model5;
            double cz2model6 = m * m * 0.5;
            double cz1model6 = 0.5 * m;
            double modelm6 = cz1model6 + cz2model6;

            

            double model = 0;
            string wybormodelu = comboBox11.SelectedItem.ToString();
            switch (wybormodelu)
            {
                case "Model M 3":
                    model = modelm3;
                    break;
                case "Model M 4":
                    model = modelm4;
                    break;
                case "Model M 5":
                    model = modelm5;
                    break;
                case "Model M 6":
                    model = modelm6;
                    break;
                default:
                    model = -1;

            }

            double stratylinitransfobc = sumastratmocylinie + sumastratobctr;
            double pomnozonelinieitr = stratylinitransfobc * model * 8760;
            double stratyjalowepomnozone = sumastratjalowych * 8760;
            double stratyenergii = pomnozonelinieitr + stratyjalowepomnozone;
            double stratyenergiikwh = stratyenergii * 0.001;
            double rocznypoborenergiwW = Convert.ToDouble(textBox3.Text) * 1000000;
            double procentowestratyenergi = stratyenergii / rocznypoborenergiwW * 100;
            textBox48.Text = stratyenergiikwh.ToString();
            textBox49.Text = procentowestratyenergi.ToString();


            }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }
    }
}
