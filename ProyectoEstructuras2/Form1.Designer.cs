namespace ProyectoEstructuras2
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnTrazarGrafo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cblOrigen = new System.Windows.Forms.ComboBox();
            this.cblDestino = new System.Windows.Forms.ComboBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearchOutput = new System.Windows.Forms.Label();
            this.BtnVerUbicacionAdyacentes = new System.Windows.Forms.Button();
            this.BtnRutaMinima = new System.Windows.Forms.Button();
            this.BtnRutaMaxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(829, 463);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // btnTrazarGrafo
            // 
            this.btnTrazarGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTrazarGrafo.Location = new System.Drawing.Point(856, 18);
            this.btnTrazarGrafo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrazarGrafo.Name = "btnTrazarGrafo";
            this.btnTrazarGrafo.Size = new System.Drawing.Size(83, 29);
            this.btnTrazarGrafo.TabIndex = 11;
            this.btnTrazarGrafo.Text = "Ver Grafo";
            this.btnTrazarGrafo.UseVisualStyleBackColor = true;
            this.btnTrazarGrafo.Click += new System.EventHandler(this.BtnTrazarGrafo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Origen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(853, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Destino";
            // 
            // cblOrigen
            // 
            this.cblOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblOrigen.FormattingEnabled = true;
            this.cblOrigen.Location = new System.Drawing.Point(856, 104);
            this.cblOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cblOrigen.Name = "cblOrigen";
            this.cblOrigen.Size = new System.Drawing.Size(181, 21);
            this.cblOrigen.TabIndex = 15;
            this.cblOrigen.SelectedIndexChanged += new System.EventHandler(this.CblOrigen_SelectedIndexChanged);
            // 
            // cblDestino
            // 
            this.cblDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblDestino.FormattingEnabled = true;
            this.cblDestino.Location = new System.Drawing.Point(856, 160);
            this.cblDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cblDestino.Name = "cblDestino";
            this.cblDestino.Size = new System.Drawing.Size(179, 21);
            this.cblDestino.TabIndex = 16;
            this.cblDestino.SelectedIndexChanged += new System.EventHandler(this.CblDestino_SelectedIndexChanged);
            // 
            // btnIr
            // 
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnIr.Location = new System.Drawing.Point(949, 18);
            this.btnIr.Margin = new System.Windows.Forms.Padding(2);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(82, 30);
            this.btnIr.TabIndex = 17;
            this.btnIr.Text = "Limpiar";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.BtnIr_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(856, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar ubicacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblSearchOutput
            // 
            this.lblSearchOutput.AutoSize = true;
            this.lblSearchOutput.Location = new System.Drawing.Point(848, 224);
            this.lblSearchOutput.Name = "lblSearchOutput";
            this.lblSearchOutput.Size = new System.Drawing.Size(0, 13);
            this.lblSearchOutput.TabIndex = 21;
            // 
            // BtnVerUbicacionAdyacentes
            // 
            this.BtnVerUbicacionAdyacentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnVerUbicacionAdyacentes.Location = new System.Drawing.Point(856, 267);
            this.BtnVerUbicacionAdyacentes.Name = "BtnVerUbicacionAdyacentes";
            this.BtnVerUbicacionAdyacentes.Size = new System.Drawing.Size(181, 40);
            this.BtnVerUbicacionAdyacentes.TabIndex = 22;
            this.BtnVerUbicacionAdyacentes.Text = "Ver ubicaciones adyacentes";
            this.BtnVerUbicacionAdyacentes.UseVisualStyleBackColor = true;
            this.BtnVerUbicacionAdyacentes.Click += new System.EventHandler(this.BtnVerUbicacionAdyacentes_Click);
            // 
            // BtnRutaMinima
            // 
            this.BtnRutaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnRutaMinima.Location = new System.Drawing.Point(856, 326);
            this.BtnRutaMinima.Name = "BtnRutaMinima";
            this.BtnRutaMinima.Size = new System.Drawing.Size(181, 40);
            this.BtnRutaMinima.TabIndex = 23;
            this.BtnRutaMinima.Text = "Ver ruta minima";
            this.BtnRutaMinima.UseVisualStyleBackColor = true;
            // 
            // BtnRutaMaxima
            // 
            this.BtnRutaMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnRutaMaxima.Location = new System.Drawing.Point(856, 384);
            this.BtnRutaMaxima.Name = "BtnRutaMaxima";
            this.BtnRutaMaxima.Size = new System.Drawing.Size(181, 40);
            this.BtnRutaMaxima.TabIndex = 24;
            this.BtnRutaMaxima.Text = "Ver ruta maxima";
            this.BtnRutaMaxima.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 487);
            this.Controls.Add(this.BtnRutaMaxima);
            this.Controls.Add(this.BtnRutaMinima);
            this.Controls.Add(this.BtnVerUbicacionAdyacentes);
            this.Controls.Add(this.lblSearchOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.cblDestino);
            this.Controls.Add(this.cblOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTrazarGrafo);
            this.Controls.Add(this.gMapControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnTrazarGrafo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cblOrigen;
        private System.Windows.Forms.ComboBox cblDestino;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSearchOutput;
        private System.Windows.Forms.Button BtnVerUbicacionAdyacentes;
        private System.Windows.Forms.Button BtnRutaMinima;
        private System.Windows.Forms.Button BtnRutaMaxima;
    }
}

