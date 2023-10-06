namespace Evaluacion_3er_Bim
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
            this.ボタン１ = new System.Windows.Forms.Button();
            this.ボタン２ = new System.Windows.Forms.Button();
            this.ボタン３ = new System.Windows.Forms.Button();
            this.ボタン４ = new System.Windows.Forms.Button();
            this.リスト１ = new System.Windows.Forms.ListBox();
            this.リスト２ = new System.Windows.Forms.ListBox();
            this.リスト３ = new System.Windows.Forms.ListBox();
            this.リスト４ = new System.Windows.Forms.ListBox();
            this.リスト５ = new System.Windows.Forms.ListBox();
            this.リスト６ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ボタン１
            // 
            this.ボタン１.Location = new System.Drawing.Point(12, 204);
            this.ボタン１.Name = "ボタン１";
            this.ボタン１.Size = new System.Drawing.Size(120, 67);
            this.ボタン１.TabIndex = 0;
            this.ボタン１.Text = "Ordenar";
            this.ボタン１.UseVisualStyleBackColor = true;
            this.ボタン１.Click += new System.EventHandler(this.ボタン１_Click);
            // 
            // ボタン２
            // 
            this.ボタン２.Location = new System.Drawing.Point(138, 204);
            this.ボタン２.Name = "ボタン２";
            this.ボタン２.Size = new System.Drawing.Size(120, 67);
            this.ボタン２.TabIndex = 1;
            this.ボタン２.Text = "Eliminar nombres con hasta 5 letras";
            this.ボタン２.UseVisualStyleBackColor = true;
            this.ボタン２.Click += new System.EventHandler(this.ボタン２_Click);
            // 
            // ボタン３
            // 
            this.ボタン３.Location = new System.Drawing.Point(138, 277);
            this.ボタン３.Name = "ボタン３";
            this.ボタン３.Size = new System.Drawing.Size(120, 67);
            this.ボタン３.TabIndex = 2;
            this.ボタン３.Text = "Intercambiar (<=5)";
            this.ボタン３.UseVisualStyleBackColor = true;
            this.ボタン３.Click += new System.EventHandler(this.ボタン３_Click);
            // 
            // ボタン４
            // 
            this.ボタン４.Location = new System.Drawing.Point(12, 277);
            this.ボタン４.Name = "ボタン４";
            this.ボタン４.Size = new System.Drawing.Size(120, 67);
            this.ボタン４.TabIndex = 3;
            this.ボタン４.Text = "Intercambiar primer y último nombre";
            this.ボタン４.UseVisualStyleBackColor = true;
            this.ボタン４.Click += new System.EventHandler(this.ボタン４_Click);
            // 
            // リスト１
            // 
            this.リスト１.FormattingEnabled = true;
            this.リスト１.Location = new System.Drawing.Point(12, 12);
            this.リスト１.Name = "リスト１";
            this.リスト１.Size = new System.Drawing.Size(120, 186);
            this.リスト１.TabIndex = 4;
            // 
            // リスト２
            // 
            this.リスト２.FormattingEnabled = true;
            this.リスト２.Location = new System.Drawing.Point(138, 12);
            this.リスト２.Name = "リスト２";
            this.リスト２.Size = new System.Drawing.Size(120, 186);
            this.リスト２.TabIndex = 5;
            // 
            // リスト３
            // 
            this.リスト３.FormattingEnabled = true;
            this.リスト３.Location = new System.Drawing.Point(316, 12);
            this.リスト３.Name = "リスト３";
            this.リスト３.Size = new System.Drawing.Size(40, 17);
            this.リスト３.TabIndex = 6;
            // 
            // リスト４
            // 
            this.リスト４.FormattingEnabled = true;
            this.リスト４.Location = new System.Drawing.Point(362, 12);
            this.リスト４.Name = "リスト４";
            this.リスト４.Size = new System.Drawing.Size(41, 17);
            this.リスト４.TabIndex = 7;
            // 
            // リスト５
            // 
            this.リスト５.FormattingEnabled = true;
            this.リスト５.Location = new System.Drawing.Point(316, 35);
            this.リスト５.Name = "リスト５";
            this.リスト５.Size = new System.Drawing.Size(40, 17);
            this.リスト５.TabIndex = 8;
            // 
            // リスト６
            // 
            this.リスト６.FormattingEnabled = true;
            this.リスト６.Location = new System.Drawing.Point(362, 35);
            this.リスト６.Name = "リスト６";
            this.リスト６.Size = new System.Drawing.Size(41, 17);
            this.リスト６.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.リスト６);
            this.Controls.Add(this.リスト５);
            this.Controls.Add(this.リスト４);
            this.Controls.Add(this.リスト３);
            this.Controls.Add(this.リスト２);
            this.Controls.Add(this.リスト１);
            this.Controls.Add(this.ボタン４);
            this.Controls.Add(this.ボタン３);
            this.Controls.Add(this.ボタン２);
            this.Controls.Add(this.ボタン１);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ボタン１;
        private System.Windows.Forms.Button ボタン２;
        private System.Windows.Forms.Button ボタン３;
        private System.Windows.Forms.Button ボタン４;
        private System.Windows.Forms.ListBox リスト１;
        private System.Windows.Forms.ListBox リスト２;
        private System.Windows.Forms.ListBox リスト４;
        private System.Windows.Forms.ListBox リスト５;
        private System.Windows.Forms.ListBox リスト６;
        private System.Windows.Forms.ListBox リスト３;
    }
}

