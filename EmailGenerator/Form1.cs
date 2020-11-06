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
        public Form1() {InitializeComponent();}
        private void label1_Click(object sender, EventArgs e){}//игнорируем

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


    }
}
