namespace CGLab6
{
    partial class AffineDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.translateY = new System.Windows.Forms.NumericUpDown();
            this.translateX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rotatePoint = new System.Windows.Forms.ComboBox();
            this.rotateAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleX = new System.Windows.Forms.NumericUpDown();
            this.scaleY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.translateY);
            this.groupBox1.Controls.Add(this.translateX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Смещение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DY";
            // 
            // translateY
            // 
            this.translateY.DecimalPlaces = 3;
            this.translateY.Location = new System.Drawing.Point(39, 79);
            this.translateY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.translateY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.translateY.Name = "translateY";
            this.translateY.Size = new System.Drawing.Size(87, 20);
            this.translateY.TabIndex = 1;
            // 
            // translateX
            // 
            this.translateX.DecimalPlaces = 3;
            this.translateX.Location = new System.Drawing.Point(39, 41);
            this.translateX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.translateX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.translateX.Name = "translateX";
            this.translateX.Size = new System.Drawing.Size(87, 20);
            this.translateX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rotatePoint);
            this.groupBox2.Controls.Add(this.rotateAngle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(181, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот";
            // 
            // rotatePoint
            // 
            this.rotatePoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotatePoint.FormattingEnabled = true;
            this.rotatePoint.Location = new System.Drawing.Point(16, 78);
            this.rotatePoint.Name = "rotatePoint";
            this.rotatePoint.Size = new System.Drawing.Size(121, 21);
            this.rotatePoint.TabIndex = 3;
            // 
            // rotateAngle
            // 
            this.rotateAngle.DecimalPlaces = 3;
            this.rotateAngle.Location = new System.Drawing.Point(51, 41);
            this.rotateAngle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotateAngle.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(87, 20);
            this.rotateAngle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Угол";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.scaleX);
            this.groupBox3.Controls.Add(this.scaleY);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(343, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 137);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "По оси X";
            // 
            // scaleX
            // 
            this.scaleX.DecimalPlaces = 3;
            this.scaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleX.Location = new System.Drawing.Point(14, 94);
            this.scaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.scaleX.Name = "scaleX";
            this.scaleX.Size = new System.Drawing.Size(87, 20);
            this.scaleX.TabIndex = 1;
            this.scaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scaleY
            // 
            this.scaleY.DecimalPlaces = 3;
            this.scaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleY.Location = new System.Drawing.Point(14, 43);
            this.scaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.scaleY.Name = "scaleY";
            this.scaleY.Size = new System.Drawing.Size(87, 20);
            this.scaleY.TabIndex = 0;
            this.scaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "По оси Y";
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Location = new System.Drawing.Point(331, 195);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(412, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AffineDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 230);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AffineDialog";
            this.Text = "AffineDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.ComboBox rotatePoint;
        public System.Windows.Forms.NumericUpDown scaleX;
        public System.Windows.Forms.NumericUpDown scaleY;
        public System.Windows.Forms.NumericUpDown translateY;
        public System.Windows.Forms.NumericUpDown translateX;
        public System.Windows.Forms.NumericUpDown rotateAngle;
    }
}