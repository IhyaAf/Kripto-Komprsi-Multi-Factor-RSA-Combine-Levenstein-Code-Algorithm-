using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Security.Cryptography;
using MetroFramework.Forms;

namespace skripsi__Kripto___Kompresi_
{
    public partial class Form1 : MetroForm
    {
        char[] asciinum = { '←','↑','→','↓','↔','↵','⇐','⇑','⇒','⇓','\n','\t','∂','∃','∅','∇',
            '∈','∉','∋','∏','∑','√','∝','∞','∠','∧','∨','∩','∪','∫','∴','∼',
            ' ','!','\"','#','$','%','&','\'','(',')','*','+',',','-','.','/',
            '0','1','2','3','4','5','6','7','8','9',':',';','<','=','>','?',
            '@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
            'P','Q','R','S','T','U','V','W','X','Y','Z','[','\\',']','^','_',
            '`','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
            'p','q','r','s','t','u','v','w','x','y','z','{','|','}','~','≈',
            '≠','≡','≤','≥','⊂','⊃','⊄','⊆','⊇','⊕','⊗','α','β','γ','δ','ε',
            'ζ','η','θ','ι','κ','λ','μ','ν','ξ','ο','π','ρ','σ','ς','τ','υ',
            '¶','¡','¢','£','¤','¥','¦','§','¨','©','ª','«','¬','Ⅲ','®','¯',
            '°','±','²','³','´','µ','Ⅱ','•','¸','¹','º','»','¼','½','¾','¿',
            'À','Á','Â','Ã','Ä','Å','Æ','Ç','È','É','Ê','Ë','Ì','Í','Î','Ï',
            'Ð','Ñ','Ò','Ó','Ô','Õ','Ö','×','Ø','Ù','Ú','Û','Ü','Ý','Þ','ß',
            'à','á','â','ã','ä','å','æ','ç','è','é','ê','ë','ì','í','î','ï',
            'ð','ñ','ò','ó','ô','õ','ö','÷','ø','ù','ú','û','ü','ý','þ','ÿ'
         };
        public StringBuilder say = new StringBuilder();
        public StringBuilder tes = new StringBuilder();
        public StringBuilder str = new StringBuilder();
        public StringBuilder resbin = new StringBuilder();
        public StringBuilder biners = new StringBuilder();
        public int deretekor = 0;
        public int[,] asciihitung = new int[256,256];
        public StringBuilder save = new StringBuilder();
        public StringBuilder txt = new StringBuilder();
        public StringBuilder outs = new StringBuilder();
        public int[] asciiindex = new int[256];
        public Random rnd = new Random();
        public BigInteger n = 1;
        public BigInteger ee = 0, d = 0;
        public BigInteger totien = 1;
        public BigInteger de = 0;
        public BigInteger[] prima = new BigInteger[1];
        public BigInteger c = 0;
        public String[] fileenk = new String[1];
        public String[] levenstein = new string[256];
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
        public string lev(int bil)
        {
            string bin = "";
            if (bil != 0)
            {
                bin = count.binner(bil);
                string results = "";
                int valc = 1, m = 9;
                string temp1 = bin, temp2 = "";
                while (m != 0)
                {

                    if (temp1[0].Equals('1') == true)
                    {
                        temp2 = "";
                        for (int i = 1; i < temp1.Length; i++)
                        {
                            temp2 = temp2 + temp1[i];
                        }
                    }
                    results = temp2 + results;

                    m = temp2.Length;
                    valc = valc + 1;
                    n = m;
                    temp1 = count.binner(n);

                }
                temp2 = "";
                for (int i = 0; i < valc - 1; i++)
                {
                    temp2 = temp2 + "1";
                }

                results = temp2 + "0" + results;
                return results;
            }
            else
                return "0";

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string enkrip = @"c:\temp\haiyya.txt";
            if (File.Exists(enkrip))
            {   
                File.Delete(enkrip);
            }
            using (StreamWriter sh = new StreamWriter(enkrip))
            {
                    sh.Write(asciinum[64].ToString());
                   
            }
            using (StreamReader sh = new StreamReader(enkrip))
            {
                naskah.Text = sh.ReadToEnd();
            }
                for (int i = 0; i < asciinum.Length; i++)
            {
                asciihitung[i,0] = 0;
                asciihitung[i, 1] = i;
            }
            for (int i=0;i< asciinum.Length; i++)
            {
                string temp = lev(i);
                levenstein[i] = temp;
                //Console.WriteLine(levenstein[i]);
            }
            nop.Text= Convert.ToString(rnd.Next(3, 6));
            BigInteger jumlah = int.Parse(nop.Text);
            prima = new BigInteger[(int)jumlah];
            n = 1;
            ee = 0; 
            totien = 1;
            BigInteger d = 0;
            string bilp = "";
            do
            {
                bilp = "";
                n = 1;
                ee = 0;
                totien = 1;
                d = 0;
                for (int i = 0; i < jumlah; i++)
                {
                    /*
                    var rng = new RNGCryptoServiceProvider();
                    byte[] bytes = new byte[512 / 8];
                    rng.GetBytes(bytes);
                    BigInteger pew = new BigInteger(bytes);
                    BigInteger p = agrawalor(pew);
                    */
                    BigInteger p = agrawalor(rnd.Next(100, 10000));
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
                    bilp = bilp + "p" + (i + 1) + " = " + prima[i];
                    if (i != jumlah - 1)
                    {
                        bilp = bilp + " ; ";
                    }
                }
                for (int i = 0; i < jumlah; i++)
                {

                    totien = BigInteger.Multiply(totien, (prima[i] - 1));
                }
                ed.Text = Convert.ToString(rnd.Next(1, 99999)) ;
                ee = BigInteger.Parse(ed.Text);
                
                //Console.WriteLine(count.GCD(90826161465831, 89995168972800));
            }
            while (count.GCD(ee, totien) != 1);
            d = count.diophantin(ee, totien);
            count.diophantin(2366496, 65537);
            de = d;
            //Console.WriteLine(d);
            totient.Text = totien.ToString();
            prime.Text = bilp;
            en.Text = n.ToString();
            dd.Text = d.ToString();
            privatd.Text = d.ToString();
            privatp.Text = bilp;
            publice.Text = ee.ToString();
            publicn.Text = en.Text;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "";
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    long size = 1;
                    string text = File.ReadAllText(file);
                    size = new FileInfo(openFileDialog1.FileName).Length;
                    filename.Text = file;
                    naskah.Text = text;

                }
                catch (IOException)
                {
                }
                Console.WriteLine("upload file berhasil");
            }
            else
                Console.WriteLine("upload file gagal");
            long filesizer = new System.IO.FileInfo(filename.Text).Length;
            filesize.Text = filesizer + " bytes";

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            string enkrip = @"c:\temp\enkrip.temp";
            string asciekor = @"c:\temp\ascii.temp";
            if (File.Exists(enkrip))
            {
                File.Delete(enkrip);
            }
            for (int i = 0; i < asciinum.Length; i++)
            {
                asciihitung[i, 0] = 0;
                asciihitung[i, 1] = i;
            }
            string kompres = @"c:\temp\kompresi.temp";
            if (File.Exists(kompres))
            {
                File.Delete(kompres);
            }

            save.Clear();
          
            outs.Clear();
            watch.Start();
            
            
            ascii.Text = "";
            int x = 0;
            string teks = naskah.Text;
            int[] bytes = new int[teks.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                int indexasccii = 0;
                for (int j = 0; j < 256; j++)
                {
                    if (asciinum[j].Equals(teks[i]) == true)
                    {
                        indexasccii = j;
                        break;
                    }
                }
                bytes[i] = indexasccii;
            }
            enk.Text = "";
            string binner = "";
            fileenk = new String [teks.Length];
            string ew = count.binner(ee);
            string komp = "";
            using (StreamWriter sh = new StreamWriter(enkrip))
            {
                foreach (byte b in bytes)
                {
                    sh.Write(count.sam(b, ew, n) + " ");
                    
                }
            }
            StreamReader temps = new StreamReader(enkrip);
            using (StreamWriter sh = new StreamWriter(asciekor))
            {
                sh.Write(ko(temps.ReadToEnd()));
            }
            temps.Close();
            watch.Stop();
            run.Text = Math.Round(Convert.ToDecimal(watch.ElapsedMilliseconds) / 1000, 4).ToString() + " ms";
            using (StreamReader sr = new StreamReader(enkrip))
            {
                enk.Text = sr.ReadToEnd();
            }

            using (StreamReader sr = new StreamReader(enkrip))
            {
                enk.Text = sr.ReadToEnd();
            }
            
            ascii.Text = outs.ToString();
            message.Text = ascii.Text;
            long length = new System.IO.FileInfo(asciekor).Length;
            resiz.Text = Convert.ToString(length) + " Bytes";

            double comprat = (double)((ascii.Text).Length * 8) / ((enk.Text).Length * 8);
            comprat = Convert.ToDouble(String.Format("{0:0.00}", comprat)) * 100;

            Console.Write("setelah = "+ (ascii.Text).Length * 8+" sebelum = "+ (enk.Text).Length * 8 );

            double spacesavings = (double) ((ascii.Text).Length * 8) / ((enk.Text).Length * 8) ;
            spacesavings = Convert.ToDouble(String.Format("{0:0.00}", spacesavings));
            using (StreamWriter sr = new StreamWriter(kompres))
            {
                sr.Write(save.ToString());
            }
            cr.Text = "Compression Ratio:" + comprat + "%";
            ss.Text = "Space Savings : " + (100 - (spacesavings * 100)) + "%";
        }
        public string ko(string komp)
        {
            
            for (int i=0;i<komp.Length;i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if(komp[i].Equals(asciinum[j]) == true)
                    {
                        asciihitung[j,0] = asciihitung[j,0] + 1;
                        break;
                    }
                }
            }
            int temp = 0,k=0;
            for (int j = 0; j <= 256 - 2; j++)
            {
                if (asciihitung[j, 0] > 0)
                    k++;
            }
                temp = 0;
            for (int j = 0; j <= 256 - 2; j++)
            {
                for (int i = 0; i <= 256 - 2; i++)
                {
                    if (asciihitung[i, 0] < asciihitung[i + 1, 0])
                    {
                        temp = asciihitung[i + 1, 0];
                        asciihitung[i + 1, 0] = asciihitung[i, 0];
                        asciihitung[i, 0] = temp;
                        temp = asciihitung[i + 1, 1];
                        asciihitung[i + 1, 1] = asciihitung[i, 1];
                        asciihitung[i, 1] = temp;
                    }
                }
            }
            
                for (int i = 0; i < komp.Length; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        save.Append((komp[i].Equals(asciinum[asciihitung[j, 1]])) ? levenstein[j] : "");
                        
                    }
                }
                int pading = (8 - (save.Length % 8));
                if (pading < 8)
                {
                    for (int i = 0; i < pading; i++)
                    {
                    save.Append("0");
                    }
                    if (count.binner(pading).Length % 8 != 0)
                    {
                        for (int i = 0; i < 8- count.binner(pading).Length;i++)
                        {
                        save.Append("0");
                        }
                        save.Append(count.binner(pading));
                    }
                }
            string txte = save.ToString();
            string temps ="";
            //Console.WriteLine(txte);
            
                for (int i = 0; i < save.Length; i++)
                {
                    temps += txte[i];
                    if ((i + 1) % 8 == 0)
                    {
                        //sr.Write(temps + " ");
                        outs.Append(asciinum[Convert.ToInt32(temps, 2)]);
                        temps = "";
                    }
                }
           
                   
                for (int j = 0; j < k; j++)
                {
                    outs.Append(asciinum[asciihitung[j, 1]]);
                }
                
            outs.Append(" "+k);
            return outs.ToString();
            
        }

        private string s(int v)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dd_TextChanged(object sender, EventArgs e)
        {

        }

        private void totient_TextChanged(object sender, EventArgs e)
        {

        }

        private void en_TextChanged(object sender, EventArgs e)
        {

        }

        private void prime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nop_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "ciphertext.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.Write(ascii.Text);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void publicn_TextChanged(object sender, EventArgs e)
        {

        }

        private void enk_TextChanged(object sender, EventArgs e)
        {

        }

        private void filesize_Click(object sender, EventArgs e)
        {

        }

        private void naskah_TextChanged(object sender, EventArgs e)
        {

        }

        private void hai_Click(object sender, EventArgs e)
        {

        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        void dekompresi (string c)
        {
            string dekompresihasil = @"c:\temp\dekompresihasil.temp";
            if (File.Exists(dekompresihasil))
            {
                File.Delete(dekompresihasil);
            }
            string binn = @"c:\temp\binn.temp";
            if (File.Exists(binn))
            {
                File.Delete(binn);
            }
            str.Clear();
            resbin.Clear();
            say.Clear();
            tes.Clear();
            biners.Clear();
            int says = 0;
            int idx = 0;
            say.Append(c);
            //Console.Write(c + "\n");
            try
            {
                for (int i = say.Length - 1; i >= 0; i--)
                {
                if (say[i].Equals(' ') == true)
                {
                    break;
                }
                else
                {
                    //Console.Write(say[i]+"\n");
                    tes.Insert(0, say[i]);
                }
                    
            }
            
            int ekor = 0;
            
                ekor = int.Parse(tes.ToString());
            
            char[] deret = new char[ekor];
            for (int i = 0; i < say.Length - (ekor + 1) - tes.Length; i++)
            {
                idx = 0;
                for (int j = 0; j < 256; j++)
                {
                    if (asciinum[j].Equals(say[i]) == true)
                    {
                        idx = j;
                        break;
                    }
                }
                biners.Append(Convert.ToString(idx, 2).PadLeft(8, '0'));
            }
            idx = 0;
            for (int i = say.Length - (ekor + 1) - tes.Length; i < say.Length - (tes.Length + 1); i++)
            {
                //try {
                deret[idx] = say[i];
                idx++; //Console.Write("panjang hanya " + deret.Length + " sementara idx = " + idx); }

            }
            idx = 0;
            string res = "";
            try
            {
                for (int i = biners.Length - 8; i < biners.Length; i++)
                {
                    str.Append(biners[i]);
                }
            }
            catch
            {
                Console.Write(biners.Length - 8);
            }
            int dec = count.todesimal(str.ToString());
           
                if ((((biners.Length) - (dec + 8)) % 8 != 0) && (dec < 9))
                {
                    for (int i = 0; i < biners.Length - (dec + 8); i++)
                    {
                            try
                            {
                                resbin.Append(biners[i]);
                            }
                                catch (System.OutOfMemoryException ez)
                                {
                                    break;
                                   MessageBox.Show("error " + ez);
                                }

                }
                }
                else
                    resbin = biners;
            
            str.Clear(); res = "";
            using (StreamWriter wr = new StreamWriter(dekompresihasil))
            {
                for (int i = 0; i < resbin.Length; i++)
                {
                    str.Append( resbin[i].ToString());
                    for (int j = 0; j < ekor; j++)
                    {
                        try {
                            if (str.ToString().Equals(levenstein[j]) == true)
                            {
                                try
                                {
                                    wr.Write(deret[j]);
                                }
                                catch
                                {
                                    Console.WriteLine("error " + j + " != " + (deret.Length - 1));
                                }
                                str.Clear();
                                break;
                            }
                        }
                        catch (OutOfMemoryException e)
                        {
                            Console.WriteLine("Out of Memory: {0}", e.Message);
                        }
                    }
                }
            }
            }
            catch
            {
                resbin.Clear();
                using (StreamWriter wr = new StreamWriter(dekompresihasil))
                {
                    wr.Write("error");
                }
                    MessageBox.Show("Please check your scheme");
            }
            /*
             
            */

        }
        string enkripsi (string c, BigInteger pd, BigInteger word)
        {
            string enkrip = @"c:\temp\enkriphasil.temp";
            if (File.Exists(enkrip))
            {
                File.Delete(enkrip);
            }
            string tekst = c;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (i != tekst.Length - 1)
                {
                    if ((tekst[i].Equals(' ') == true) && (tekst[i + 1].Equals(' ') == false))
                    {
                        word++;
                    }
                }
            }
             
            BigInteger[] teken = new BigInteger[(int)word + 1];
            int temp = 0;
            string texttemp = "";
            
                for (int i = 0; i < tekst.Length; i++)
                {

                    if ((tekst[i].Equals(' ') == true) || (i == tekst.Length - 1))
                    {
                        if (texttemp != " " || texttemp != "")
                        {
                            try
                            {
                            teken[temp] = BigInteger.Parse(texttemp + tekst[i]);
                            //Console.WriteLine(teken[temp]);
                            //Console.WriteLine("teken["+temp+"]" + teken[temp] + " ");
                            texttemp = "";
                            temp++;
                            }
                            catch
                            {
                            texttemp = "";
                            Console.WriteLine("gabisa = "+ texttemp + tekst[i]);
                            }
                    }
                    }
                    else
                        texttemp = texttemp + tekst[i];

                }
           
            string teks = "";
            string resu = "";
            string ch = "";
            try
            {

                using (StreamWriter wr = new StreamWriter(enkrip))
                {
                    for (BigInteger wew = 0; wew < teken.Length - 1; wew++)
                    {
                        BigInteger cip = teken[(int)wew];
                        string bin = count.binner(1);
                        int jumlah = int.Parse(nop.Text);
                        BigInteger be = 1;
                        BigInteger[] d = new BigInteger[jumlah];
                        BigInteger[] m = new BigInteger[jumlah];
                        BigInteger[] b = new BigInteger[jumlah];
                        BigInteger[] s = new BigInteger[jumlah];
                        for (int i = 0; i < jumlah; i++)
                        {
                            d[i] = count.sam(pd, bin, prima[i] - 1);
                       
                        }
                    
                    for (int i = 0; i < jumlah; i++)
                        {
                            bin = count.binner(d[i]);
                            m[i] = count.sam(cip, bin, prima[i]);
                        }
                        for (int i = 0; i < jumlah; i++)
                        {
                            be = be * prima[i];
                        }
                        for (int i = 0; i < jumlah; i++)
                        {
                            b[i] = be / prima[i];
                        }
                        for (int i = 0; i < jumlah; i++)
                        {

                            s[i] = count.diophantiny(prima[i], b[i]);

                        }
                        BigInteger plainteks = 0;
                        for (int i = 0; i < jumlah; i++)
                        {

                            plainteks = plainteks + (m[i] * b[i] * s[i]);
                        }
                        plainteks = BigInteger.Remainder(plainteks, be);
                        wr.Write(asciinum[(int)plainteks]);
                    
                        //Console.WriteLine(count.diophantin(ee, totien));
                    }
                }
            }
            catch
            {
                MessageBox.Show("please fix your private key");
            }
            using (StreamReader r = new StreamReader(enkrip))
                {
                    return r.ReadToEnd();
                }
            
            
            return "0";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            BigInteger pd = BigInteger.Parse(privatd.Text);
            BigInteger word = 1;

            string dekrip = @"c:\temp\enkriphasil.temp";
            string dekomp = @"c:\temp\dekompresihasil.temp";
            if (File.Exists(dekrip))
            {
                File.Delete(dekrip);
            }
            if (File.Exists(dekomp))
            {
                File.Delete(dekomp);
            }

           
                dekompresi(enkripsi(message.Text, pd, word));
            
            using (StreamReader r = new StreamReader(dekrip))
            {
                ciphertext.Text = r.ReadToEnd();
            }
            using (StreamReader r = new StreamReader(dekomp))
            {
                dekripsi.Text = r.ReadToEnd();
            }
            watch.Stop();


            runtime2.Text = Math.Round(Convert.ToDecimal(watch.ElapsedMilliseconds) / 1000, 4).ToString() + " ms";
            if ((dekripsi.Text).Equals("error") == true)
            {
                ciphertext.Text = "error";
            }
            //ciphertext.Text = dekompresi(message.Text);
            //dekripsi.Text = enkripsi(ciphertext.Text,pd,word);
        }
        public int modexp(int x, int y, int n)
        {
            int z = 1;
            for (int i = 0; i < y; i++)
            {
                z = (x * z) % n;
            }
            return z;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            string enkrip = @"c:\temp\enkrip.temp";
            string asciekor = @"c:\temp\ascii.temp";
            if (File.Exists(enkrip))
            {
                File.Delete(enkrip);
            }
            for (int i = 0; i < asciinum.Length; i++)
            {
                asciihitung[i, 0] = 0;
                asciihitung[i, 1] = i;
            }
            save.Clear();
            outs.Clear();
            watch.Start();
            ascii.Text = "";
            int x = 0;
            string teks = naskah.Text;
            ko(teks);
            int[] bytes = new int[outs.Length];
            for (int i = 0; i <bytes.Length; i++)
            {
                int indexasccii = 0;
                for (int j = 0; j < 256; j++)
                {
                    if(asciinum[j].Equals(outs[i]) == true)
                    {
                        indexasccii = j;
                        break;
                    }
                }
                bytes[i] = indexasccii;
            }
            enk.Text = "";
            string binner = "";
            fileenk = new String[teks.Length];
            string ew = count.binner(ee);
            string komp = "";
            using (StreamWriter sh = new StreamWriter(enkrip))
            {
                foreach (int b in bytes)
                {
                    sh.Write(count.sam(b, ew, n) + " ");
                }
            }
            
            watch.Stop();
            run.Text = Math.Round(Convert.ToDecimal(watch.ElapsedMilliseconds) / 1000, 4).ToString() + " ms";
            
            using (StreamReader sr = new StreamReader(enkrip))
            {
                ascii.Text = sr.ReadToEnd();
            }
            enk.Text = outs.ToString();

            message.Text = ascii.Text;


            long length = new System.IO.FileInfo(enkrip).Length;
            resiz.Text = Convert.ToString(length) + " Bytes";
            double comprat = (double)((enk.Text).Length * 8) / ((naskah.Text).Length * 8);
            comprat = Convert.ToDouble(String.Format("{0:0.00}", comprat)) * 100;

            Console.Write("setelah = " + (enk.Text).Length * 8 + " sebelum = " + (naskah.Text).Length * 8);

            double spacesavings = (double)((enk.Text).Length * 8) / ((naskah.Text).Length * 8);
            spacesavings = Convert.ToDouble(String.Format("{0:0.00}", spacesavings));

            cr.Text = "Compression Ratio:" + comprat + "%";
            ss.Text = "Space Savings : " + (100 - (spacesavings * 100)) + "%";
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            BigInteger pd = BigInteger.Parse(privatd.Text);
            BigInteger word = 1;

            var watch = new System.Diagnostics.Stopwatch();
            string dekrip = @"c:\temp\enkriphasil.temp";
            string dekomp = @"c:\temp\dekompresihasil.temp";
            if (File.Exists(dekrip))
            {
                File.Delete(dekrip);
            }
            if (File.Exists(dekomp))
            {
                File.Delete(dekomp);
            }
            watch.Start();
            dekompresi(message.Text);
            using (StreamReader r = new StreamReader(dekomp))
            {
                enkripsi(r.ReadToEnd(), pd, word);
            }

            watch.Stop();


            runtime2.Text = Math.Round(Convert.ToDecimal(watch.ElapsedMilliseconds) / 1000, 4).ToString() + " ms";
            using (StreamReader r = new StreamReader(dekomp))
            {
                ciphertext.Text = r.ReadToEnd();
            }
            using (StreamReader r = new StreamReader(dekrip))
            {
                dekripsi.Text = r.ReadToEnd();
            }
            if ((ciphertext.Text).Equals("error") == true)
            {
                dekripsi.Text = "error";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    long size = 1;
                    string text = File.ReadAllText(file);
                    size = new FileInfo(openFileDialog1.FileName).Length;
                    filnm.Text = file;
                    message.Text = text;

                }
                catch (IOException)
                {
                }
                Console.WriteLine("upload file berhasil");
            }
            else
                Console.WriteLine("upload file gagal");
            long filesizer = new System.IO.FileInfo(filnm.Text).Length;
            deks.Text = filesizer + " bytes";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "plaintext.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.Write(dekripsi.Text);
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        public BigInteger agrawalor(BigInteger n)
        {
            int z = 0;
            BigInteger result = 0;
            for (int i = 0; i<4; i++) {
                z = rnd.Next(3, (int)n - 2);
                if ((count.sam(1 + z, (count.binner(n)), n)) == (1 + (count.sam(z, count.binner(n), n)) % n) && (n % 2 != 0 && n % 5 != 0))
                    result = n;
                else
                {
                    result = -1;
                    break;
                   
                }   
            }
            if (result == n)
            {
                return result;
            }
            else
            return agrawalor(rnd.Next(100, 10000));
        }

    }
    public class count
    {
        public static int todesimal(string n)
        {
            
            int x = n.Length-1, desimal = 1;
            int hasil = 0;
            
            while(x > -1)
            {
                
                if (n[x] == '1')
                {
                    hasil += desimal;
                }
               
                x--;
                desimal = desimal * 2;
            }
            //Console.WriteLine(n + " : "+hasil+" : "+ Convert.ToChar(hasil));
            return hasil;
            
            
        }
        public static String binner(BigInteger n)
        {
            BigInteger x = n, pemicu = 1;
            String hasil = "";
            while (x > 0)
            {
                hasil = "" + x % 2 + "" + hasil;
                x = x / 2;
            }
            return hasil;
        }
        public static BigInteger sam(BigInteger x, String bin, BigInteger y)
        {
            int i;
            BigInteger z = 1;
            for (i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '0')
                {
                    z = (BigInteger.Multiply(z,z))  % y ;
                    //Console.WriteLine(i + ". z =(" + BigInteger.Multiply(z, z) + ") mod " + y + " = " + z);
                }
                if (bin[i] == '1')
                {
                    z = (BigInteger.Multiply((BigInteger.Multiply(z, z)),x)) % y;
                    //Console.WriteLine(i + ". z =((" + BigInteger.Multiply(z, z) + ")*" + x + ") mod " + y + "= " + z);
                }
            }
            return z;
        }
        public static BigInteger diophantin(BigInteger mi, BigInteger ni)
        {
            BigInteger x = 0, y = 1, d0 = 0, k = 0, ew = 0, uw = 0;
            BigInteger x2 = 1, y2 = 0, d2 = 0;
            BigInteger x3 = 0, y3 = 0, d3 = 0;
            if (mi > ni)
            {
                ew = mi;
                uw = ni;
                d0 = mi;
                d2 = ni;
            }
            else
            {
                ew = ni;
                uw = mi;
                d0 = ni;
                d2 = mi;
            }
            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x = " + x + " y = " + y + " d0 = " + d0 + " k =" + k);
            k = BigInteger.Divide(d0, d2);
            x3 = BigInteger.Subtract(x, (BigInteger.Multiply(x2, k)));
            y3 = BigInteger.Subtract(y, (BigInteger.Multiply(y2, k)));
            d3 = BigInteger.Subtract(d0, (BigInteger.Multiply(d2, k)));

            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x2 = " + x2 + " y2 = " + y2 + " d2 = " + d2 + " k =" + k);
           
            try
            {
                k = BigInteger.Divide(d2, d3);
            }
            catch (Exception ex)
            {
                // handle exception here
                Console.WriteLine(d0 + " / " + d2);
            }
            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x3 = " + x3 + " y3 = " + y3 + " d3 = " + d3 + " k =" + k);

            do
            {
                x = x2;
                y = y2;
                d0 = d2;
                x2 = x3;
                y2 = y3;
                d2 = d3;
                k = BigInteger.Divide(d0, d2);
                x3 = BigInteger.Subtract(x, (BigInteger.Multiply(x2, k)));
                y3 = BigInteger.Subtract(y, (BigInteger.Multiply(y2, k)));
                d3 = BigInteger.Subtract(d0, (BigInteger.Multiply(d2, k)));


            }
            while (d3 != 1);
            Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x3 = " + x3 + " y3 = " + y3 + " d3 = " + d3 + " k =" + k);

            if (x3 < 0)
            {
                return ew - (x3 * -1);
            }
            else
                return x3;
        }
        public static BigInteger diophantiny(BigInteger mi, BigInteger ni)
        {
            BigInteger x = 0, y = 1, d0 = 0, k = 0,ew=0,uw=0;
            BigInteger x2 = 1, y2 = 0, d2 = 0;
            BigInteger x3 = 0, y3 = 0, d3 = 0;
            if (mi > ni)
            {
                ew = mi;
                uw = ni;
                d0 = mi;
                d2 = ni;
            }
            else
            {
                ew = ni;
                uw = mi;
                d0 = ni;
                d2 = mi;
            }
            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x = " + x + " y = " + y + " d0 = " + d0 + " k ="+ k);
            k = BigInteger.Divide(d0, d2);
            x3 = BigInteger.Subtract(x, (BigInteger.Multiply(x2, k)));
            y3 = BigInteger.Subtract(y, (BigInteger.Multiply(y2, k)));
            d3 = BigInteger.Subtract(d0, (BigInteger.Multiply(d2, k)));
            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x2 = " + x2 + " y2 = " + y2 + " d2 = " + d2 + " k =" + k);

            try
            {
                k = BigInteger.Divide(d2, d3);
            }
            catch (Exception ex)
            {
                // handle exception here
                Console.WriteLine(d0+ " / "+d2);
            }
           

            //Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x3 = " + x3 + " y3 = " + y3 + " d3 = " + d3 + " k =" + k);
            try {
                do
                {
                    x = x2;
                    y = y2;
                    d0 = d2;
                    x2 = x3;
                    y2 = y3;
                    d2 = d3;
                    k = BigInteger.Divide(d0, d2);
                    x3 = BigInteger.Subtract(x, (BigInteger.Multiply(x2, k)));
                    y3 = BigInteger.Subtract(y, (BigInteger.Multiply(y2, k)));
                    d3 = BigInteger.Subtract(d0, (BigInteger.Multiply(d2, k)));


                //    Console.WriteLine("ew = " + d0 + " uw = " + d2 + " x3 = " + x3 + " y3 = " + y3 + " d3 = " + d3 + " k =" + k);
                }
                while (d3 != 1);
            }
            catch (Exception ex)
            {
                // handle exception here
                Console.WriteLine(d0 + " / " + d2);
            }
            if (y3 < 0)
            {
                return uw - (y3 * -1);
            }
            else
                return y3;
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

    
}
