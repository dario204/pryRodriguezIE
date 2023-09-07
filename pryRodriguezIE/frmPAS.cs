using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezIE
{
    public partial class frmPAS : Form
    {
        public frmPAS()
        {
            InitializeComponent();
        }
        string Acuario = @"C:\Alumno\Source\repos\pryRodriguezIE\Proveedores\Acuario";
        string Alfa= @"C:\Alumno\Source\repos\pryRodriguezIE\Proveedores\Alfa";
        string Apolo= @"C:\Alumno\Source\repos\pryRodriguezIE\Proveedores\Apolo";
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void frmPAS_Load(object sender, EventArgs e)
        {
            //TreeNode Acuario = tvCarpetas.Nodes.Add(Acuario, carpeta1);
        }
    }
}
