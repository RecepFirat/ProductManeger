using ProductSyncBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManeger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSourceModules.DataSource = ModuleManager.Modules;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
         bindingSourceProduct.DataSource=   ((ISyncModule)listBoxControl1.SelectedItem).GetList();
        }
    }
}
