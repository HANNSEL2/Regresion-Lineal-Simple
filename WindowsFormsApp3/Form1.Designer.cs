namespace WindowsFormsApp3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.textBoxVx = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_cuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Cuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MulXY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxVy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMediaX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMediaY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVxx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxSumaY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSumaX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxYcuadrado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxXcuadrado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxXY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPendiente = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(97, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Variable X";
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(226, 24);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(57, 22);
            this.textBoxCant.TabIndex = 3;
            // 
            // textBoxVx
            // 
            this.textBoxVx.Location = new System.Drawing.Point(169, 51);
            this.textBoxVx.Name = "textBoxVx";
            this.textBoxVx.Size = new System.Drawing.Size(205, 22);
            this.textBoxVx.TabIndex = 4;
            this.textBoxVx.TextChanged += new System.EventHandler(this.textBoxVx_TextChanged);
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
            // textBoxVy
            // 
            this.textBoxVy.Location = new System.Drawing.Point(169, 79);
            this.textBoxVy.Name = "textBoxVy";
            this.textBoxVy.Size = new System.Drawing.Size(205, 22);
            this.textBoxVy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Variable Y";
            // 
            // textBoxMediaX
            // 
            this.textBoxMediaX.Location = new System.Drawing.Point(176, 392);
            this.textBoxMediaX.Name = "textBoxMediaX";
            this.textBoxMediaX.Size = new System.Drawing.Size(116, 22);
            this.textBoxMediaX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Media \"X\"";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxMediaY
            // 
            this.textBoxMediaY.Location = new System.Drawing.Point(384, 392);
            this.textBoxMediaY.Name = "textBoxMediaY";
            this.textBoxMediaY.Size = new System.Drawing.Size(127, 22);
            this.textBoxMediaY.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Media \"Y\"";
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(623, 299);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(92, 22);
            this.textBoxb.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "b";
            // 
            // textBoxVxx
            // 
            this.textBoxVxx.Location = new System.Drawing.Point(623, 330);
            this.textBoxVxx.Name = "textBoxVxx";
            this.textBoxVxx.Size = new System.Drawing.Size(92, 22);
            this.textBoxVxx.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(817, 79);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(491, 300);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // textBoxSumaY
            // 
            this.textBoxSumaY.Location = new System.Drawing.Point(412, 281);
            this.textBoxSumaY.Name = "textBoxSumaY";
            this.textBoxSumaY.Size = new System.Drawing.Size(90, 22);
            this.textBoxSumaY.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Sumatoria \"Y\"";
            // 
            // textBoxSumaX
            // 
            this.textBoxSumaX.Location = new System.Drawing.Point(194, 281);
            this.textBoxSumaX.Name = "textBoxSumaX";
            this.textBoxSumaX.Size = new System.Drawing.Size(89, 22);
            this.textBoxSumaX.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Sumatoria \"X\"";
            // 
            // textBoxYcuadrado
            // 
            this.textBoxYcuadrado.Location = new System.Drawing.Point(412, 315);
            this.textBoxYcuadrado.Name = "textBoxYcuadrado";
            this.textBoxYcuadrado.Size = new System.Drawing.Size(90, 22);
            this.textBoxYcuadrado.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sumatoria \"Y²\"";
            // 
            // textBoxXcuadrado
            // 
            this.textBoxXcuadrado.Location = new System.Drawing.Point(194, 315);
            this.textBoxXcuadrado.Name = "textBoxXcuadrado";
            this.textBoxXcuadrado.Size = new System.Drawing.Size(89, 22);
            this.textBoxXcuadrado.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Sumatoria \"X²\"";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBoxXY
            // 
            this.textBoxXY.Location = new System.Drawing.Point(206, 349);
            this.textBoxXY.Name = "textBoxXY";
            this.textBoxXY.Size = new System.Drawing.Size(90, 22);
            this.textBoxXY.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Sumatoria \"XY\"";
            // 
            // textBoxPendiente
            // 
            this.textBoxPendiente.Location = new System.Drawing.Point(623, 271);
            this.textBoxPendiente.Name = "textBoxPendiente";
            this.textBoxPendiente.Size = new System.Drawing.Size(92, 22);
            this.textBoxPendiente.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(602, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "m";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1338, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 562);
            this.Controls.Add(this.textBoxPendiente);
            this.Controls.Add(this.label18);
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
            this.Controls.Add(this.textBoxVxx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.label10);
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
            this.Name = "Form1";
            this.Text = "Minimos Cuadrados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.TextBox textBoxVx;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_cuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Cuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MulXY;
        private System.Windows.Forms.TextBox textBoxVy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMediaX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMediaY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVxx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxSumaY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSumaX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxYcuadrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxXcuadrado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxXY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPendiente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

