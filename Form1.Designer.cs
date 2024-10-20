namespace TicTacToe_GameApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkRestart = new System.Windows.Forms.Button();
            this.checkRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(868, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // checkRestart
            // 
            this.checkRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRestart.Location = new System.Drawing.Point(884, 711);
            this.checkRestart.Name = "checkRestart";
            this.checkRestart.Size = new System.Drawing.Size(184, 51);
            this.checkRestart.TabIndex = 1;
            this.checkRestart.Text = "Новая игра";
            this.checkRestart.UseVisualStyleBackColor = true;
            this.checkRestart.Click += new System.EventHandler(this.checkRestart_Click);
            // 
            // checkRules
            // 
            this.checkRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRules.Location = new System.Drawing.Point(884, 644);
            this.checkRules.Name = "checkRules";
            this.checkRules.Size = new System.Drawing.Size(184, 51);
            this.checkRules.TabIndex = 2;
            this.checkRules.Text = "Правила игры";
            this.checkRules.UseVisualStyleBackColor = true;
            this.checkRules.Click += new System.EventHandler(this.checkRules_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 795);
            this.Controls.Add(this.checkRules);
            this.Controls.Add(this.checkRestart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Крестики-Нолики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkRestart;
        private System.Windows.Forms.Button checkRules;
    }
}

