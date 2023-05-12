using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banker_s_algo
{
    public partial class AlgorithmStepsForm : Form
    {
        public AlgorithmStepsForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
        }

        public AlgorithmStepsForm(List<string> steps, int[,] need)
        {
            InitializeComponent();
            
            Controls.Add(txtSteps);
            txtSteps.Text = string.Join(Environment.NewLine, steps);
            dgvNeed.DataSource = ConvertNeedToDataTable(need);
        }

        private DataTable ConvertNeedToDataTable(int[,] need)
        {
            DataTable dt = new DataTable();

            int rows = need.GetLength(0);
            int columns = need.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                dt.Columns.Add($"Resource {i}");
            }

            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < columns; j++)
                {
                    row[j] = need[i, j];
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

    }
}
