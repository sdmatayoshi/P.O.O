
namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_color
            // 
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.BorderSize = 0;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_color.Image = ((System.Drawing.Image)(resources.GetObject("btn_color.Image")));
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(228, 12);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(76, 76);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_color.Location = new System.Drawing.Point(193, 31);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(29, 28);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 379);
            this.panel3.TabIndex = 2;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(937, 379);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(310, 12);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(76, 76);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.BorderSize = 0;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.Location = new System.Drawing.Point(392, 12);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(76, 76);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.BorderSize = 0;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(474, 12);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(76, 76);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.BorderSize = 0;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_ellipse.Image")));
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(556, 12);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(76, 76);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.BorderSize = 0;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_rect.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.Image")));
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(638, 12);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(76, 76);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.BorderSize = 0;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(720, 12);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(76, 76);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(802, 50);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 27);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_clear_MouseClick);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(802, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 27);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = ((System.Drawing.Image)(resources.GetObject("color_picker.Image")));
            this.color_picker.Location = new System.Drawing.Point(3, 21);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(184, 67);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox color_picker;
    }
}

