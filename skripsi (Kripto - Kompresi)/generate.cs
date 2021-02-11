using System;
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
    
namespace skripsi__Kripto___Kompresi_
{
    
    public partial class generate : Form
    {
        public Random rnd = new Random();
        public static BigInteger nilaie = 0;
        public static BigInteger nilain = 0;
        public static BigInteger nilaid = 0;
        public static BigInteger[] prima = new BigInteger[10];
        public generate()
        {
            InitializeComponent();
        }
        Form1 opener;
        public generate(Form1 parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            BigInteger jumlah = int.Parse(nop.Text);
            prima = new BigInteger[(int)jumlah];
            BigInteger n = 1;
            BigInteger ee = 0, d = 0;
            BigInteger totien = 1;
            string bilp = "";
           do
            { 
                for (int i = 0; i < jumlah; i++)
                {
                    int p = agrawalor(rnd.Next(1000,10000));
                    prima[i] = p;
                    /*
                    ini cara fermats
                    prima[i] = rnd.Next(2, 100);
                    while (count.prime(prima[i]) != 1)
                    {
                        prima[i] = rnd.Next(2, 1000);
                    }
                    */
                }
                for (int i = 0; i < jumlah; i++)
                {
                    n = BigInteger.Multiply(n, prima[i]);
                    bilp = bilp + "p[" + (i + 1) + "] = " + prima[i];
                    if (i != jumlah - 1)
                    {
                        bilp = bilp + " , ";
                    }
                }
                for (int i = 0; i < jumlah; i++)
                {

                    totien = BigInteger.Multiply(totien, (prima[i] - 1));
                }
                ed.Text = "65537";
                ee = BigInteger.Parse(ed.Text);
                //Console.WriteLine(count.GCD(90826161465831, 89995168972800));
            }
            while (count.GCD(ee, totien) != 1) ;
            d = count.diophantin(ee,totien);
            Console.WriteLine(d);      
            totient.Text = totien.ToString();
            prime.Text = bilp;
            en.Text = n.ToString(); 
            dd.Text = d.ToString();
        }
        public int modexp(int x, int y, int n)
        {
            int z = 1;
            for (int i= 0; i<y;i++)
            {
                z = (x * z) % n;
            }
            return z;
        }
        public int agrawalor(int n)
        {
            int z = 0;
            z = rnd.Next(3, n-2);
            if ((modexp(1 + z, n, n)) == (1 + (modexp(z, n, n)) % n) && (n % 2 != 0 && n % 5 != 0))   
                return n;
            else 
                return agrawalor(rnd.Next(10000, 100000));


        }
        public class count
        {
            public static String binner(int n)
            {
                int x = n, pemicu = 1;
                String hasil = "";
                while (x > 0)
                {
                    hasil = "" + x % 2 + "" + hasil;
                    x = x / 2;
                }
                return hasil;
            }
           
            public static BigInteger diophantin(BigInteger m, BigInteger n)
            {
                BigInteger x=0, y=1, d, k=0;
                BigInteger x2=1, y2=0, d2;
                BigInteger x3 = 0, y3 = 0, d3=0;
                if (m > n)
                {
                    d = m;
                    d2 = n;
                }
                else
                {
                    d = n;
                    d2 = m;
                }
                
                while (d3 != 1)
                {
                    k = d / d2;
                    x3 = x - (x2 * k);
                    y3 = y - (y2 * k);
                    d3 = d - (d2 * k);

                    x = x2;
                    y = y2;
                    d = d2;
                    x2 = x3;
                    y2 = y3;
                    d2 = d3;
                }
                if (x3 < 0)
                {
                    BigInteger hasil = (x3 * -1) % n;
                    x3 = n - hasil;
                    return x3;
                }
                else
                return (x3 % n);
            }
                 
            public static BigInteger invers(BigInteger b, BigInteger m)
            {
                //this is normal iterasi
                BigInteger hasil = 0;
                int var = 0;
                BigInteger d = 1;
                while (hasil != 1)
                {
                    hasil = (BigInteger.Multiply(d, b));
                    hasil = BigInteger.Remainder(hasil, m);
                    d++;
                }
                return d - 1;
            }
            public static BigInteger GCD(BigInteger x, BigInteger y)
            {
                
                BigInteger c = x % y;
                while (c != 0)
                {
                    x = y;
                    y = c;
                    c = x % y;
                   
                }
                return y;
            }
            
            public static BigInteger prime(BigInteger x) //fermats
            {
                BigInteger i = 2;
                BigInteger hasil = 0;
                while (i != x)
                {
                    hasil = (BigInteger.Pow(i, (int)x - 1)) % x;
                    if (hasil != 1)
                    {
                        return 0;
                        break;
                    }
                    i++;
                }
                return 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nilain = BigInteger.Parse(en.Text);
            nilaie = BigInteger.Parse(en.Text);
            nilaid = BigInteger.Parse(en.Text);
           
            this.Hide();

        }
    }
}
