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
        public Form1()
        {
            InitializeComponent();
        }

        string fie_info = "8 11:-2 1 0 1 2 0 2 1 0 1 -2:1 3 2 -2 0 1 0 -2 2 3 1:1 3 2 1 0 -2 0 1 2 3 1:2 1 1 2 2 3 2 2 1 1 2:2 1 1 2 2 3 2 2 1 1 2:1 3 2 1 0 -2 0 1 2 3 1:1 3 2 -2 0 1 0 -2 2 3 1:-2 1 0 1 2 0 2 1 0 1 -2:2 2:7 10:";

        private int row_num;            //行数
        private int col_num;             //列数

        private string str1;
        private string str2;
        private string str3;
        
        private int[,] field = new int[12, 12];             //フィールドの得点が入る


        private void button1_Click(object sender, EventArgs e)
        {
            matrix_number();
            field_point();
        }

        //フィールド縦横、エージェント位置取り出し関数
        private void matrix_number()
        {
            string[] field_row = fie_info.Split(':');           //fie_infoを分割
            int count1 = 0;
            int count2 = 0;
            
            foreach(string str in field_row)
            {
                
            }

            foreach (char c in field_row[0])                    //field[]←に数字を入れる
            {
                if (count1 == 0 )
                {
                    row_num = int.Parse(c.ToString());
                    count1++;
                }
                else if (count1 == 1 && c != ' ' && count2 == 0)
                {
                    row_num = row_num*10+int.Parse(c.ToString());
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
                }else if(count2 == 2)
                {
                    col_num = col_num*10+int.Parse(c.ToString());
                }
            }
            label5.Text = row_num.ToString();
            label6.Text = col_num.ToString();
        }
        private void field_point()
        {
            string[] field_row = fie_info.Split(':');           //fie_infoを分割

            for(int i = 0; i < row_num; i++)
            {
                int all_insert = 0;
                int minus_insert = 0;

                int count = 0;
                int col_count = 0;

                field_row[i+1] += ' ';  //文字列の終端に「 」を入れる

                foreach (char c in field_row[i+1])
                {
                    if(c == '-')
                    {
                        str1 = c.ToString();
                        minus_insert++;
                    }
                    else if(count == 0)
                    {
                        str2 = c.ToString();
                        count++;
                    }
                    else if(count == 1 && c != ' ')
                    {
                        str3 = c.ToString();
                        all_insert++;
                    }

                    if (c == ' ')
                    {
                        string all_string;
                        if(all_insert == 1)
                        {
                            all_string = str1 + str2 + str3;
                        }
                        else if(minus_insert == 1)
                        {
                            all_string = str1 + str2;
                        }
                        else
                        {
                            all_string = str2;
                        }

                        int num = int.Parse(all_string);

                        field[i, col_count] = num;
                        col_count++;

                        all_insert = 0;
                        minus_insert = 0;
                        count = 0;
                    }
                }
            }

            for(int i = 0; i < row_num; i++)
            {
                for(int j = 0; j < col_num; j++)
                {
                    Console.Write(field[i, j] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
