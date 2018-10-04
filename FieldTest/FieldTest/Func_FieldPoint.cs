using System;
using System.Windows.Forms;

namespace FieldTest
{
    public partial class Form1 : Form
    {
        partial void field_point()
        {
            string[] field_row = fie_info.Split(':');           //fie_infoを分割

            for (int i = 0; i < row_num; i++)
            {
                int all_insert = 0;
                int minus_insert = 0;

                int count = 0;
                int col_count = 0;

                field_row[i + 1] += ' ';  //文字列の終端に「 」を入れる

                foreach (char c in field_row[i + 1])
                {
                    if (c == '-')
                    {
                        str1 = c.ToString();
                        minus_insert++;
                    }
                    else if (count == 0)
                    {
                        str2 = c.ToString();
                        count++;
                    }
                    else if (count == 1 && c != ' ')
                    {
                        str3 = c.ToString();
                        all_insert++;
                    }

                    if (c == ' ')
                    {
                        string all_string;
                        if (all_insert == 1)
                        {
                            all_string = str1 + str2 + str3;
                        }
                        else if (minus_insert == 1)
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

            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
