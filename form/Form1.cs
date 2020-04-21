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

namespace form
{
    public partial class Form1 : Form
    {
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

            string fileReadLog = File.ReadAllText("Log.txt");
            string fileReadPsw = File.ReadAllText("Psw.txt");


            for (int i = 1; i <= 3;  )
            {
                if (!(textLogin == fileReadLog && textPsw == fileReadPsw)) {
                    i++;
                    attempTxt.Text = String.Format("Осталось попыток {0} из 3", i);
                    
   
                }
                else
                {
                    MessageBox.Show("Вы успешно вошли в систему");
                    
                }

            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            var textLogin = logText.Text;

            var textPsw = pswText.Text;
            
            LoginAndPasw user = new LoginAndPasw(textLogin, textPsw);

            user.SaveFile();
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
