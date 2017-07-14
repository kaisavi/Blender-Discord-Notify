using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BlenderBot
{
    public partial class Form1 : Form
    {
        public string appdata = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] argsarray = File.ReadAllLines(appdata + @"\BlenderBot\prefs.cfg");
            string BlenderDir = argsarray[0].Split('=').Skip(1).FirstOrDefault();
            string ProjectDir = argsarray[1].Split('=').Skip(1).FirstOrDefault();
            ulong CID = Convert.ToUInt64(argsarray[2].Split('=').Skip(1).FirstOrDefault());
            string Format = argsarray[3].Split('=').Skip(1).FirstOrDefault();
            string Token = File.ReadAllText("Token");
            if(Format == "Use Blender Configuration")
            {
                string args = "/c " + '"' + BlenderDir + ' ' + ProjectDir + FileName.Text + ".blend" + '"' + ' ' + $"-b -o //{FileName.Text} -f {FrameNumber.Text}" + '"';
                Render(args, CID, Token);
            }
            else
            {
                string args = "/c " + '"' + BlenderDir + ' ' + ProjectDir + FileName.Text + ".blend" + '"' + ' ' + $"-b -o //{FileName.Text} -F {Format} -f {FrameNumber.Text}" + '"';
                Render(args, CID, Token);
            }
            
        }

        private void Cancel(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Preferences(object sender, EventArgs e)
        {
            Preferences prefmenu = new Preferences();
            prefmenu.ShowDialog();
        }

        private void Help(object sender, CancelEventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }
        public async void Render(string args, ulong CID, string Token)
        {
            Console.WriteLine(args);
            var render = Process.Start("CMD.exe", args);
            render.WaitForExit();
            if (Shutdown.Checked)
            {
                await Blenderbot.Program.Run(true, CID, Token);
                Environment.Exit(0);
            }
            else
            {
                await Blenderbot.Program.Run(false, CID, Token);
            }

        }

        private void CheckConfig(object sender, EventArgs e)
        {
            
            Console.WriteLine(appdata);
            if (!File.Exists(appdata + @"\BlenderBot\prefs.cfg"))
            {
                if(Directory.Exists(appdata + @"\BlenderBot"))
                {
                    File.Copy("prefs.cfg", appdata + @"\BlenderBot\prefs.cfg");
                }
                else
                {
                    Directory.CreateDirectory(appdata + @"\BlenderBot");
                    File.Copy("prefs.cfg", appdata + @"\BlenderBot\prefs.cfg");
                }
                
            }
        }
    }

}
