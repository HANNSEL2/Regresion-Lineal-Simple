namespace WindowsFormsApp3
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxXY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxYcuadrado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxXcuadrado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSumaY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSumaX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCovarianza = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVarianzaY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVarianzaX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDesviacionY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDesviacionX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMediaY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMediaX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVx = new System.Windows.Forms.TextBox();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_cuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Cuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MulXY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxXY
            // 
            this.textBoxXY.Location = new System.Drawing.Point(161, 345);
            this.textBoxXY.Name = "textBoxXY";
            this.textBoxXY.Size = new System.Drawing.Size(90, 22);
            this.textBoxXY.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 76;
            this.label17.Text = "Sumatoria \"XY\"";
            // 
            // textBoxYcuadrado
            // 
            this.textBoxYcuadrado.Location = new System.Drawing.Point(367, 311);
            this.textBoxYcuadrado.Name = "textBoxYcuadrado";
            this.textBoxYcuadrado.Size = new System.Drawing.Size(90, 22);
            this.textBoxYcuadrado.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 74;
            this.label15.Text = "Sumatoria \"Y²\"";
            // 
            // textBoxXcuadrado
            // 
            this.textBoxXcuadrado.Location = new System.Drawing.Point(149, 311);
            this.textBoxXcuadrado.Name = "textBoxXcuadrado";
            this.textBoxXcuadrado.Size = new System.Drawing.Size(89, 22);
            this.textBoxXcuadrado.TabIndex = 73;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 72;
            this.label16.Text = "Sumatoria \"X²\"";
            // 
            // textBoxSumaY
            // 
            this.textBoxSumaY.Location = new System.Drawing.Point(367, 277);
            this.textBoxSumaY.Name = "textBoxSumaY";
            this.textBoxSumaY.Size = new System.Drawing.Size(90, 22);
            this.textBoxSumaY.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Sumatoria \"Y\"";
            // 
            // textBoxSumaX
            // 
            this.textBoxSumaX.Location = new System.Drawing.Point(149, 277);
            this.textBoxSumaX.Name = "textBoxSumaX";
            this.textBoxSumaX.Size = new System.Drawing.Size(89, 22);
            this.textBoxSumaX.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 68;
            this.label14.Text = "Sumatoria \"X\"";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(772, 75);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(491, 300);
            this.chart1.TabIndex = 67;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 50);
            this.button2.TabIndex = 66;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCovarianza
            // 
            this.textBoxCovarianza.Location = new System.Drawing.Point(165, 479);
            this.textBoxCovarianza.Name = "textBoxCovarianza";
            this.textBoxCovarianza.Size = new System.Drawing.Size(82, 22);
            this.textBoxCovarianza.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "Covarianza";
            // 
            // textBoxVarianzaY
            // 
            this.textBoxVarianzaY.Location = new System.Drawing.Point(374, 448);
            this.textBoxVarianzaY.Name = "textBoxVarianzaY";
            this.textBoxVarianzaY.Size = new System.Drawing.Size(92, 22);
            this.textBoxVarianzaY.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Varianza \"Y\"";
            // 
            // textBoxVarianzaX
            // 
            this.textBoxVarianzaX.Location = new System.Drawing.Point(165, 448);
            this.textBoxVarianzaX.Name = "textBoxVarianzaX";
            this.textBoxVarianzaX.Size = new System.Drawing.Size(82, 22);
            this.textBoxVarianzaX.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Varianza \"X\"";
            // 
            // textBoxDesviacionY
            // 
            this.textBoxDesviacionY.Location = new System.Drawing.Point(374, 416);
            this.textBoxDesviacionY.Name = "textBoxDesviacionY";
            this.textBoxDesviacionY.Size = new System.Drawing.Size(92, 22);
            this.textBoxDesviacionY.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Desviación \"Y\"";
            // 
            // textBoxDesviacionX
            // 
            this.textBoxDesviacionX.Location = new System.Drawing.Point(165, 416);
            this.textBoxDesviacionX.Name = "textBoxDesviacionX";
            this.textBoxDesviacionX.Size = new System.Drawing.Size(82, 22);
            this.textBoxDesviacionX.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Desviación \"X\"";
            // 
            // textBoxMediaY
            // 
            this.textBoxMediaY.Location = new System.Drawing.Point(339, 388);
            this.textBoxMediaY.Name = "textBoxMediaY";
            this.textBoxMediaY.Size = new System.Drawing.Size(127, 22);
            this.textBoxMediaY.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Media \"Y\"";
            // 
            // textBoxMediaX
            // 
            this.textBoxMediaX.Location = new System.Drawing.Point(131, 388);
            this.textBoxMediaX.Name = "textBoxMediaX";
            this.textBoxMediaX.Size = new System.Drawing.Size(116, 22);
            this.textBoxMediaX.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Media \"X\"";
            // 
            // textBoxVy
            // 
            this.textBoxVy.Location = new System.Drawing.Point(124, 75);
            this.textBoxVy.Name = "textBoxVy";
            this.textBoxVy.Size = new System.Drawing.Size(205, 22);
            this.textBoxVy.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Variable Y";
            // 
            // textBoxVx
            // 
            this.textBoxVx.Location = new System.Drawing.Point(124, 47);
            this.textBoxVx.Name = "textBoxVx";
            this.textBoxVx.Size = new System.Drawing.Size(205, 22);
            this.textBoxVx.TabIndex = 44;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(181, 20);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(57, 22);
            this.textBoxCant.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Variable X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cantidad de Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.x_cuadrado,
            this.Y_Cuadrado,
            this.MulXY});
            this.dataGridView1.Location = new System.Drawing.Point(52, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 127);
            this.dataGridView1.TabIndex = 40;
            // 
            // X
            // 
            this.X.HeaderText = "Xi";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Yi";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // x_cuadrado
            // 
            this.x_cuadrado.HeaderText = "X²";
            this.x_cuadrado.MinimumWidth = 6;
            this.x_cuadrado.Name = "x_cuadrado";
            this.x_cuadrado.Width = 125;
            // 
            // Y_Cuadrado
            // 
            this.Y_Cuadrado.HeaderText = "Y²";
            this.Y_Cuadrado.MinimumWidth = 6;
            this.Y_Cuadrado.Name = "Y_Cuadrado";
            this.Y_Cuadrado.Width = 125;
            // 
            // MulXY
            // 
            this.MulXY.HeaderText = "X*Y";
            this.MulXY.MinimumWidth = 6;
            this.MulXY.Name = "MulXY";
            this.MulXY.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1317, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 567);
            this.Controls.Add(this.textBoxXY);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxYcuadrado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxXcuadrado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxSumaY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSumaX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCovarianza);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxVarianzaY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxVarianzaX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDesviacionY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDesviacionX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMediaY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMediaX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVx);
            this.Controls.Add(this.textBoxCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Covarianza";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxXY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxYcuadrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxXcuadrado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxSumaY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSumaX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCovarianza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVarianzaY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVarianzaX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDesviacionY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDesviacionX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMediaY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMediaX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVx;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_cuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Cuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MulXY;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}