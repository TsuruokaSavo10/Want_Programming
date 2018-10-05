using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldTest
{
    public partial class Form1 : Form
    {
        string fie_info = "8 11:-2 1 0 1 2 0 2 1 0 1 -2:1 3 2 -2 0 1 0 -2 2 3 1:1 3 2 1 0 -2 0 1 2 3 1:2 1 1 2 2 3 2 2 1 1 2:2 1 1 2 2 3 2 2 1 1 2:1 3 2 1 0 -2 0 1 2 3 1:1 3 2 -2 0 1 0 -2 2 3 1:-2 1 0 1 2 0 2 1 0 1 -2:2 2:7 10:";

        private int row_num;            //行数
        private int col_num;             //列数

        private string str1;
        private string str2;
        private string str3;
        
        private int[,] field = new int[12, 12];             //フィールドの得点が入る

        private System.Windows.Forms.TableLayoutPanel FieldPanel;

        /* コンストラクタ */
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            matrix_number();
            create_FieldPanel(col_num, row_num);
            field_point();
        }

        partial void create_FieldPanel(int col, int row);
        partial void matrix_number();
        partial void field_point();
    }
}
