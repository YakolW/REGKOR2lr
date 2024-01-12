using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace REGKOR2lr
{

    public partial class Form2 : Form
    {
        int a;
        int f=0;
        string passw, PASal;
        int schet;
        int l;
        string[,] pmas = new string[3, 3];
        int y = 0;
        string g;
       public string[] Srw;
        public string[] str;
        int dsa = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
           // textBox1.Visible = false;
            MessageBox.Show("Вход с правами администратора!");


            string path = @"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has";
            // comboBox1.Items.Add = Directory.GetFiles(path);
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles( "*.txt");
            foreach (FileInfo file in files)
            {
                comboBox1.Items.Add(file.Name);
            }
            
            // comboBox1.Items.Add (files[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           // textBox1.Visible = true;
            string[] STRTXT = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));
            for (int i = 0; i < STRTXT.Length; i++)
            {
                if (i % 2 == 0)
                {
                    textBox1.Text += "Логин: " + STRTXT[i] + "\r\n";
                }
                else
                {
                    textBox1.Text += "Пароль: " + STRTXT[i] + "\r\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 1;
           // groupBox1.Visible = true;
            button5.Text = "Добавить пользователя";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 2;
         //   groupBox1.Visible = true;
            button5.Text = "Удалить пользователя";
        }

        private void textBoxpas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'ц') || (e.KeyChar == 'к') || (e.KeyChar == 'н') || (e.KeyChar == 'г') || (e.KeyChar == 'ш') || (e.KeyChar == 'щ') || (e.KeyChar == 'з') || (e.KeyChar == 'х') || (e.KeyChar == 'ф') || (e.KeyChar == 'в') || (e.KeyChar == 'п') || (e.KeyChar == 'р') || (e.KeyChar == 'л') || (e.KeyChar == 'д') || (e.KeyChar == 'ж') || (e.KeyChar == 'ч') || (e.KeyChar == 'с') || (e.KeyChar == 'м') || (e.KeyChar == 'т') || (e.KeyChar == 'б'))
            {
                return;
            }
            e.Handled = true;
        }

     

        private void button8_Click(object sender, EventArgs e)
        {
            string d = textBox2.Text+".txt";
            // StreamWriter test1 = new StreamWriter(@"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug/ddd.txt"+ddd);
            StreamWriter file = new StreamWriter(@"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/" + d,true, System.Text.Encoding.GetEncoding(1251));
            //C:\Users\ykval\source\repos\REGKOR2lr\REGKOR2lr\bin\Debug
            file.Close();
            comboBox1.Items.Clear();


        }

        private void button10_Click(object sender, EventArgs e)
        {

           textBox1.Text = File.ReadAllText(comboBox1.Text, Encoding.GetEncoding("windows-1251"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(comboBox1.Text, true, System.Text.Encoding.GetEncoding(1251));
           
                file.WriteLine(textBox2.Text, Encoding.GetEncoding("windows-1251"));
                file.Close();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 1;
            int p = comboBox2.Items.Count;
            comboBox1.Items.Clear();
            string path = @"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/";
           
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                comboBox1.Items.Add(file.Name);
            }
            int g = comboBox1.Items.Count;

            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            int raz = p * g;
       
       

            File.WriteAllText("matrix.txt", "");
            StreamWriter test = new StreamWriter("matrix.txt", true, System.Text.Encoding.GetEncoding(1251));
            for (int i = 0; i < raz; i++)
            {
                if (x % (g+1) == 0)
                {
                    test.WriteLine("0", Encoding.GetEncoding("windows-1251"));
                    i--;
                }
                else
                {
                    test.WriteLine(strtxt[i], Encoding.GetEncoding("windows-1251"));
                }
                x++;
            }
            test.WriteLine("0", Encoding.GetEncoding("windows-1251"));
            test.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            textBox1.Text = "";
            textBox1.Text += "                     ";
            string path = @"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/";
            int x = 0;
            int y = 0;
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                textBox1.Text += file.Name + "       ";
                x++;
            }
            int k = comboBox3.Items.Count;
            int u = comboBox2.Items.Count;
            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            textBox1.Text += "\r\n";
            for (int j = 0; j < u; j++) 
            {
                for (int i = 0; i <= k; i++)
                {
                   // textBox1.Text += "\r\n";
                    textBox1.Text += strtxt[y] + "           ";
                    y++;
                }
               
                textBox1.Text += "\r\n";
            }
            }
            catch { }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            string[] STRTXT = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));
           
                for(int i = 0;i < STRTXT.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        comboBox2.Items.Add(STRTXT[i]);
                    }
                }



      
            string path = @"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/";

            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                comboBox3.Items.Add(file.Name);
            }


            
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
           
            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            int raz = strtxt.Length;
            strtxt[l] = textBox4.Text;
            File.WriteAllText("matrix.txt", "");
            StreamWriter file = new StreamWriter("matrix.txt", true, System.Text.Encoding.GetEncoding(1251));
            for (int i = 0; i < raz; i++)
            {
                file.WriteLine(strtxt[i], Encoding.GetEncoding("windows-1251"));
            }
            file.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           int g = comboBox3.Items.Count;
            string sas = comboBox3.Text;

            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            for (int i = 0; i < strtxt.Length; i++)
            {
                if (comboBox2.Text == strtxt[i])
                {

                    f = i;
                }
            }
            string s = sas[1].ToString();
            l = Int32.Parse(s) + f;
            textBox3.Text = strtxt[l].ToString();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = 1;
            int g = comboBox1.Items.Count;
            int p = comboBox2.Items.Count;
            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            int raz = p * g;


            string sas = comboBox1.Text;
            string s = sas[1].ToString();
            l = Int32.Parse(s);

            File.WriteAllText("matrix.txt", "");
            StreamWriter test = new StreamWriter("matrix.txt", true, System.Text.Encoding.GetEncoding(1251));
            for (int i = 0; i < raz+3; i++)
            {
                if (x % (l+1) == 0)
                {
                   // test.WriteLine("0", Encoding.GetEncoding("windows-1251"));
                   // i--;
                }
                else
                {
                    test.WriteLine(strtxt[i], Encoding.GetEncoding("windows-1251"));
                }
                x++;
            }
           // test.WriteLine("0", Encoding.GetEncoding("windows-1251"));
            test.Close();
            File.Delete(@"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/" + comboBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                string[] STRTXT = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));
                passw = textBoxpas.Text;
                int razm = passw.Length;
                int n = 0;
                y = 0;
                n = 0;
                float p = razm / 5;
                float f = razm % 5;

                if (f != 0)
                {
                    p = p + 1;
                }
                for (int t = 0; t < p; t++)
                {
                    schet = 1;
                    for (int i = 0; i < pmas.GetLength(0); i++)
                    {

                        for (int j = 0; j < pmas.GetLength(1); j++)
                        {

                            g = "0";
                            pmas[i, j] = g;

                        }
                    }

                    for (int i = 0; i < pmas.GetLength(0); i++)
                    {
                        if (y < razm)
                        {
                            pmas[i, 0] = passw[n].ToString();
                        }
                        n++;
                        y++;

                    }

                    for (int i = 1; i < 2; i++)
                    {
                        if (y < razm)
                        {
                            pmas[1, 1] = passw[n].ToString();
                        }
                        n++;
                        y++;

                    }

                    for (int j = 2; j > 0; j--)
                    {
                        if (y < razm)
                        {
                            pmas[0, j] = passw[n].ToString();
                        }
                        n++;
                        y++;

                    }


                    PASal = PASal + "-";
                    for (int i = 0; i < pmas.GetLength(0); i++)
                    {
                        for (int j = 0; j < pmas.GetLength(1); j++)
                        {
                            if (i + 1 == pmas.GetLength(0) && j + 1 == pmas.GetLength(1))
                            {
                                PASal = PASal + pmas[i, j];
                            }
                            else
                            {
                                PASal = PASal + pmas[i, j] + "-";
                            }
                        }
                    }

                    for (int i = 0; i < STRTXT.Length; i++)
                    {
                        if (textBoxlog.Text == STRTXT[i])
                        {
                            dsa = 1;
                        }

                    }

                }

                StreamWriter file = new StreamWriter("REGlog.txt", true, System.Text.Encoding.GetEncoding(1251));
                if (dsa == 0)
                {

                    file.WriteLine(textBoxlog.Text, Encoding.GetEncoding("windows-1251"));
                    file.WriteLine(PASal, Encoding.GetEncoding("windows-1251"));
                    file.Close();
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                }
                file.Close();
                dsa = 0;






               // фыа

            }
            
            if (a == 2)
            {
                string[] STRTX = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));

                for (int i = 0; i < STRTX.Length; i++)
                {
                    if (textBoxlog.Text == STRTX[i])
                    {
                        STRTX[i] = "";
                        STRTX[i + 1] = "";
                    }
                }
            File.WriteAllLines("REGlog.txt", STRTX, Encoding.GetEncoding("windows-1251"));
            }
        }
    }
}
