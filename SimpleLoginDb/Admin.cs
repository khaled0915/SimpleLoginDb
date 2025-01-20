using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginDb
{
    public partial class Admin : Form
    {


        private Login Fl { get; set; }
        public Admin()
        {
            InitializeComponent();
        }



        public Admin(string info, Login fl) : this()
        {
            this.lblInfo.Text += info.ToUpper();
            this.Fl = fl;
        }
    }
}
