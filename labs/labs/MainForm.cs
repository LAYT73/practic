namespace labs;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxProductionIncrease.Text, out int productionIncrease) &&
        int.TryParse(textBoxDemandDecrease.Text, out int demandDecrease))
        {
            ProductionDemandCalculator calculator = new ProductionDemandCalculator();
            List<ProductionDemandYearData> traceData = calculator.Calculate(100, 150000, productionIncrease, demandDecrease);

            // Очистим dataGridViewTrace перед добавлением новых данных
            dataGridView.Rows.Clear();

            // Добавляем данные в dataGridViewTrace
            foreach (var data in traceData)
            {
                dataGridView.Rows.Add(data.Id, data.Year, data.Production, data.Demand);
            }
        }
        else
        {
            MessageBox.Show("Please enter valid integer values for Production Increase and Demand Decrease.");
        }
    }
}
