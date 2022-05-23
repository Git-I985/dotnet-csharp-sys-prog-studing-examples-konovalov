using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;





namespace sprog_1

{


    public partial class butreOS : Form
    {
        public butreOS()
        {
            InitializeComponent();
        }




        private void butProcCount_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(p.ToString());
        }

        private void butWindowProcess_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in
            Process.GetProcesses(System.Environment.MachineName))
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    // Оконные приложения
                    listBox1.Items.Add(p.ToString());
                }
            }
        }

        private void butRemoteProcess_Click(object sender, EventArgs e)
        {
            // Очистим список
            listBox1.Items.Clear();
            // Получим список процессов notepad на удаленной машине skynet
            foreach (Process p in Process.GetProcessesByName("notepad",
            "skynet"))
                listBox1.Items.Add(p.ToString());



        }

        private void botSendMail_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "mailto:email@address1.com,email@address2.com?subject=Hello & cc = email@address3.com & bcc = email@address4.com & body = Happy New Year";
            process.Start();
        }

       

        private void butOS_Click_1(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;
            listBox1.Items.Add(os.Version);
            listBox1.Items.Add(os.Platform);
            listBox1.Items.Add(os.ServicePack);
            listBox1.Items.Add(os.VersionString);
        }

        private void CheckOSVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;
            if ((version.Major == 5) && (version.Minor == 1)  || version.Major >= 6)
                
            {
                MessageBox.Show("Программа может запускаться" + " в вашей операционной системе");
            }
            else
            {
                MessageBox.Show
                ("Эта версия операционной системы не поддерживается." + "\r\n Используйте Windows XP или Windows Vista");
            }
        }

        private void butOS2_Click(object sender, EventArgs e)
        {
            CheckOSVersion();
        }

       /* const string Netfx11RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v1.1.4322";
        const string Netfx20RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v2.0.50727";
        const string Netfx11PlusRegValueName = "Install";
        const string Netfx11PlusSPxRegValueName = "SP";
        const string Netfx20PlusBuildRegValueName = "Increment";

        public enum FrameworkVersion
        {
            // .NET Framework 1.0
            Fx10,
            // .NET Framework 1.1
            Fx11,
            // .NET Framework 2.0
            Fx20,
            // .NET Framework 3.0
            Fx30,
            // .NET Framework 3.5 (Orcas)
            Fx35,
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool fx11Installed = IsInstalled(FrameworkVersion.Fx11);
            bool fx20Installed = IsInstalled(FrameworkVersion.Fx20);
            listBox1.Items.Add(String.Format(".NET Framework 1.1 installed? {0}",
            fx11Installed));
            if (fx11Installed)
            {
                listBox1.Items.Add(String.Format(
                ".NET Framework 1.1 Exact Version: {0}",
                GetExactVersion(FrameworkVersion.Fx11)));
                listBox1.Items.Add(String.Format(
                ".NET Framework 1.1 Service Pack: {0}",
                GetServicePackLevel(FrameworkVersion.Fx11)));
            }
            listBox1.Items.Add(String.Format(
            ".NET Framework 2.0 installed? {0}", fx20Installed));
            if (fx20Installed)
            {
                listBox1.Items.Add(String.Format(
                ".NET Framework 2.0 Exact Version: {0}",
                GetExactVersion(FrameworkVersion.Fx20)));
                listBox1.Items.Add(String.Format(
                ".NET Framework 2.0 Service Pack: {0}",
                GetServicePackLevel(FrameworkVersion.Fx20)));
            }
        }
        public static bool IsInstalled(FrameworkVersion frameworkVersion)
        {
            bool ret = false;
          
        switch (frameworkVersion)
            {
                case FrameworkVersion.Fx11:
                    ret = IsNetfx11Installed();
                    break;
                case FrameworkVersion.Fx20:
                    ret = IsNetfx20Installed();
                    break;
                default:
                    break;
            }
            return ret;
        }
        private static bool IsNetfx11Installed()
        {
            bool found = false;
            int regValue = 0;
            if (GetRegistryValue(RegistryHive.LocalMachine,
            Netfx11RegKeyName, Netfx11PlusRegValueName,
            RegistryValueKind.DWord, out regValue))
            {
                if (regValue == 1)
                {
                    found = true;
                }
            }
            return found;
        }

        private static bool IsNetfx20Installed()
        {
            bool found = false;
            int regValue = 0;
            if (GetRegistryValue(RegistryHive.LocalMachine,
            Netfx20RegKeyName, Netfx11PlusRegValueName,

             RegistryValueKind.DWord, out regValue))
            {
                if (regValue == 1)
                {
                    found = true;
                }
            }
            return found;
        }*/


    }

}
