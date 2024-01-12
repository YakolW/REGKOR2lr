using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace REGKOR2lr
{
    public partial class Form1 : Form
    {
        public int sum=0;
        string[,] pmas = new string[3, 3];
        string passw,PASal;
        int i, j,m=0;
        int y = 0;
        string g;
        int p;
        int l;
        int f = 0;
        int v = 0;
        string kodsim = "-";
        int schet = 1;
        int had;
        string[] strtxt;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] strtxt = (File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251")));
            for (int i = 0; i < strtxt.Length; i++) {
                if (TBlog.Text== strtxt[i])
                {
                    had = i;
                    groupBox1.Visible = true;
                } 
            }
            if (groupBox1.Visible == false)
            {
                MessageBox.Show("Неверный логин");
            }
        }

        private void TBpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'ц') || (e.KeyChar == 'к') || (e.KeyChar == 'н') || (e.KeyChar == 'г') || (e.KeyChar == 'ш') || (e.KeyChar == 'щ') || (e.KeyChar == 'з') || (e.KeyChar == 'х') || (e.KeyChar == 'ф') || (e.KeyChar == 'в') || (e.KeyChar == 'п') || (e.KeyChar == 'р') || (e.KeyChar == 'л') || (e.KeyChar == 'д') || (e.KeyChar == 'ж') || (e.KeyChar == 'ч') || (e.KeyChar == 'с') || (e.KeyChar == 'м') || (e.KeyChar == 'т') || (e.KeyChar == 'б'))
            {
                return;
            }
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = File.ReadAllText(comboBox1.Text, Encoding.GetEncoding("windows-1251"));
            }
            catch { }
          //  textBox1.Text = File.ReadAllText(comboBox1.Text, Encoding.GetEncoding("windows-1251"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(comboBox1.Text, true, System.Text.Encoding.GetEncoding(1251));

            file.WriteLine(textBox2.Text, Encoding.GetEncoding("windows-1251"));
            file.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int g = comboBox1.Items.Count;
            string sas = comboBox1.Text;

            string[] strtxt = (File.ReadAllLines("matrix.txt", Encoding.GetEncoding("windows-1251")));
            for (int i = 0; i < strtxt.Length; i++)
            {
                if (TBlog.Text == strtxt[i])
                {
                    f = i;
                }
            }
            string s = sas[1].ToString();
            l = Int32.Parse(s) + f;
           // textBox2.Text = strtxt[l].ToString();
            if (strtxt[l].ToString() == "w")
            {
                button3.Enabled = false;
                button5.Enabled = true;
            }
            if (strtxt[l].ToString() == "r")
            {
                button3.Enabled = true;
                button5.Enabled = false;
            }
            if (strtxt[l].ToString() == "w,r")
            {
                button3.Enabled = true;
                button5.Enabled = true;
            }
            if (strtxt[l].ToString() == "0")
            {
              button3.Enabled = false;
              button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 1;

            string[] STRTXT = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));

            for (int i = 0; i < STRTXT.Length; i++)
            {
                if (i % 2 == 0)
                {
                    p++;
                }
            }

           // p = 4;

            
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
                if (x % (g + 1) == 0)
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

        private void button4_Click(object sender, EventArgs e)
        {
            string d = textBox2.Text + ".txt";
            // StreamWriter test1 = new StreamWriter(@"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug/ddd.txt"+ddd);
            StreamWriter file = new StreamWriter(@"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has/" + d, true, System.Text.Encoding.GetEncoding(1251));
            //C:\Users\ykval\source\repos\REGKOR2lr\REGKOR2lr\bin\Debug
            file.Close();
            comboBox1.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {  
           groupBox1.Visible=false;
           groupBox3.Visible = false;


            string path = @"C:\\Users\\ykval\\source\\repos\\REGKOR2lr\\REGKOR2lr\\bin\\Debug\\has";
            // comboBox1.Items.Add = Directory.GetFiles(path);
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                comboBox1.Items.Add(file.Name);
            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            v++;
            if (v % 3 == 0)
            {
                button2.Enabled = false;
                Thread.Sleep(3000);
                button2.Enabled = true;
            }

            passw = TBpass.Text;
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
                        if (i+1== pmas.GetLength(0) && j+1 == pmas.GetLength(1))
                        {
                            PASal = PASal + pmas[i, j];
                       
                        }
                        else
                        {
                            PASal = PASal + pmas[i, j] + "-";
                        
                        }
                       
                    }
                }
                //админ
                //ссммллттррннкк
                //-с-л-л-с-м-0-м-0-0-т-н-н-т-р-0-р-0-0-к-0-0-к-0-0-0-0-0
            }
            
            string[] tex = File.ReadAllLines("REGlog.txt", Encoding.GetEncoding("windows-1251"));

            if (PASal == tex[had+1])
            {
                if (TBlog.Text == "админ")
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    sum++;
                }
                else
                {
                    MessageBox.Show("Вы вошли с правами обычного пользователя!");
                    groupBox3.Visible = true;
                   Size = new Size(500, 310);
                }
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }
    }
}
