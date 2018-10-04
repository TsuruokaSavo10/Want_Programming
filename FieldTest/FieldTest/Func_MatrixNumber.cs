using System;
using System.Windows.Forms;

namespace FieldTest
{
    public partial class Form1 : Form
    {
        //フィールド縦横、エージェント位置取り出し関数
        partial void matrix_number()
        {
            string[] field_row = fie_info.Split(':');           //fie_infoを分割
            int count1 = 0;
            int count2 = 0;

            foreach (char c in field_row[0])                    //field[]←に数字を入れる
            {
                if (count1 == 0)
                {
                    row_num = int.Parse(c.ToString());
                    count1++;
                }
                else if (count1 == 1 && c != ' ' && count2 == 0)
                {
                    row_num = row_num * 10 + int.Parse(c.ToString());
                    count1++;
                }
                else if (c == ' ')
                {
                    count2++;
                }
                else if (count2 == 1)
                {
                    col_num = int.Parse(c.ToString());
                    count2++;
                }
                else if (count2 == 2)
                {
                    col_num = col_num * 10 + int.Parse(c.ToString());
                }
            }

            label5.Text = row_num.ToString();
            label6.Text = col_num.ToString();
        }
    }
}
