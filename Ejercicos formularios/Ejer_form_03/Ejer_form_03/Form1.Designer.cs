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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.PictureBox();
            this.StopBtn = new System.Windows.Forms.PictureBox();
            this.vAccess = new System.Windows.Forms.PictureBox();
            this.sName = new System.Windows.Forms.Label();
            this.sList = new System.Windows.Forms.ListBox();
            this.vController = new System.Windows.Forms.TrackBar();
            this.sStatus = new System.Windows.Forms.TrackBar();
            this.rep = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::Ejer_form_03.Properties.Resources.add;
            this.AddBtn.Location = new System.Drawing.Point(28, 177);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(51, 50);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 0;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Image = global::Ejer_form_03.Properties.Resources.play;
            this.PlayBtn.Location = new System.Drawing.Point(85, 177);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(47, 50);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Image = global::Ejer_form_03.Properties.Resources.stop;
            this.StopBtn.Location = new System.Drawing.Point(138, 177);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(54, 50);
            this.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBtn.TabIndex = 2;
            this.StopBtn.TabStop = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // vAccess
            // 
            this.vAccess.Image = global::Ejer_form_03.Properties.Resources.audio_control;
            this.vAccess.Location = new System.Drawing.Point(198, 177);
            this.vAccess.Name = "vAccess";
            this.vAccess.Size = new System.Drawing.Size(27, 50);
            this.vAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vAccess.TabIndex = 3;
            this.vAccess.TabStop = false;
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Location = new System.Drawing.Point(25, 9);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(13, 13);
            this.sName.TabIndex = 4;
            this.sName.Text = "..";
            // 
            // sList
            // 
            this.sList.FormattingEnabled = true;
            this.sList.Location = new System.Drawing.Point(28, 25);
            this.sList.Name = "sList";
            this.sList.Size = new System.Drawing.Size(248, 95);
            this.sList.TabIndex = 6;
            // 
            // vController
            // 
            this.vController.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vController.Cursor = System.Windows.Forms.Cursors.Default;
            this.vController.Location = new System.Drawing.Point(231, 126);
            this.vController.Maximum = 100;
            this.vController.Name = "vController";
            this.vController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vController.Size = new System.Drawing.Size(45, 104);
            this.vController.TabIndex = 7;
            this.vController.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // sStatus
            // 
            this.sStatus.Location = new System.Drawing.Point(28, 126);
            this.sStatus.Maximum = 100;
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(197, 45);
            this.sStatus.TabIndex = 8;
            this.sStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // rep
            // 
            this.rep.Enabled = true;
            this.rep.Location = new System.Drawing.Point(28, 233);
            this.rep.Name = "rep";
            this.rep.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rep.OcxState")));
            this.rep.Size = new System.Drawing.Size(248, 69);
            this.rep.TabIndex = 5;
            this.rep.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.rep_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 313);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.vController);
            this.Controls.Add(this.sList);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.vAccess);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.PictureBox PlayBtn;
        private System.Windows.Forms.PictureBox StopBtn;
        private System.Windows.Forms.PictureBox vAccess;
        private System.Windows.Forms.Label sName;
        private AxWMPLib.AxWindowsMediaPlayer rep;
        private System.Windows.Forms.ListBox sList;
        private System.Windows.Forms.TrackBar vController;
        private System.Windows.Forms.TrackBar sStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

