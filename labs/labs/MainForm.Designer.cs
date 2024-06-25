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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            textBoxResult = new TextBox();
            buttonPop = new Button();
            buttonAdd = new Button();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            buttonStep = new Button();
            buttonGenerateArray = new Button();
            textBoxArray = new TextBox();
            richTextBox2 = new RichTextBox();
            panel3 = new Panel();
            textBoxTarget = new TextBox();
            label1 = new Label();
            textBoxGraph = new TextBox();
            buttonSearch = new Button();
            richTextBox3 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxResult);
            panel1.Controls.Add(buttonPop);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 220);
            panel1.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(463, 61);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(261, 23);
            textBoxResult.TabIndex = 3;
            // 
            // buttonPop
            // 
            buttonPop.Location = new Point(463, 32);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(261, 23);
            buttonPop.TabIndex = 2;
            buttonPop.Text = "Удалить";
            buttonPop.UseVisualStyleBackColor = true;
            buttonPop.Click += buttonPop_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(463, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(261, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(454, 214);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonStep);
            panel2.Controls.Add(buttonGenerateArray);
            panel2.Controls.Add(textBoxArray);
            panel2.Controls.Add(richTextBox2);
            panel2.Location = new Point(12, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 220);
            panel2.TabIndex = 1;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(463, 61);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(261, 23);
            buttonStep.TabIndex = 3;
            buttonStep.Text = "Шаг вперед";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // buttonGenerateArray
            // 
            buttonGenerateArray.Location = new Point(463, 32);
            buttonGenerateArray.Name = "buttonGenerateArray";
            buttonGenerateArray.Size = new Size(261, 23);
            buttonGenerateArray.TabIndex = 2;
            buttonGenerateArray.Text = "Сгенерировать массив";
            buttonGenerateArray.UseVisualStyleBackColor = true;
            buttonGenerateArray.Click += buttonGenerateArray_Click;
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(463, 3);
            textBoxArray.Name = "textBoxArray";
            textBoxArray.Size = new Size(261, 23);
            textBoxArray.TabIndex = 1;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(454, 214);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxTarget);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxGraph);
            panel3.Controls.Add(buttonSearch);
            panel3.Controls.Add(richTextBox3);
            panel3.Location = new Point(12, 464);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 208);
            panel3.TabIndex = 2;
            // 
            // textBoxTarget
            // 
            textBoxTarget.Location = new Point(461, 58);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(78, 23);
            textBoxTarget.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 61);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Искомое значение: ";
            // 
            // textBoxGraph
            // 
            textBoxGraph.Location = new Point(338, 3);
            textBoxGraph.Name = "textBoxGraph";
            textBoxGraph.Size = new Size(386, 23);
            textBoxGraph.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(338, 32);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(386, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(3, 3);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(329, 202);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 684);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox1;
        private TextBox textBoxResult;
        private Button buttonPop;
        private Button buttonAdd;
        private Panel panel2;
        private Button buttonStep;
        private Button buttonGenerateArray;
        private TextBox textBoxArray;
        private RichTextBox richTextBox2;
        private Panel panel3;
        private TextBox textBoxGraph;
        private Button buttonSearch;
        private RichTextBox richTextBox3;
        private Label label1;
        private TextBox textBoxTarget;
    }
}