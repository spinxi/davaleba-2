namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gankofileba, tanamdeboba, saavadmyofo, staji, saxeli, gvari;
            int asaki = 15;

            gankofileba = textBox1.Text;
            tanamdeboba = textBox2.Text;
            saavadmyofo = textBox3.Text;
            staji = textBox4.Text;
            saxeli = textBox5.Text;
            gvari = textBox6.Text;
            asaki = int.Parse(textBox7.Text);



            Eqimi obj_eqimi = new Eqimi(gankofileba, tanamdeboba, saavadmyofo, staji, saxeli, gvari, asaki);
            obj_eqimi.Gamotana(label1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
