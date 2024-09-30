namespace nguyenvantan_buoi8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IT_Click(object sender, EventArgs e)
        {
            SinhVienIT sinhVienIT = new SinhVienIT();
            sinhVienIT.diemJava = double.Parse(txt_diemjava.Text);
            sinhVienIT.diemCss = double.Parse(txt_diemcss.Text);
            MessageBox.Show(sinhVienIT.getDiemTB().ToString()+ sinhVienIT.xeploai());
        }

        private void btn_biz_Click(object sender, EventArgs e)
        {
            SinhVienBiz sinhVienBiz = new SinhVienBiz();
            sinhVienBiz.banhang = double.Parse(txt_banhang.Text);
            sinhVienBiz.ketoan = double.Parse(txt_ketoan.Text);
            sinhVienBiz.marketting = double.Parse(txt_marketting.Text);
            MessageBox.Show(sinhVienBiz.getDiemTB().ToString()+sinhVienBiz.xeploai());
        }
    }
}
