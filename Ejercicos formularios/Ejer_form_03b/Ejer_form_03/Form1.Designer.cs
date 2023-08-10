namespace Ejer_form_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sName = new System.Windows.Forms.Label();
            this.sValue = new System.Windows.Forms.TrackBar();
            this.rep = new AxWMPLib.AxWindowsMediaPlayer();
            this.sList = new System.Windows.Forms.ListBox();
            this.PauseBtn = new System.Windows.Forms.PictureBox();
            this.sControllerBtn = new System.Windows.Forms.PictureBox();
            this.StopBtn = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.sStatus = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.sValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sControllerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Location = new System.Drawing.Point(12, 13);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(13, 13);
            this.sName.TabIndex = 2;
            this.sName.Text = "..";
            // 
            // sValue
            // 
            this.sValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sValue.Location = new System.Drawing.Point(386, 253);
            this.sValue.Maximum = 100;
            this.sValue.Name = "sValue";
            this.sValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sValue.Size = new System.Drawing.Size(45, 104);
            this.sValue.TabIndex = 7;
            this.sValue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // rep
            // 
            this.rep.Enabled = true;
            this.rep.Location = new System.Drawing.Point(260, 253);
            this.rep.Name = "rep";
            this.rep.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rep.OcxState")));
            this.rep.Size = new System.Drawing.Size(120, 60);
            this.rep.TabIndex = 9;
            // 
            // sList
            // 
            this.sList.FormattingEnabled = true;
            this.sList.Location = new System.Drawing.Point(260, 151);
            this.sList.Name = "sList";
            this.sList.Size = new System.Drawing.Size(120, 95);
            this.sList.TabIndex = 10;
            this.sList.SelectedIndexChanged += new System.EventHandler(this.sList_SelectedIndexChanged);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(68, 253);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(50, 50);
            this.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseBtn.TabIndex = 8;
            this.PauseBtn.TabStop = false;
            // 
            // sControllerBtn
            // 
            this.sControllerBtn.Location = new System.Drawing.Point(345, 323);
            this.sControllerBtn.Name = "sControllerBtn";
            this.sControllerBtn.Size = new System.Drawing.Size(35, 34);
            this.sControllerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sControllerBtn.TabIndex = 6;
            this.sControllerBtn.TabStop = false;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(124, 253);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(50, 50);
            this.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBtn.TabIndex = 5;
            this.StopBtn.TabStop = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 253);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 50);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 3;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // sStatus
            // 
            this.sStatus.BackColor = System.Drawing.SystemColors.Control;
            this.sStatus.Location = new System.Drawing.Point(12, 202);
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(215, 45);
            this.sStatus.TabIndex = 11;
            this.sStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.sList);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.sValue);
            this.Controls.Add(this.sControllerBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sControllerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.PictureBox StopBtn;
        private System.Windows.Forms.PictureBox sControllerBtn;
        private System.Windows.Forms.TrackBar sValue;
        private System.Windows.Forms.PictureBox PauseBtn;
        private AxWMPLib.AxWindowsMediaPlayer rep;
        private System.Windows.Forms.ListBox sList;
        private System.Windows.Forms.TrackBar sStatus;
    }
}

