using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace banker_s_algo
{
    public partial class Form1 : Form
    {
        private BankersAlgorithm bankersAlgorithm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckRequest_Click(object sender, EventArgs e)
        {
            // Read the available vector first
            int[] available = ReadVector(txtAvailable.Text);
            if (available == null)
            {
                MessageBox.Show("Invalid available vector format. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read input values from form controls and create appropriate data structures
            int[,] allocation = ReadMatrix(txtAllocation.Text, available.Length);
            int[,] maximum = ReadMatrix(txtMaximum.Text, available.Length);
            int[] totalResources = ReadVector(txtTotalResources.Text);
            if (totalResources == null || available == null || allocation == null || maximum == null)
            {
                MessageBox.Show("Invalid input format. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the BankersAlgorithm class
            try
            {
                bankersAlgorithm = new BankersAlgorithm(allocation, maximum, totalResources, available);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read the process ID and requested resources from the form controls
            int processId = (int)numProcessId.Value;
            int[] request = ReadVector(txtRequest.Text);

            if (request == null)
            {
                MessageBox.Show("Invalid request format. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the RequestResources method and display the result
            var result = bankersAlgorithm.RequestResources(processId, request);
            if (result.Granted)
            {
                MessageBox.Show("Request Granted", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new AlgorithmStepsForm(result.Steps, bankersAlgorithm.need);
                form.ShowDialog(this);
                // Refresh the data after the steps form is closed
                RefreshData();
            }
            else
            {
                MessageBox.Show("Request Denied", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new AlgorithmStepsForm(result.Steps, bankersAlgorithm.need);
                form.ShowDialog(this);
                RefreshData();
            }
        }

        private void RefreshData()
        {
            // Refresh the data fields from the bankersAlgorithm instance
            txtAllocation.Text = MatrixToString(bankersAlgorithm.allocation);
            txtAvailable.Text = VectorToString(bankersAlgorithm.available); //Changed from AvailableResources to CurrentResources
            txtMaximum.Text = MatrixToString(bankersAlgorithm.maximum);
            txtTotalResources.Text = VectorToString(bankersAlgorithm.totalResources);
        }

        private string VectorToString(int[] vector)
        {
            return string.Join(' ', vector);
        }

        private string MatrixToString(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            var sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sb.Append(matrix[i, j]);
                    if (j < columns - 1) sb.Append(' ');
                }
                if (i < rows - 1) sb.AppendLine();
            }

            return sb.ToString();
        }

        private int[,] ReadMatrix(string text, int expectedColumns)
        {
            try
            {
                var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var rowCount = lines.Length;
                int[,] matrix = new int[rowCount, expectedColumns];

                for (int i = 0; i < rowCount; i++)
                {
                    int[] rowValues = lines[i].Split(' ').Select(int.Parse).ToArray();
                    if (rowValues.Length != expectedColumns)
                    {
                        throw new ArgumentException($"Expected {expectedColumns} columns, but got {rowValues.Length}.");
                    }
                    for (int j = 0; j < expectedColumns; j++)
                    {
                        matrix[i, j] = rowValues[j];
                    }
                }

                return matrix;
            }
            catch
            {
                return null;
            }
        }


        private int[] ReadVector(string text)
        {
            try
            {
                var vector = text.Split(' ').Select(int.Parse).ToArray();
                if (vector.Length == 0) // Add this dimension check
                {
                    throw new ArgumentException("Empty vector is not allowed");
                }
                return vector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void lblSystemState_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}