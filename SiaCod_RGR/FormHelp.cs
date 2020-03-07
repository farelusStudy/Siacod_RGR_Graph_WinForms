using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SiaCod_RGR
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            List<string> info = new List<string>();
            info = File.ReadAllLines("Userhelp.txt", Encoding.Default).ToList();
            foreach (var line in info)
            {
                txtInfo.Text += line + '\r'+'\n';
            }
        }
        
    }
}
