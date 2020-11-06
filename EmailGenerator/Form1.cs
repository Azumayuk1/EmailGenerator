using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailGenerator
{
    public partial class Form1 : Form
    {
        public static Random random = new Random();// RANDOM
        public Form1() { InitializeComponent(); }
        private void label1_Click(object sender, EventArgs e) { }//игнорируем


        public static string genName()// генерирует название ящика
        {
            string name_func = "";
            string sogl = "qwrtpsdfghjklzxcvbnm";
            string glas = "eyuioa";
            for (int i = 0; i < random.Next(4, 12); i++)
            {
                if (i % 2 == 0)
                {
                    name_func += sogl[random.Next(sogl.Length)];
                }
                else { name_func += glas[random.Next(glas.Length)]; }
            }
            return name_func;
        }
        public string genSecondDomain()// генерирунт домен второго уровня
        {
            if (Checkbox_defaultdomain.Checked == true)
            { return Default_SecondLevelDomain.Text; }
            string name_second_domain = "";
            string sogl = "qwrtpsdfghjklzxcvbnm";
            string glas = "eyuioa";
            for (int i = 0; i < random.Next(3, 8); i++)
            {
                if (i % 2 == 0)
                {
                    name_second_domain += sogl[random.Next(sogl.Length)];
                }
                else { name_second_domain += glas[random.Next(glas.Length)]; }
            }
            return name_second_domain;
        }
        public string genFirstDomain()// генерирует домен первого уровня
        {
            if (Checkbox_defaultdomain.Checked == true)
            { return default_FirstLeveldomain.Text; }
            string name_first_domain = "";
            string alph = "qwrtpsdfghjklzxcvbnmeyuioa";
            for (int i = 0; i < random.Next(2, 4); i++)
            {
                name_first_domain += alph[random.Next(alph.Length)];
            }
            return name_first_domain;
        }

        public string genFullEmail()// генерирует полный адрес
        {
            string full_email = $"{genName()}@{genSecondDomain()}.{genFirstDomain()}\n";
            return full_email;
        }

        public string gen_mail_password() //Генерирует пароль для почты
        {
            string password_mail = "";
            string password_symbols = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM_@%*";
            for (int i = 0; i < Convert.ToInt32(Password_Length.Text); i++)
            {
                password_mail += password_symbols[random.Next(password_symbols.Length)];
            }
            return password_mail;
        }

       
private void btn_GenerateEmails_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(EmailsNumText.Text); i++) 
            { 
                MainConsole.Text += $"{genFullEmail()} {gen_mail_password()}\n";
                MainConsole.Text += "----------------------------------------------- \n";
            }
            
        }
    }
}
