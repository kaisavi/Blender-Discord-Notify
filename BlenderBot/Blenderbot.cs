using System;
using System.Threading.Tasks;
using DSharpPlus;
using System.Diagnostics;

namespace Blenderbot
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static async Task Run(bool shutdown, ulong CID, string Token)
        {
            
            var discord = new DiscordClient(new DiscordConfig
            {
                AutoReconnect = true,
                DiscordBranch = Branch.Stable,
                LargeThreshold = 250,
                LogLevel = LogLevel.Debug,
                Token =  Token,
                TokenType = TokenType.Bot,
                UseInternalLogHandler = false
            }); //Create Discord Client
            //Events are processed here
            await discord.SendMessage(CID, "Render Finished");
            if (shutdown)
                Process.Start("shutdown", "-s -t 0");
            else
                Environment.Exit(0);
            //End
            await discord.Connect();
            //await Task.Delay(-1);
        }
    }
}
