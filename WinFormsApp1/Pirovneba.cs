using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Pirovneba
    {
        protected string saxeli, gvari;
        protected int asaki;
        public Pirovneba(string saxeli, string gvari, int asaki)
        {
            this.saxeli = saxeli;
            this.gvari = gvari;
            this.asaki = asaki;
        }
    }
    class Eqimi : Pirovneba
    {
        public string gankofileba, tanamdeboba, saavadmyofo, staji;
        
        public Eqimi(string gankofileba, string tanamdeboba, string saavadmyofo, string staji, string saxeli, string gvari, int asaki) : base(saxeli, gvari, asaki)
        {
            this.gankofileba = gankofileba;
            this.tanamdeboba = tanamdeboba;
            this.saavadmyofo = saavadmyofo;
            this.staji = staji;
        }
        public void Gamotana(Label label)
        {
            label.Text = $"სახელი: {saxeli} გვარი: {gvari} ასაკი: {asaki} განყოფილება: {gankofileba} თანამდებობა: {tanamdeboba} საავადმყოფო: {saavadmyofo} სტაჟი: {staji}";
        }
    }
}
