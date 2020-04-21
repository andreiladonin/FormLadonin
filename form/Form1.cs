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
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace form
{
    public partial class Form1 : Form
    {
        private int lockOut =3;
        private string SuperPasord = "admmin";
        public Form1()
        {
            InitializeComponent();

            regBtn.Click += RegBtn_Click;
            butnEnter.Click += ButnEnter_Click;
        }

        private void ButnEnter_Click(object sender, EventArgs e)
        {


            var textLogin = logText.Text;

            var textPsw = pswText.Text;

            if (lockOut == 0)
            {
                attempTxt.Text = string.Format("Lock");
                return;

            }

            if (textPsw == SuperPasord)
            {
                lockOut = 3;
            }

            string fileReadLog = File.ReadAllText("Log.txt");
            string fileReadPsw = File.ReadAllText("Psw.txt");


            if (!(textLogin == fileReadLog && textPsw == fileReadPsw))
            {
                lockOut--;
                attempTxt.Text = String.Format("Осталось попыток {0} из 3", lockOut);
            }

        }                
        private void RegBtn_Click(object sender, EventArgs e)
        {
            var textLogin = logText.Text;

            var textPsw = pswText.Text;
            
            LoginAndPasw user = new LoginAndPasw(textLogin, textPsw);

            user.SaveFile();

            MessageBox.Show("Вы зарегистрированы");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {

        }

        private void pswText_TextChanged(object sender, EventArgs e)
        {

        }

        private void logText_TextChanged(object sender, EventArgs e)
        {

        }

        private void butnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
