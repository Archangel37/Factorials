namespace Factorials
{
    partial class FormFact
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxNum = new System.Windows.Forms.RichTextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_Recursion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBoxNum
            // 
            this.richTextBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxNum.Location = new System.Drawing.Point(168, 48);
            this.richTextBoxNum.Name = "richTextBoxNum";
            this.richTextBoxNum.Size = new System.Drawing.Size(537, 33);
            this.richTextBoxNum.TabIndex = 0;
            this.richTextBoxNum.Text = "";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 164);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(758, 431);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(350, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_Recursion
            // 
            this.checkBox_Recursion.AutoSize = true;
            this.checkBox_Recursion.Location = new System.Drawing.Point(168, 12);
            this.checkBox_Recursion.Name = "checkBox_Recursion";
            this.checkBox_Recursion.Size = new System.Drawing.Size(200, 17);
            this.checkBox_Recursion.TabIndex = 3;
            this.checkBox_Recursion.Text = "True Recursion  (no more than 1000)";
            this.checkBox_Recursion.UseVisualStyleBackColor = true;
            // 
            // FormFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 607);
            this.Controls.Add(this.checkBox_Recursion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.richTextBoxNum);
            this.Name = "FormFact";
            this.Text = "Factorials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNum;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_Recursion;
    }
}

