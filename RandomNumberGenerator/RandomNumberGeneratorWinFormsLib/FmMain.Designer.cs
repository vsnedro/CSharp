namespace RandomNumberGeneratorWinFormsLib
{
    partial class FmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Caption = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Caption.Location = new System.Drawing.Point(0, 0);
            this.lbl_Caption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Caption.Size = new System.Drawing.Size(194, 19);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "Random Number Generator";
            this.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(12, 34);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(23, 13);
            this.lbl_Min.TabIndex = 1;
            this.lbl_Min.Text = "Min";
            this.lbl_Min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(12, 60);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(27, 13);
            this.lbl_Max.TabIndex = 2;
            this.lbl_Max.Text = "Max";
            this.lbl_Max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(55, 31);
            this.txt_Min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Min.MaxLength = 6;
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(127, 21);
            this.txt_Min.TabIndex = 3;
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(55, 57);
            this.txt_Max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Max.MaxLength = 6;
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.Size = new System.Drawing.Size(127, 21);
            this.txt_Max.TabIndex = 4;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(107, 83);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 22);
            this.btn_Generate.TabIndex = 5;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(12, 111);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 6;
            this.lbl_Result.Text = "Result";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(15, 126);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(167, 21);
            this.txt_Result.TabIndex = 7;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(107, 152);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 22);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 191);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txt_Max);
            this.Controls.Add(this.txt_Min);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_Caption);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Caption;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Reset;
    }
}

