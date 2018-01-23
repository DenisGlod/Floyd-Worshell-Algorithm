using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
    
namespace Floyd_Worshell_Algorithm
{
    public partial class Form : System.Windows.Forms.Form
    {

        private DataTable dtWeight;
        private DataTable dtPath;
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Открытие сохраненного проекта
        /// </summary>
        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    using (FileStream fs = (FileStream)openFileDialog.OpenFile())
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        ProjectFile file = (ProjectFile)formatter.Deserialize(fs);
                        vertexName.Text = file.VertexName;
                        start.Text = file.Start;
                        end.Text = file.End;
                        dgvWeight.DataSource = file.DtWeight;
                        dgvPath.DataSource = file.DtPath;
                        dgvPath.Refresh();
                        dgvWeight.Refresh();
                        var rowCaptions = vertexName.Text.Trim().Split(' ');
                        for (int i = 0; i < rowCaptions.Length; i++)
                        {
                            dgvWeight.Rows[i].HeaderCell.Value = rowCaptions[i];
                            dgvPath.Rows[i].HeaderCell.Value = rowCaptions[i];
                            NotSortableTable(i);
                        }
                        rtbWeight.Text = file.RtbWeight;
                        rtbPath.Text = file.RtbPath;
                        tbResult.Text = file.TbResult;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка:\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение проекта
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            ProjectFile pf = new ProjectFile
            {
                VertexName = vertexName.Text,
                DtWeight = (DataTable)dgvWeight.DataSource,
                DtPath = (DataTable)dgvPath.DataSource,
                RtbWeight = rtbWeight.Text,
                RtbPath = rtbPath.Text,
                Start = start.Text,
                End = end.Text,
                TbResult = tbResult.Text
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, pf);
                }
                MessageBox.Show("Проект сохранен\r\n" + fileName, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Метод для подтверждения введенных вершин и построения таблиц
        /// </summary>
        private void Accept_Click(object sender, EventArgs e)
        {
            dgvWeight.DataSource = null;
            dgvPath.DataSource = null;
            dgvPath.Refresh();
            dgvWeight.Refresh();
            string[] vName = vertexName.Text.Trim().Split(' ');
            if (vertexName.Text.Trim().Length != 0)
            {
                dtWeight = new DataTable();
                dtPath = new DataTable();
                foreach (var name in vName)
                {
                    DataColumn column = new DataColumn
                    {
                        ColumnName = name
                    };
                    dtWeight.Columns.Add(column);
                    DataRow row = dtWeight.NewRow();
                    dtWeight.Rows.Add(row);
                    dgvWeight.DataSource = dtWeight;

                    DataColumn columnp = new DataColumn
                    {
                        ColumnName = name
                    };
                    dtPath.Columns.Add(columnp);
                    DataRow rowp = dtPath.NewRow();
                    dtPath.Rows.Add(rowp);
                    dgvPath.DataSource = dtPath;

                }
                for (int i = 0; i < vName.Length; i++)
                {
                    for (int j = 0; j < vName.Length; j++)
                    {
                        dgvPath.Rows[i].Cells[j].Value = dgvPath.Rows[j].HeaderCell.Value;
                    }
                }
                for (int i = 0; i < vName.Length; i++)
                {
                    dgvWeight.Rows[i].HeaderCell.Value = vName[i];
                    dgvPath.Rows[i].HeaderCell.Value = vName[i];
                    NotSortableTable(i);
                    dgvPath.Rows[i].Cells[i].Value = 0;
                    dgvWeight.Rows[i].Cells[i].Value = 0;
                }
            }
        }

        /// <summary>
        /// Метод для запрета сортировки
        /// </summary>
        private void NotSortableTable(int i)
        {
            dgvWeight.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPath.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /// <summary>
        /// Проверяет пустая ли ячейка в таблице
        /// </summary>
        private bool IsEmpty(int length)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (dgvWeight.Rows[i].Cells[j].Value.ToString().Equals("")) return true;
            return false;
        }

        /// <summary>
        /// Слушатель для кнопки "Решить"
        /// </summary>
        private void Decide_Click(object sender, EventArgs e)
        {
            if (vertexName.Text.Trim().Length == 0 || start.Text.Trim().Length == 0 || end.Text.Trim().Length == 0)
            {
                MessageBox.Show("Одно или несколько полей пусты.\r\nПожалуйста заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var length = dgvWeight.Columns.Count;
            if (IsEmpty(length))
            {
                MessageBox.Show("Одна или нескольо ячеек пусты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < length; i++)
            {
                if (int.Parse(dgvWeight.Rows[i].Cells[i].Value.ToString()) != 0)
                {
                    MessageBox.Show("По диоганали должны быть 0 (нули)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            WriteResult("Исходные данные", true);
            WriteResult("Исходные данные", false);
            for (int root = 0; root < length; root++)
            {
                for (int row = 0; row < length; row++)
                {
                    if (row == root) continue;
                    for (int cell = 0; cell < length; cell++)
                    {
                        var cellValue = dgvWeight.Rows[row].Cells[cell].Value;
                        var rowValue = dgvWeight.Rows[root].Cells[cell].Value;
                        var columnValue = dgvWeight.Rows[row].Cells[root].Value;

                        if (row == root || row == cell || cell == root || rowValue.Equals("-") || columnValue.Equals("-")) continue;

                        int tempRow = int.Parse(rowValue.ToString());
                        int tempColumn = int.Parse(columnValue.ToString());
                        int tempCell;
                        if (!cellValue.ToString().Equals("-"))
                        {
                            tempCell = int.Parse(cellValue.ToString());
                            if (tempRow + tempColumn < tempCell)
                            {
                                dgvWeight.Rows[row].Cells[cell].Value = tempRow + tempColumn;
                                dgvPath.Rows[row].Cells[cell].Value = dgvPath.Rows[root].HeaderCell.Value.ToString();
                            }
                        }
                        else
                        {
                            dgvWeight.Rows[row].Cells[cell].Value = tempRow + tempColumn;
                            dgvPath.Rows[row].Cells[cell].Value = dgvPath.Rows[row].Cells[cell].Value = dgvPath.Rows[root].HeaderCell.Value.ToString();
                        }
                    }
                }
                var temp = root + 1;
                WriteResult("Шаг " + temp, true);
                WriteResult("Шаг " + temp, false);
            }
            StringBuilder resultPath = new StringBuilder();
            resultPath.Append(start.Text + " -> ");
            FindPoint(start.Text, end.Text, resultPath);
            //resultPath.Append(end.Text);
            string weight = "";
            foreach (DataGridViewRow row in dgvWeight.Rows)
            {
                if (row.HeaderCell.Value.Equals(start.Text))
                {
                    weight = row.Cells[end.Text].Value.ToString();
                }
            }
            tbResult.AppendText("Кратчайший путь из точки " + start.Text.ToUpper() + " в точку " + end.Text.ToUpper() + " : " + resultPath.ToString() + " = " + weight);
        }

        /// <summary>
        /// Поиск кратчайшего пути в таблице dgvPath
        /// </summary>
        private void FindPoint(string row, string column, StringBuilder sb)
        {
            string tempRow = "";
            for (int i = 0; i < dgvPath.Columns.Count; i++)
            {
                if (dgvPath.Rows[i].HeaderCell.Value.Equals(row))
                {

                    tempRow = dgvPath.Rows[i].Cells[column].Value.ToString();
                    if (tempRow.Equals("0") || tempRow.Equals(row))
                    {
                        return;
                    }
                    sb.Append(tempRow + " -> ");
                    break;
                }
            }
            FindPoint(tempRow, end.Text, sb);
        }

        /// <summary>
        /// Форматирование результата и вывод в rtbWeight и rtbPath
        /// </summary>
        private void WriteResult(string text, bool flag)
        {
            var length = dgvWeight.Columns.Count;
            StringBuilder sb = new StringBuilder();
            sb.Append("++ " + text + " ++\r\n");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (flag)
                        sb.Append(String.Format("{0,-10}", dgvWeight.Rows[i].Cells[j].Value));
                    else
                        sb.Append(String.Format("{0,-10}", dgvPath.Rows[i].Cells[j].Value));
                }
                sb.Append("\r\n");
            }
            if (flag)
                rtbWeight.AppendText(sb.ToString() + "\r\n");
            else
                rtbPath.AppendText(sb.ToString() + "\r\n");
        }

        /// <summary>
        /// Очистка всех полей
        /// </summary>
        private void ClearAllAction_Click(object sender, EventArgs e)
        {
            vertexName.Clear();
            dgvWeight.DataSource = null;
            dgvPath.DataSource = null;
            dgvPath.Refresh();
            dgvWeight.Refresh();
            rtbWeight.Clear();
            rtbPath.Clear();
            start.Clear();
            end.Clear();
            tbResult.Clear();
        }

        /// <summary>
        /// Очистка таблицы 1
        /// </summary>
        private void ClearTable1Action_Click(object sender, EventArgs e)
        {
            dgvWeight.DataSource = null;
            dgvWeight.Refresh();
        }

        /// <summary>
        /// Очистка таблицы 2
        /// </summary>
        private void ClearTable2Action_Click(object sender, EventArgs e)
        {
            dgvPath.DataSource = null;
            dgvPath.Refresh();
        }

        /// <summary>
        /// Очистка решения
        /// </summary>
        private void ClearSolutionAction_Click(object sender, EventArgs e)
        {
            rtbWeight.Clear();
            rtbPath.Clear();
            tbResult.Clear();
        }

        /// <summary>
        /// Открытие окна "О программе"
        /// </summary>
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Алгоритм Флойда — Уоршелла — динамический\r\nалгоритм для нахождения кратчайших расстояний\r\nмежду всеми вершинами взвешенного\r\nориентированного графа. Разработан в 1962 году\r\nРобертом Флойдом и Стивеном Уоршеллом.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
