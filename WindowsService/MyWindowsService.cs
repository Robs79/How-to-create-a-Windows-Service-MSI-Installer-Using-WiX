using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class MyWindowsService : ServiceBase
    {
        public MyWindowsService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("Acme.WindowsService"))
            {
                System.Diagnostics.EventLog.CreateEventSource("Acme.WindowsService", "Application");
            }
            eventLog1.Source = "Acme.WindowsService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In onStop.");
        }
    }
}
