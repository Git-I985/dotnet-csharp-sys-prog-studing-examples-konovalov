
namespace sprog_1
{
    partial class Form1
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
            this.butExePath = new System.Windows.Forms.Button();
            this.butBaseDirectory = new System.Windows.Forms.Button();
            this.butNewProc = new System.Windows.Forms.Button();
            this.butAppWP = new System.Windows.Forms.Button();
            this.butBrowserAdress = new System.Windows.Forms.Button();
            this.butPause = new System.Windows.Forms.Button();
            this.butProcCount2 = new System.Windows.Forms.Button();
            this.butProcCount = new System.Windows.Forms.Button();
            this.butCloseNotepad = new System.Windows.Forms.Button();
            this.butRunNotepad2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butExePath
            // 
            this.butExePath.Location = new System.Drawing.Point(78, 12);
            this.butExePath.Name = "butExePath";
            this.butExePath.Size = new System.Drawing.Size(275, 70);
            this.butExePath.TabIndex = 0;
            this.butExePath.Text = "Полное имя файла";
            this.butExePath.UseVisualStyleBackColor = true;
            this.butExePath.Click += new System.EventHandler(this.butExePath_Click);
            // 
            // butBaseDirectory
            // 
            this.butBaseDirectory.Location = new System.Drawing.Point(78, 93);
            this.butBaseDirectory.Name = "butBaseDirectory";
            this.butBaseDirectory.Size = new System.Drawing.Size(275, 70);
            this.butBaseDirectory.TabIndex = 1;
            this.butBaseDirectory.Text = "Получение пути к папке";
            this.butBaseDirectory.UseVisualStyleBackColor = true;
            this.butBaseDirectory.Click += new System.EventHandler(this.butBaseDirectory_Click);
            // 
            // butNewProc
            // 
            this.butNewProc.Location = new System.Drawing.Point(78, 178);
            this.butNewProc.Name = "butNewProc";
            this.butNewProc.Size = new System.Drawing.Size(275, 70);
            this.butNewProc.TabIndex = 2;
            this.butNewProc.Text = "Запуск другого приложения (блокнот)";
            this.butNewProc.UseVisualStyleBackColor = true;
            this.butNewProc.Click += new System.EventHandler(this.butNewProc_Click);
            // 
            // butAppWP
            // 
            this.butAppWP.Location = new System.Drawing.Point(78, 265);
            this.butAppWP.Name = "butAppWP";
            this.butAppWP.Size = new System.Drawing.Size(275, 70);
            this.butAppWP.TabIndex = 3;
            this.butAppWP.Text = "Запуск блокнота с файлом test.txt";
            this.butAppWP.UseVisualStyleBackColor = true;
            this.butAppWP.Click += new System.EventHandler(this.butAppWP_Click);
            // 
            // butBrowserAdress
            // 
            this.butBrowserAdress.Location = new System.Drawing.Point(78, 355);
            this.butBrowserAdress.Name = "butBrowserAdress";
            this.butBrowserAdress.Size = new System.Drawing.Size(275, 70);
            this.butBrowserAdress.TabIndex = 4;
            this.butBrowserAdress.Text = "Запуск браузера с заданным адресом";
            this.butBrowserAdress.UseVisualStyleBackColor = true;
            this.butBrowserAdress.Click += new System.EventHandler(this.butBrowserAdress_Click);
            // 
            // butPause
            // 
            this.butPause.Location = new System.Drawing.Point(438, 355);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(275, 70);
            this.butPause.TabIndex = 9;
            this.butPause.Text = " Пауза в программе";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // butProcCount2
            // 
            this.butProcCount2.Location = new System.Drawing.Point(438, 265);
            this.butProcCount2.Name = "butProcCount2";
            this.butProcCount2.Size = new System.Drawing.Size(275, 70);
            this.butProcCount2.TabIndex = 8;
            this.butProcCount2.Text = "Второй способ получения процессоров в системе";
            this.butProcCount2.UseVisualStyleBackColor = true;
            this.butProcCount2.Click += new System.EventHandler(this.butProcCount2_Click);
            // 
            // butProcCount
            // 
            this.butProcCount.Location = new System.Drawing.Point(438, 178);
            this.butProcCount.Name = "butProcCount";
            this.butProcCount.Size = new System.Drawing.Size(275, 70);
            this.butProcCount.TabIndex = 7;
            this.butProcCount.Text = "Получение числа процессоров в системе";
            this.butProcCount.UseVisualStyleBackColor = true;
            this.butProcCount.Click += new System.EventHandler(this.butProcCount_Click);
            // 
            // butCloseNotepad
            // 
            this.butCloseNotepad.Location = new System.Drawing.Point(438, 93);
            this.butCloseNotepad.Name = "butCloseNotepad";
            this.butCloseNotepad.Size = new System.Drawing.Size(275, 70);
            this.butCloseNotepad.TabIndex = 6;
            this.butCloseNotepad.Text = "Закрытие всех копий программы Блокнот";
            this.butCloseNotepad.UseVisualStyleBackColor = true;
            this.butCloseNotepad.Click += new System.EventHandler(this.butCloseNotepad_Click);
            // 
            // butRunNotepad2
            // 
            this.butRunNotepad2.Location = new System.Drawing.Point(438, 12);
            this.butRunNotepad2.Name = "butRunNotepad2";
            this.butRunNotepad2.Size = new System.Drawing.Size(275, 70);
            this.butRunNotepad2.TabIndex = 5;
            this.butRunNotepad2.Text = "Запуск приложения с запретом на закрытие своего приложения ";
            this.butRunNotepad2.UseVisualStyleBackColor = true;
            this.butRunNotepad2.Click += new System.EventHandler(this.butRunNotepad2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.butProcCount2);
            this.Controls.Add(this.butProcCount);
            this.Controls.Add(this.butCloseNotepad);
            this.Controls.Add(this.butRunNotepad2);
            this.Controls.Add(this.butBrowserAdress);
            this.Controls.Add(this.butAppWP);
            this.Controls.Add(this.butNewProc);
            this.Controls.Add(this.butBaseDirectory);
            this.Controls.Add(this.butExePath);
            this.Name = "Form1";
            this.Text = "Информация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butExePath;
        private System.Windows.Forms.Button butBaseDirectory;
        private System.Windows.Forms.Button butNewProc;
        private System.Windows.Forms.Button butAppWP;
        private System.Windows.Forms.Button butBrowserAdress;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.Button butProcCount2;
        private System.Windows.Forms.Button butProcCount;
        private System.Windows.Forms.Button butCloseNotepad;
        private System.Windows.Forms.Button butRunNotepad2;
    }
}

