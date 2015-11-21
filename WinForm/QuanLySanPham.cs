using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using WinForm.SanPhamServiceReference;
using WinForm.TonKhoServiceReference;
using WinForm.NhaSXServiceReference; 
namespace WinForm
{
    public partial class QuanLySanPham : Form
    {
        SanPhamService1Client SanPhamClient = new SanPhamService1Client();
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();
        NhaSXService1Client NhaSXClient = new NhaSXService1Client();
        SanPham sp = new SanPham();


  
    }
}
