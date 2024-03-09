using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
        }
        double saniye;

        public class ntDll
        {
            [DllImport("user32")]
            public static extern void
                LockWorkStation();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Kilitlensinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                ntDll.LockWorkStation();
            }
            if (soru == DialogResult.No)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru= MessageBox.Show("Bilgisayar Kapatılsınmı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(soru==DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
            }
            if (soru == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Yeniden Başlatılsın mı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(soru==DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
            }
            if(soru==DialogResult.No)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Uykuya Geçsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes) 
            {
                System.Diagnostics.Process.Start("shutdown", "-h");

            }
            if (soru == DialogResult.No)
            {

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Oturum Kapatılsınmı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-l -f");
            }
            if (soru == DialogResult.No)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            label2.Text = saniye.ToString();
            if (saniye == 0)

            { 
                if(radioButton1.Checked)
                {
                    System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
                }
                else if (radioButton2.Checked)
                {
                    System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
                }
                else if(radioButton3.Checked)
                {
                    System.Diagnostics.Process.Start("shutdown", "-h");
                }
                else if(radioButton4.Checked)
                {
                    System.Diagnostics.Process.Start("shutdown", "-l -f");
                }
                else 
                {
                    ntDll.LockWorkStation();
                    //System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation"); -- aynı işlem class dışında
                }
                timer1.Stop();
                Application.Exit();
                this.Close();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button6.Visible = true;
                button7.Visible = true;
                checkBox1.Text = "Devre Dışı";
                radioButton5.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton2.Visible = true;
                radioButton1.Visible = true;
                label1.Text = "Seçeneğinizin Gerçekleştirilmesine Son :";
                textBox1.Visible = true;
                button5.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button5.Enabled = true;
                textBox1.Enabled = true;
                textBox1.Focus();

            }
            else
            {
                button6.Visible = false;
                button7.Visible = false;
                radioButton5.Visible = false;
                radioButton4.Visible = false;
                radioButton3.Visible = false;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                label1.Text = "Süreli Seçenek İçin Aktif Et Butonuna Tıklayın";
                textBox1.Visible = false;
                button5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                button5.Enabled = false;
                textBox1.Enabled = false;
                checkBox1.Text = "Etkinleştir";
            }
                
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            if(textBox1.Text=="")
            {
                MessageBox.Show("Lütfen İstediğiniz Dakikayı Belirtin");
                textBox1.Focus();
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
                double a;
                a = Convert.ToDouble(textBox1.Text);
                saniye = a * 60;
                timer1.Start();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Text = "";
            textBox1.Text = "";
            button7.Visible = false;
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if(button7.Text=="Durdur")
            {
                timer1.Stop();
                button7.Text = "Devam Et";
            }
            else 
            {
                button7.Text = "Durdur";
                timer1.Start();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar != 44)
            {
                e.Handled =true;
            }
            
        }

       
    }
}
