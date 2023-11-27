using ATEC_OOP_Desktop_form.Composition;
using ATEC_OOP_Desktop_form.Inheritance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATEC_OOP_Desktop_form
{
    public partial class Form1 : Form
    {
        import _importFiles = new import();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(_importFiles.Import(Filename.Text));
            var _dialogCheckingImportFiles = new DialogCheckingImportFiles(new import(), new Export());

            MessageBox.Show(_dialogCheckingImportFiles.LocalImportFile(Filename.Text).ToString());
        }


        private void Export_Click(object sender, EventArgs e)
        {
            var _dialogCheckingImportFiles = new DialogCheckingImportFiles(new import(), new Export());

            MessageBox.Show(_dialogCheckingImportFiles.LocalExportFile(Filename.Text).ToString());
        }

        private void Filename_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
