using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvFileLibrary;
using DispensaryLibrary;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        CsvFile file;
        List<Dispensary> filteredDisp;
        List<string[]> rawFilteredDisp;
        List<Dispensary> dispensaries = new List<Dispensary>();
        string currentPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            dispensaries.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            currentPath = OpenFileDialog.FileName;
            file = new CsvFile(currentPath, false);
            dataGridView2.ColumnCount = file.Header.Length;
            for (int i = 0; i < file.Header.Length; i++)
            {
                dataGridView2.Columns[i].Name = file.Header[i];
            }
            try
            {
                for (int i = 0; i < file.Length; i++)
                {
                    dataGridView2.Rows.Add(file.Fields[i]);
                    Dispensary dispensary = GetDispensaryFromRawData(file.Fields[i]);
                    if (dispensaries.Contains(dispensary))
                    {
                        MessageBox.Show("Ошибка. В файле встречаются 2 одинаковых объекта");
                        dataGridView2.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        return;
                    }
                    dispensaries.Add(dispensary);
                }
            }
            catch (DispensaryLibException ex)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.Rows.Clear();
                MessageBox.Show($"Обработано искючение {ex.GetType()}: {ex.Message}");
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows[0].Cells[0].Value; TODO: Edit
        }
        private Dispensary GetDispensaryFromRawData(string[] line)
        {
            return new Dispensary(line[(int)DefaultFields.FullName],
                        line[(int)DefaultFields.ShortName], line[(int)DefaultFields.AdmArea], line[(int)DefaultFields.District],
                        line[(int)DefaultFields.POINT_X], line[(int)DefaultFields.POINT_Y],
                        line[(int)DefaultFields.PostalCode], line[(int)DefaultFields.Address], line[(int)DefaultFields.ChiefName],
                        line[(int)DefaultFields.ChiefPosition], line[(int)DefaultFields.ChiefGender], line[(int)DefaultFields.ChiefPhone],
                        line[(int)DefaultFields.PublicPhone], line[(int)DefaultFields.Fax], line[(int)DefaultFields.CloseFlag],
                        line[(int)DefaultFields.CloseReason], line[(int)DefaultFields.CloseDate], line[(int)DefaultFields.ReopenDate],
                        line[(int)DefaultFields.ClarificationOfWorkingHours], line[(int)DefaultFields.Specialization],
                        line[(int)DefaultFields.BeneficialDrugPrescriptions], line[(int)DefaultFields.ExtraInfo],
                        line[(int)DefaultFields.Email], line[(int)DefaultFields.GLOBALID], int.Parse(line[(int)DefaultFields.ROWNUM]));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                file.Fields.Remove(file.Fields[dataGridView2.Rows.IndexOf(row)]);
                dispensaries.Remove(dispensaries[dataGridView2.Rows.IndexOf(row)]);
                dataGridView2.Rows.Remove(row);
                file.DecLength();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = currentPath;
            saveFileDialog.Title = "Save file";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 3;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file.Save(saveFileDialog.FileName);
            }
        }

        private void SpecializationFilterButton_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.ReadOnly = true;
            filteredDisp = dispensaries.Where(d => d.Specialization == SpecializationFilterTextBox.Text).ToList();
            rawFilteredDisp = file.Fields.Where(line => line[(int)DefaultFields.Specialization] == SpecializationFilterTextBox.Text).ToList();
            for (int i = 0; i < filteredDisp.Count; i++)
            {
                dataGridView2.Rows.Add(rawFilteredDisp[i]);
            }
        }

        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.ReadOnly = false;
            for (int i = 0; i < file.Length; i++)
            {
                dataGridView2.Rows.Add(file.Fields[i]);
            }
        }

        private void ChiefPositionFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.ReadOnly = true;
            filteredDisp = dispensaries.Where(d => d.DispensaryChief.ChiefPosition == ChiefPositionFilterTextBox.Text).ToList();
            rawFilteredDisp = file.Fields.Where(line => line[(int)DefaultFields.ChiefPosition] == ChiefPositionFilterTextBox.Text).ToList();
            for (int i = 0; i < filteredDisp.Count; i++)
            {
                dataGridView2.Rows.Add(rawFilteredDisp[i]);
            }
        }

        private void SelectedRowFilter_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView2.SelectedRows;
            string specialization = dispensaries[dataGridView2.Rows.IndexOf(collection[0])].Specialization;
            dataGridView2.Rows.Clear();
            dataGridView2.ReadOnly = true;
            filteredDisp = dispensaries.Where(d => d.Specialization == specialization).ToList();
            rawFilteredDisp = file.Fields.Where(line => line[(int)DefaultFields.Specialization] == specialization).ToList();
            for (int i = 0; i < filteredDisp.Count; i++)
            {
                dataGridView2.Rows.Add(rawFilteredDisp[i]);
            }
        }
    }
}
