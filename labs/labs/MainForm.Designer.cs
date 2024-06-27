namespace labs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Production = new DataGridViewTextBoxColumn();
            Demand = new DataGridViewTextBoxColumn();
            textBoxProductionIncrease = new TextBox();
            textBoxDemandDecrease = new TextBox();
            buttonCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Year, Production, Demand });
            dataGridView.Dock = DockStyle.Left;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(360, 450);
            dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.Name = "Year";
            Year.Width = 50;
            // 
            // Production
            // 
            Production.HeaderText = "Production";
            Production.Name = "Production";
            // 
            // Demand
            // 
            Demand.HeaderText = "Demand";
            Demand.Name = "Demand";
            // 
            // textBoxProductionIncrease
            // 
            textBoxProductionIncrease.Location = new Point(518, 12);
            textBoxProductionIncrease.Name = "textBoxProductionIncrease";
            textBoxProductionIncrease.Size = new Size(100, 23);
            textBoxProductionIncrease.TabIndex = 1;
            // 
            // textBoxDemandDecrease
            // 
            textBoxDemandDecrease.Location = new Point(518, 41);
            textBoxDemandDecrease.Name = "textBoxDemandDecrease";
            textBoxDemandDecrease.Size = new Size(100, 23);
            textBoxDemandDecrease.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(518, 70);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 20);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 4;
            label1.Text = "Увеличение производства:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 49);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 5;
            label2.Text = "Уменьшение спроса:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxDemandDecrease);
            Controls.Add(textBoxProductionIncrease);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox textBoxProductionIncrease;
        private TextBox textBoxDemandDecrease;
        private Button buttonCalculate;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Production;
        private DataGridViewTextBoxColumn Demand;
    }
}