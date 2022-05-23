using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;


namespace glava2._2
{




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = "C#.советы";
            string insertText = "Народные ";
            string bookTitle = partBookTitle.Insert(3, insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";

            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";

            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int i = str2.IndexOf(str1);

            if (i >= 0) listBox1.Items.Add(str1 + " входит в строку " + str2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog;
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void butFormatStr_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text =
            String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }

        private void butColorName_Click(object sender, EventArgs e)
        {
            Color clr = Color.Blue;

            textBox1.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
          
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
           
            this.BackColor = clr;
        }

        public void SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string myString = textBox1.Text;

            textBox1.Text = Strings.StrReverse(myString);
        }

        public static string ReverseString(string str)
        {
           
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            StringBuilder revStr = new StringBuilder(str.Length);

            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            
            return revStr.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
         private static extern bool PathCompactPathEx(
         System.Text.StringBuilder pszOut,
         string pszSrc,
         Int32 cchMax,
         Int32 dwFlags);

    private void button12_Click(object sender, EventArgs e)
        {
            string strPathFile = "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            
            textBox1.Text = sb.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;

                button1.Text = "Старт";
            }
        }

            public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            this.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private string scrollText = "C#.Народные советы ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            scrollText = scrollText.Substring(1,
         
            (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("строка 1");
            sb.Append("строка 2");
            this.Text = sb.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show(today.Date.ToLongDateString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }
    }
    
}
