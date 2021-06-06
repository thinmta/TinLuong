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
    public partial class T_frmPrintChamCongToGapDan : Form
    {
        public T_frmPrintChamCongToGapDan()
        {
            InitializeComponent();
        }

        private void T_frmPrintChamCongToGapDan_Load(object sender, EventArgs e)
        {
            T_PrintChamCongToGapDan xtr111 = new T_PrintChamCongToGapDan();


            xtr111.CreateDocument();
            Tr_dcvChamCongToGapDan.DocumentSource = xtr111;
        }
    }
}
