namespace задание_23_бл_схемы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void Generate_Click(object sender, EventArgs e)
        {
            int n = 0, a=0,b=0;
            try
            {
                n = int.Parse(MassSize.Text);
                a = int.Parse(StartDiap.Text);
                b = int.Parse(LastDiap.Text);
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
               
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = n;
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rand.Next(a, b);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MassSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void StartDiap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number!='-') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void LastDiap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number!='-') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;
            
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            if (RowsSorting.Checked)
            {
                if (High.Checked)
                {
                    SortMatrByRows(dataGridView2, true);
                }
                else
                {
                    SortMatrByRows(dataGridView2, false);
                }
            }
            else
            {
                if (High.Checked)
                {
                    SortMatrByColumns(dataGridView2, true);
                }
                else
                {
                    SortMatrByColumns(dataGridView2, false);
                }
            }
        }
        static void SortMatrByRows(DataGridView dt, bool asc)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count - 1; j++)
                {
                    for (int k = j + 1; k < dt.Columns.Count; k++)
                    {
                        if ((asc && (int)dt.Rows[i].Cells[j].Value > (int)dt.Rows[i].Cells[k].Value) ||
                            (!asc && (int)dt.Rows[i].Cells[j].Value < (int)dt.Rows[i].Cells[k].Value))
                        {
                            int temp = (int)dt.Rows[i].Cells[j].Value;
                            dt.Rows[i].Cells[j].Value = dt.Rows[i].Cells[k].Value;
                            dt.Rows[i].Cells[k].Value = temp;
                        }
                    }
                }
            }
        }

        static void SortMatrByColumns(DataGridView dt, bool asc)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    for (int k = i + 1; k < dt.Rows.Count; k++)
                    {
                        if ((asc && (int)dt.Rows[i].Cells[j].Value > (int)dt.Rows[k].Cells[j].Value)||(!asc && (int)dt.Rows[i].Cells[j].Value < (int)dt.Rows[k].Cells[j].Value))
                        {
                            int temp = (int)dt.Rows[i].Cells[j].Value;
                            dt.Rows[i].Cells[j].Value = dt.Rows[k].Cells[j].Value;
                            dt.Rows[k].Cells[j].Value = temp;
                        }
                    }
                }
            }
        }

    }
}