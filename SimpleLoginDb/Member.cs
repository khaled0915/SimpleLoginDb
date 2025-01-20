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
    public partial class Member : Form
    {

       private Login Fl { get; set; }
        public Member()
        {
            InitializeComponent();
        }


        public Member(string info, Login fl) : this()
        {
            this.lblInfo.Text += info.ToUpper();
            this.Fl = fl;
        }
    }
}
