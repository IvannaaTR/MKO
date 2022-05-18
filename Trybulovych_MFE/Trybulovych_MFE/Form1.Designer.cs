
namespace Trybulovych_MFE
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txTextBox = new System.Windows.Forms.TextBox();
            this.txLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.N_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uh0_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uh1_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.fxTextBox = new System.Windows.Forms.TextBox();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.fxLabel = new System.Windows.Forms.Label();
            this.uxLabel = new System.Windows.Forms.Label();
            this.bxTextBox = new System.Windows.Forms.TextBox();
            this.bxLabel = new System.Windows.Forms.Label();
            this.sxTextBox = new System.Windows.Forms.TextBox();
            this.sxLabel = new System.Windows.Forms.Label();
            this.functionGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.allGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // txTextBox
            // 
            this.txTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTextBox.Location = new System.Drawing.Point(86, 45);
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(432, 28);
            this.txTextBox.TabIndex = 38;
            this.txTextBox.Text = "7*x";
            // 
            // txLabel
            // 
            this.txLabel.AutoSize = true;
            this.txLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLabel.Location = new System.Drawing.Point(7, 45);
            this.txLabel.Name = "txLabel";
            this.txLabel.Size = new System.Drawing.Size(70, 24);
            this.txLabel.TabIndex = 37;
            this.txLabel.Text = "T(x)  = ";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_column,
            this.Uh0_column,
            this.Uh1_column});
            this.dataGridView.Location = new System.Drawing.Point(616, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(584, 298);
            this.dataGridView.TabIndex = 36;
            // 
            // N_column
            // 
            this.N_column.HeaderText = "N";
            this.N_column.MinimumWidth = 6;
            this.N_column.Name = "N_column";
            this.N_column.ReadOnly = true;
            // 
            // Uh0_column
            // 
            this.Uh0_column.HeaderText = "||uh0||";
            this.Uh0_column.MinimumWidth = 6;
            this.Uh0_column.Name = "Uh0_column";
            this.Uh0_column.ReadOnly = true;
            // 
            // Uh1_column
            // 
            this.Uh1_column.HeaderText = "‖ uh1 ‖";
            this.Uh1_column.MinimumWidth = 6;
            this.Uh1_column.Name = "Uh1_column";
            this.Uh1_column.ReadOnly = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 218);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(119, 48);
            this.CalculateButton.TabIndex = 35;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // fxTextBox
            // 
            this.fxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fxTextBox.Location = new System.Drawing.Point(86, 162);
            this.fxTextBox.Name = "fxTextBox";
            this.fxTextBox.Size = new System.Drawing.Size(432, 28);
            this.fxTextBox.TabIndex = 34;
            this.fxTextBox.Text = "14*pi*(2*pi*x*sin(2*pi*x)-cos(2*pi*x))+x^2*(2*pi*cos(2*pi*x))+(1/(x)^2)*sin(2*pi*" +
    "x)";
            // 
            // uxTextBox
            // 
            this.uxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox.Location = new System.Drawing.Point(86, 11);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(432, 28);
            this.uxTextBox.TabIndex = 32;
            this.uxTextBox.Text = "sin(2*pi*x)";
            // 
            // fxLabel
            // 
            this.fxLabel.AutoSize = true;
            this.fxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fxLabel.Location = new System.Drawing.Point(7, 162);
            this.fxLabel.Name = "fxLabel";
            this.fxLabel.Size = new System.Drawing.Size(62, 24);
            this.fxLabel.TabIndex = 31;
            this.fxLabel.Text = "f(x)  = ";
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(7, 11);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(64, 24);
            this.uxLabel.TabIndex = 30;
            this.uxLabel.Text = "u(x) = ";
            // 
            // bxTextBox
            // 
            this.bxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxTextBox.Location = new System.Drawing.Point(86, 88);
            this.bxTextBox.Name = "bxTextBox";
            this.bxTextBox.Size = new System.Drawing.Size(432, 28);
            this.bxTextBox.TabIndex = 42;
            this.bxTextBox.Text = "x^2";
            // 
            // bxLabel
            // 
            this.bxLabel.AutoSize = true;
            this.bxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxLabel.Location = new System.Drawing.Point(7, 88);
            this.bxLabel.Name = "bxLabel";
            this.bxLabel.Size = new System.Drawing.Size(69, 24);
            this.bxLabel.TabIndex = 41;
            this.bxLabel.Text = "b(x)  = ";
            // 
            // sxTextBox
            // 
            this.sxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sxTextBox.Location = new System.Drawing.Point(86, 128);
            this.sxTextBox.Name = "sxTextBox";
            this.sxTextBox.Size = new System.Drawing.Size(432, 28);
            this.sxTextBox.TabIndex = 40;
            this.sxTextBox.Text = "1/(x^2)";
            // 
            // sxLabel
            // 
            this.sxLabel.AutoSize = true;
            this.sxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sxLabel.Location = new System.Drawing.Point(7, 128);
            this.sxLabel.Name = "sxLabel";
            this.sxLabel.Size = new System.Drawing.Size(67, 24);
            this.sxLabel.TabIndex = 39;
            this.sxLabel.Text = "s(x)  = ";
            // 
            // functionGraphics
            // 
            chartArea3.Name = "ChartArea1";
            this.functionGraphics.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.functionGraphics.Legends.Add(legend3);
            this.functionGraphics.Location = new System.Drawing.Point(11, 347);
            this.functionGraphics.Name = "functionGraphics";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.functionGraphics.Series.Add(series3);
            this.functionGraphics.Size = new System.Drawing.Size(573, 323);
            this.functionGraphics.TabIndex = 43;
            // 
            // allGraphics
            // 
            chartArea4.Name = "ChartArea1";
            this.allGraphics.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.allGraphics.Legends.Add(legend4);
            this.allGraphics.Location = new System.Drawing.Point(616, 347);
            this.allGraphics.Name = "allGraphics";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.allGraphics.Series.Add(series4);
            this.allGraphics.Size = new System.Drawing.Size(573, 323);
            this.allGraphics.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1201, 682);
            this.Controls.Add(this.allGraphics);
            this.Controls.Add(this.functionGraphics);
            this.Controls.Add(this.bxTextBox);
            this.Controls.Add(this.bxLabel);
            this.Controls.Add(this.sxTextBox);
            this.Controls.Add(this.sxLabel);
            this.Controls.Add(this.txTextBox);
            this.Controls.Add(this.txLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.fxTextBox);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.fxLabel);
            this.Controls.Add(this.uxLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGraphics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txTextBox;
        private System.Windows.Forms.Label txLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button CalculateButton;
        public System.Windows.Forms.TextBox fxTextBox;
        public System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Label fxLabel;
        private System.Windows.Forms.Label uxLabel;
        public System.Windows.Forms.TextBox bxTextBox;
        private System.Windows.Forms.Label bxLabel;
        public System.Windows.Forms.TextBox sxTextBox;
        private System.Windows.Forms.Label sxLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart functionGraphics;
        private System.Windows.Forms.DataVisualization.Charting.Chart allGraphics;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uh0_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uh1_column;
    }
}

