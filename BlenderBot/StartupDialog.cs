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
        public string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
            //Retrieve configurations
            string[] argsarray = File.ReadAllLines(docs + @"\BlenderBot\prefs.cfg");
            string BlenderDir = argsarray[0].Split('=').Skip(1).FirstOrDefault();
            string ProjectDir = argsarray[1].Split('=').Skip(1).FirstOrDefault();
            ulong CID = Convert.ToUInt64(argsarray[2].Split('=').Skip(1).FirstOrDefault());
            string Format = argsarray[3].Split('=').Skip(1).FirstOrDefault();
            string Token = _Token.SetToken();
            #region Token
            /*
             * In order to prevent use of the token by unwanted applications or individuals I have included it in "Token.cs" and added that file to the .gitignore
             * The code in "Token.cs" (without the token) looked like this:
             * 
             *namespace BlenderBot {
             *	class _Token
             *  {
             *        public static string SetToken()
             *        {
             *            return "{Your Token}";
             *        }
             *    }
             *
             *}
             * 
             */
            #endregion 
            if (Format == "Use Blender Configuration")
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
            
            Console.WriteLine(docs);
            if (!File.Exists(docs + @"\BlenderBot\prefs.cfg"))
            {
                if(Directory.Exists(docs + @"\BlenderBot"))
                {
                    File.Copy("prefs.cfg", docs + @"\BlenderBot\prefs.cfg");
                }
                else
                {
                    Directory.CreateDirectory(docs + @"\BlenderBot");
                    File.Copy("prefs.cfg", docs + @"\BlenderBot\prefs.cfg");
                }
                
            }
        }
    }

}
