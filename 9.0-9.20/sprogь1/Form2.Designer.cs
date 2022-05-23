
namespace sprog_1
{
    partial class butreOS
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butProcCount = new System.Windows.Forms.Button();
            this.butWindowProcess = new System.Windows.Forms.Button();
            this.butRemoteProcess = new System.Windows.Forms.Button();
            this.botSendMail = new System.Windows.Forms.Button();
            this.butOS = new System.Windows.Forms.Button();
            this.butOS2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 548);
            this.listBox1.TabIndex = 0;
            // 
            // butProcCount
            // 
            this.butProcCount.Location = new System.Drawing.Point(372, 12);
            this.butProcCount.Name = "butProcCount";
            this.butProcCount.Size = new System.Drawing.Size(400, 58);
            this.butProcCount.TabIndex = 1;
            this.butProcCount.Text = "Получение списка всех запущенных процессов в системе";
            this.butProcCount.UseVisualStyleBackColor = true;
            this.butProcCount.Click += new System.EventHandler(this.butProcCount_Click);
            // 
            // butWindowProcess
            // 
            this.butWindowProcess.Location = new System.Drawing.Point(372, 76);
            this.butWindowProcess.Name = "butWindowProcess";
            this.butWindowProcess.Size = new System.Drawing.Size(400, 58);
            this.butWindowProcess.TabIndex = 2;
            this.butWindowProcess.Text = " Получение списка оконных процессов ";
            this.butWindowProcess.UseVisualStyleBackColor = true;
            this.butWindowProcess.Click += new System.EventHandler(this.butWindowProcess_Click);
            // 
            // butRemoteProcess
            // 
            this.butRemoteProcess.Location = new System.Drawing.Point(372, 140);
            this.butRemoteProcess.Name = "butRemoteProcess";
            this.butRemoteProcess.Size = new System.Drawing.Size(400, 58);
            this.butRemoteProcess.TabIndex = 3;
            this.butRemoteProcess.Text = "Получение списка определенных процессов ";
            this.butRemoteProcess.UseVisualStyleBackColor = true;
            this.butRemoteProcess.Click += new System.EventHandler(this.butRemoteProcess_Click);
            // 
            // botSendMail
            // 
            this.botSendMail.Location = new System.Drawing.Point(372, 204);
            this.botSendMail.Name = "botSendMail";
            this.botSendMail.Size = new System.Drawing.Size(400, 58);
            this.botSendMail.TabIndex = 4;
            this.botSendMail.Text = " Отправка письма через почтовый клиент, установленный по умолчанию";
            this.botSendMail.UseVisualStyleBackColor = true;
            this.botSendMail.Click += new System.EventHandler(this.botSendMail_Click);
            // 
            // butOS
            // 
            this.butOS.Location = new System.Drawing.Point(372, 268);
            this.butOS.Name = "butOS";
            this.butOS.Size = new System.Drawing.Size(400, 58);
            this.butOS.TabIndex = 5;
            this.butOS.Text = " Определение операционной системы пользователя ";
            this.butOS.UseVisualStyleBackColor = true;
            this.butOS.Click += new System.EventHandler(this.butOS_Click_1);
            // 
            // butOS2
            // 
            this.butOS2.Location = new System.Drawing.Point(372, 332);
            this.butOS2.Name = "butOS2";
            this.butOS2.Size = new System.Drawing.Size(400, 58);
            this.butOS2.TabIndex = 6;
            this.butOS2.Text = "Исправленная версия проверки операционной системы";
            this.butOS2.UseVisualStyleBackColor = true;
            this.butOS2.Click += new System.EventHandler(this.butOS2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Получение списка версий .NET Framework ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butreOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butOS2);
            this.Controls.Add(this.butOS);
            this.Controls.Add(this.botSendMail);
            this.Controls.Add(this.butRemoteProcess);
            this.Controls.Add(this.butWindowProcess);
            this.Controls.Add(this.butProcCount);
            this.Controls.Add(this.listBox1);
            this.Name = "butreOS";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butProcCount;
        private System.Windows.Forms.Button butWindowProcess;
        private System.Windows.Forms.Button butRemoteProcess;
        private System.Windows.Forms.Button botSendMail;
        private System.Windows.Forms.Button butOS;
        private System.Windows.Forms.Button butOS2;
        private System.Windows.Forms.Button button1;
    }
}