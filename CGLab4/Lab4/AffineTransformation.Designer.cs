namespace CGLab6
{
    partial class AffineTransformation
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
            this.drawWind = new System.Windows.Forms.PictureBox();
            this.xPoint = new System.Windows.Forms.NumericUpDown();
            this.yPoint = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawPolygonButton = new System.Windows.Forms.Button();
            this.pointsList = new System.Windows.Forms.ListBox();
            this.edgesList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.affineDialogButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // drawWind
            // 
            this.drawWind.Location = new System.Drawing.Point(203, 43);
            this.drawWind.Name = "drawWind";
            this.drawWind.Size = new System.Drawing.Size(754, 494);
            this.drawWind.TabIndex = 0;
            this.drawWind.TabStop = false;
            this.drawWind.Paint += new System.Windows.Forms.PaintEventHandler(this.drawWind_Paint);
            this.drawWind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawWind_MouseDown);
            // 
            // xPoint
            // 
            this.xPoint.Location = new System.Drawing.Point(40, 43);
            this.xPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xPoint.Name = "xPoint";
            this.xPoint.Size = new System.Drawing.Size(54, 20);
            this.xPoint.TabIndex = 1;
            // 
            // yPoint
            // 
            this.yPoint.Location = new System.Drawing.Point(127, 43);
            this.yPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yPoint.Name = "yPoint";
            this.yPoint.Size = new System.Drawing.Size(54, 20);
            this.yPoint.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // drawPolygonButton
            // 
            this.drawPolygonButton.Location = new System.Drawing.Point(17, 203);
            this.drawPolygonButton.Name = "drawPolygonButton";
            this.drawPolygonButton.Size = new System.Drawing.Size(126, 23);
            this.drawPolygonButton.TabIndex = 13;
            this.drawPolygonButton.Text = "Построить по точкам";
            this.drawPolygonButton.UseVisualStyleBackColor = true;
            this.drawPolygonButton.Click += new System.EventHandler(this.drawPolygonButton_Click);
            // 
            // pointsList
            // 
            this.pointsList.FormattingEnabled = true;
            this.pointsList.Location = new System.Drawing.Point(17, 254);
            this.pointsList.Name = "pointsList";
            this.pointsList.Size = new System.Drawing.Size(180, 121);
            this.pointsList.TabIndex = 14;
            this.pointsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pointsList_KeyDown);
            // 
            // edgesList
            // 
            this.edgesList.FormattingEnabled = true;
            this.edgesList.Location = new System.Drawing.Point(17, 416);
            this.edgesList.Name = "edgesList";
            this.edgesList.Size = new System.Drawing.Size(180, 121);
            this.edgesList.TabIndex = 15;
            this.edgesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edgesList_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Точки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ребра";
            // 
            // affineDialogButton
            // 
            this.affineDialogButton.Location = new System.Drawing.Point(17, 174);
            this.affineDialogButton.Name = "affineDialogButton";
            this.affineDialogButton.Size = new System.Drawing.Size(126, 23);
            this.affineDialogButton.TabIndex = 18;
            this.affineDialogButton.Text = "Преобразовать";
            this.affineDialogButton.UseVisualStyleBackColor = true;
            this.affineDialogButton.Click += new System.EventHandler(this.affineDialogButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ЛКМ - добавить точку, выделить элемент списка и DEL - удалить элемент";
            // 
            // AffineTransformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.affineDialogButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edgesList);
            this.Controls.Add(this.pointsList);
            this.Controls.Add(this.drawPolygonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yPoint);
            this.Controls.Add(this.xPoint);
            this.Controls.Add(this.drawWind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AffineTransformation";
            this.Text = "AffineTransformation";
            ((System.ComponentModel.ISupportInitialize)(this.drawWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawWind;
        private System.Windows.Forms.NumericUpDown xPoint;
        private System.Windows.Forms.NumericUpDown yPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button drawPolygonButton;
        private System.Windows.Forms.ListBox pointsList;
        private System.Windows.Forms.ListBox edgesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button affineDialogButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}