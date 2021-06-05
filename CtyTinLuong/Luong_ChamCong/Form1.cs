using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong.Luong_ChamCong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            T_PrintChamCongToGapDan xtr111 = new T_PrintChamCongToGapDan();

          
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;
        }
    }
}
