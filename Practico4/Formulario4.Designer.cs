namespace Practico4
{
    partial class Formulario4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.LLista = new System.Windows.Forms.Label();
            this.LBNumeros = new System.Windows.Forms.ListBox();
            this.BPar = new System.Windows.Forms.Button();
            this.BImpar = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(24, 63);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            this.LDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(24, 90);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(81, 60);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(100, 20);
            this.TDesde.TabIndex = 2;
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(81, 87);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(100, 20);
            this.THasta.TabIndex = 3;
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(53, 143);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(100, 23);
            this.BGenerar.TabIndex = 4;
            this.BGenerar.Text = "Generar Función";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // LLista
            // 
            this.LLista.AutoSize = true;
            this.LLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLista.Location = new System.Drawing.Point(145, 10);
            this.LLista.Name = "LLista";
            this.LLista.Size = new System.Drawing.Size(202, 29);
            this.LLista.TabIndex = 5;
            this.LLista.Text = "Lista de Números";
            // 
            // LBNumeros
            // 
            this.LBNumeros.FormattingEnabled = true;
            this.LBNumeros.Location = new System.Drawing.Point(206, 55);
            this.LBNumeros.MultiColumn = true;
            this.LBNumeros.Name = "LBNumeros";
            this.LBNumeros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBNumeros.Size = new System.Drawing.Size(290, 134);
            this.LBNumeros.TabIndex = 6;
            // 
            // BPar
            // 
            this.BPar.Location = new System.Drawing.Point(53, 213);
            this.BPar.Name = "BPar";
            this.BPar.Size = new System.Drawing.Size(100, 23);
            this.BPar.TabIndex = 7;
            this.BPar.Text = "Números Pares";
            this.BPar.UseVisualStyleBackColor = true;
            this.BPar.Click += new System.EventHandler(this.BPar_Click);
            // 
            // BImpar
            // 
            this.BImpar.Location = new System.Drawing.Point(53, 242);
            this.BImpar.Name = "BImpar";
            this.BImpar.Size = new System.Drawing.Size(100, 23);
            this.BImpar.TabIndex = 8;
            this.BImpar.Text = "Números Impares";
            this.BImpar.UseVisualStyleBackColor = true;
            this.BImpar.Click += new System.EventHandler(this.BImpar_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(53, 271);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(100, 23);
            this.BPrimos.TabIndex = 9;
            this.BPrimos.Text = "Números Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.LLista);
            this.panel1.Controls.Add(this.BPrimos);
            this.panel1.Controls.Add(this.LBNumeros);
            this.panel1.Controls.Add(this.BImpar);
            this.panel1.Controls.Add(this.THasta);
            this.panel1.Controls.Add(this.BPar);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.BGenerar);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.TDesde);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 348);
            this.panel1.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(206, 195);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "NúmerosGenerados";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "NúmerosPares";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelForeColor = System.Drawing.Color.Orange;
            series3.Legend = "Legend1";
            series3.Name = "NúmerosImpares";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "NúmerosPrimos";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(290, 125);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 385);
            this.Controls.Add(this.panel1);
            this.Name = "Formulario4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Label LLista;
        private System.Windows.Forms.ListBox LBNumeros;
        private System.Windows.Forms.Button BPar;
        private System.Windows.Forms.Button BImpar;
        private System.Windows.Forms.Button BPrimos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

