namespace app.Utils
{
    public class DataGridViewUtils
    {
       public static DataGridViewTextBoxColumn CreateTextBoxColumn(
       string dataPropertyName,
       string headerText = null,
       string name = null,
       DataGridViewAutoSizeColumnMode autoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
       DataGridViewContentAlignment dataGridViewContentAlignment = DataGridViewContentAlignment.MiddleCenter,
       float fillWeight = 100,
       bool readOnly = true)
        {
            string actualHeaderText = headerText ?? dataPropertyName;
            string actualName = name ?? dataPropertyName;

            var column = new DataGridViewTextBoxColumn
            {
                Name = actualName,
                HeaderText = actualHeaderText,
                DataPropertyName = dataPropertyName,
                AutoSizeMode = autoSizeMode,
                ReadOnly = readOnly,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = dataGridViewContentAlignment
                }
            };

            if (autoSizeMode == DataGridViewAutoSizeColumnMode.Fill)
            {
                column.FillWeight = fillWeight;
            }

            return column;
        }
    }
}
