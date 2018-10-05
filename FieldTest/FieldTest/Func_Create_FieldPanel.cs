using System;
using System.Windows.Forms;

namespace FieldTest
{
    public partial class Form1 : Form
    {
        partial void create_FieldPanel(int col, int row)
        {
            this.FieldPanel = new System.Windows.Forms.TableLayoutPanel();

            // 
            // FieldPanel
            // 
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.ColumnCount = col;
            this.FieldPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldPanel.RowCount = row;
            this.FieldPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldPanel.Location = new System.Drawing.Point(12, 12);
            this.FieldPanel.Size = new System.Drawing.Size(200, 100);
            this.FieldPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FieldPanel.TabIndex = 5;
        }
    }
}
