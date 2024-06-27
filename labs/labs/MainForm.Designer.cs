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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonOutput = new Button();
            textBoxType = new TextBox();
            textBoxHeight = new TextBox();
            textBoxLength = new TextBox();
            textBoxWidth = new TextBox();
            buttonCreateObject = new Button();
            listBoxObjects = new ListBox();
            tabPage2 = new TabPage();
            listBoxFigures = new ListBox();
            buttonDrawFigures = new Button();
            buttonCreateCircle = new Button();
            buttonCreateRectangle = new Button();
            label10 = new Label();
            label9 = new Label();
            textBoxHeightCircle = new TextBox();
            textBoxWidthCircle = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxHeightRectangle = new TextBox();
            textBoxWidthRectangle = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pictureBoxFigures = new PictureBox();
            tabPage3 = new TabPage();
            buttonCalculateDifference = new Button();
            buttonCalculateSquare = new Button();
            textBoxOutputDifference = new TextBox();
            textBoxOutputSquare = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBoxXDifference = new TextBox();
            textBoxYDifference = new TextBox();
            textBoxXSquare = new TextBox();
            textBoxYSquare = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigures).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(656, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonOutput);
            tabPage1.Controls.Add(textBoxType);
            tabPage1.Controls.Add(textBoxHeight);
            tabPage1.Controls.Add(textBoxLength);
            tabPage1.Controls.Add(textBoxWidth);
            tabPage1.Controls.Add(buttonCreateObject);
            tabPage1.Controls.Add(listBoxObjects);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(648, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задние 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 101);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "Тип:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Ширина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Высота:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Длина:";
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(369, 287);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(271, 23);
            buttonOutput.TabIndex = 6;
            buttonOutput.Text = "Вывести объект";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(69, 93);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(294, 23);
            textBoxType.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(69, 64);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(294, 23);
            textBoxHeight.TabIndex = 4;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(69, 35);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(294, 23);
            textBoxLength.TabIndex = 3;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(69, 6);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(294, 23);
            textBoxWidth.TabIndex = 2;
            // 
            // buttonCreateObject
            // 
            buttonCreateObject.Location = new Point(8, 287);
            buttonCreateObject.Name = "buttonCreateObject";
            buttonCreateObject.Size = new Size(355, 23);
            buttonCreateObject.TabIndex = 1;
            buttonCreateObject.Text = "Создать объект";
            buttonCreateObject.UseVisualStyleBackColor = true;
            buttonCreateObject.Click += buttonCreateObject_Click;
            // 
            // listBoxObjects
            // 
            listBoxObjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 15;
            listBoxObjects.Location = new Point(369, 6);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(273, 274);
            listBoxObjects.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxFigures);
            tabPage2.Controls.Add(buttonDrawFigures);
            tabPage2.Controls.Add(buttonCreateCircle);
            tabPage2.Controls.Add(buttonCreateRectangle);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBoxHeightCircle);
            tabPage2.Controls.Add(textBoxWidthCircle);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxHeightRectangle);
            tabPage2.Controls.Add(textBoxWidthRectangle);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(pictureBoxFigures);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(648, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxFigures
            // 
            listBoxFigures.FormattingEnabled = true;
            listBoxFigures.ItemHeight = 15;
            listBoxFigures.Location = new Point(8, 152);
            listBoxFigures.Name = "listBoxFigures";
            listBoxFigures.Size = new Size(376, 139);
            listBoxFigures.TabIndex = 14;
            // 
            // buttonDrawFigures
            // 
            buttonDrawFigures.Location = new Point(8, 294);
            buttonDrawFigures.Name = "buttonDrawFigures";
            buttonDrawFigures.Size = new Size(376, 23);
            buttonDrawFigures.TabIndex = 13;
            buttonDrawFigures.Text = "Отрисовать";
            buttonDrawFigures.UseVisualStyleBackColor = true;
            buttonDrawFigures.Click += buttonDrawFigures_Click;
            // 
            // buttonCreateCircle
            // 
            buttonCreateCircle.Location = new Point(215, 123);
            buttonCreateCircle.Name = "buttonCreateCircle";
            buttonCreateCircle.Size = new Size(169, 23);
            buttonCreateCircle.TabIndex = 12;
            buttonCreateCircle.Text = "Создать объект";
            buttonCreateCircle.UseVisualStyleBackColor = true;
            buttonCreateCircle.Click += buttonCreateCircle_Click;
            // 
            // buttonCreateRectangle
            // 
            buttonCreateRectangle.Location = new Point(6, 123);
            buttonCreateRectangle.Name = "buttonCreateRectangle";
            buttonCreateRectangle.Size = new Size(156, 23);
            buttonCreateRectangle.TabIndex = 11;
            buttonCreateRectangle.Text = "Создать объект";
            buttonCreateRectangle.UseVisualStyleBackColor = true;
            buttonCreateRectangle.Click += buttonCreateRectangle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(271, 13);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 10;
            label10.Text = "Закрашенный круг";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 13);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 9;
            label9.Text = "Прямоугольник";
            // 
            // textBoxHeightCircle
            // 
            textBoxHeightCircle.Location = new Point(271, 79);
            textBoxHeightCircle.Name = "textBoxHeightCircle";
            textBoxHeightCircle.Size = new Size(113, 23);
            textBoxHeightCircle.TabIndex = 8;
            // 
            // textBoxWidthCircle
            // 
            textBoxWidthCircle.Location = new Point(271, 41);
            textBoxWidthCircle.Name = "textBoxWidthCircle";
            textBoxWidthCircle.Size = new Size(113, 23);
            textBoxWidthCircle.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 87);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Высота:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(215, 49);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 5;
            label8.Text = "Ширина:";
            // 
            // textBoxHeightRectangle
            // 
            textBoxHeightRectangle.Location = new Point(62, 79);
            textBoxHeightRectangle.Name = "textBoxHeightRectangle";
            textBoxHeightRectangle.Size = new Size(100, 23);
            textBoxHeightRectangle.TabIndex = 4;
            // 
            // textBoxWidthRectangle
            // 
            textBoxWidthRectangle.Location = new Point(62, 41);
            textBoxWidthRectangle.Name = "textBoxWidthRectangle";
            textBoxWidthRectangle.Size = new Size(100, 23);
            textBoxWidthRectangle.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 87);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Высота:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 49);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 1;
            label5.Text = "Ширина:";
            // 
            // pictureBoxFigures
            // 
            pictureBoxFigures.Location = new Point(390, 3);
            pictureBoxFigures.Name = "pictureBoxFigures";
            pictureBoxFigures.Size = new Size(255, 314);
            pictureBoxFigures.TabIndex = 0;
            pictureBoxFigures.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textBoxYSquare);
            tabPage3.Controls.Add(textBoxXSquare);
            tabPage3.Controls.Add(textBoxYDifference);
            tabPage3.Controls.Add(textBoxXDifference);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(textBoxOutputSquare);
            tabPage3.Controls.Add(textBoxOutputDifference);
            tabPage3.Controls.Add(buttonCalculateSquare);
            tabPage3.Controls.Add(buttonCalculateDifference);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(648, 325);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateDifference
            // 
            buttonCalculateDifference.Location = new Point(44, 91);
            buttonCalculateDifference.Name = "buttonCalculateDifference";
            buttonCalculateDifference.Size = new Size(100, 23);
            buttonCalculateDifference.TabIndex = 0;
            buttonCalculateDifference.Text = "Рассчитать";
            buttonCalculateDifference.UseVisualStyleBackColor = true;
            buttonCalculateDifference.Click += buttonCalculateDifference_Click;
            // 
            // buttonCalculateSquare
            // 
            buttonCalculateSquare.Location = new Point(235, 91);
            buttonCalculateSquare.Name = "buttonCalculateSquare";
            buttonCalculateSquare.Size = new Size(100, 23);
            buttonCalculateSquare.TabIndex = 1;
            buttonCalculateSquare.Text = "Рассчитать";
            buttonCalculateSquare.UseVisualStyleBackColor = true;
            buttonCalculateSquare.Click += buttonCalculateSquare_Click;
            // 
            // textBoxOutputDifference
            // 
            textBoxOutputDifference.Location = new Point(44, 120);
            textBoxOutputDifference.Name = "textBoxOutputDifference";
            textBoxOutputDifference.Size = new Size(100, 23);
            textBoxOutputDifference.TabIndex = 2;
            // 
            // textBoxOutputSquare
            // 
            textBoxOutputSquare.Location = new Point(235, 120);
            textBoxOutputSquare.Name = "textBoxOutputSquare";
            textBoxOutputSquare.Size = new Size(100, 23);
            textBoxOutputSquare.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 15);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 4;
            label11.Text = "Разность";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(235, 15);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 5;
            label12.Text = "Корень";
            // 
            // textBoxXDifference
            // 
            textBoxXDifference.Location = new Point(44, 33);
            textBoxXDifference.Name = "textBoxXDifference";
            textBoxXDifference.Size = new Size(100, 23);
            textBoxXDifference.TabIndex = 6;
            // 
            // textBoxYDifference
            // 
            textBoxYDifference.Location = new Point(44, 62);
            textBoxYDifference.Name = "textBoxYDifference";
            textBoxYDifference.Size = new Size(100, 23);
            textBoxYDifference.TabIndex = 7;
            // 
            // textBoxXSquare
            // 
            textBoxXSquare.Location = new Point(235, 33);
            textBoxXSquare.Name = "textBoxXSquare";
            textBoxXSquare.Size = new Size(100, 23);
            textBoxXSquare.TabIndex = 8;
            // 
            // textBoxYSquare
            // 
            textBoxYSquare.Location = new Point(235, 62);
            textBoxYSquare.Name = "textBoxYSquare";
            textBoxYSquare.Size = new Size(100, 23);
            textBoxYSquare.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 41);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 10;
            label13.Text = "X:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 70);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 11;
            label14.Text = "Y:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(212, 70);
            label15.Name = "label15";
            label15.Size = new Size(17, 15);
            label15.TabIndex = 13;
            label15.Text = "Y:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(212, 41);
            label16.Name = "label16";
            label16.Size = new Size(17, 15);
            label16.TabIndex = 12;
            label16.Text = "X:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 353);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigures).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button buttonCreateObject;
        private ListBox listBoxObjects;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonOutput;
        private TextBox textBoxType;
        private TextBox textBoxHeight;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private Button buttonCreateCircle;
        private Button buttonCreateRectangle;
        private Label label10;
        private Label label9;
        private TextBox textBoxHeightCircle;
        private TextBox textBoxWidthCircle;
        private Label label7;
        private Label label8;
        private TextBox textBoxHeightRectangle;
        private TextBox textBoxWidthRectangle;
        private Label label6;
        private Label label5;
        private PictureBox pictureBoxFigures;
        private Button buttonDrawFigures;
        private ListBox listBoxFigures;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label13;
        private TextBox textBoxYSquare;
        private TextBox textBoxXSquare;
        private TextBox textBoxYDifference;
        private TextBox textBoxXDifference;
        private Label label12;
        private Label label11;
        private TextBox textBoxOutputSquare;
        private TextBox textBoxOutputDifference;
        private Button buttonCalculateSquare;
        private Button buttonCalculateDifference;
    }
}