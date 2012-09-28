using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace SlayerService
{
    public partial class SlayerService : ServiceBase
    {
        Timer timer = null;
        MissileLauncher launcher = new MissileLauncher();


        public SlayerService()
        {
            InitializeComponent();
        }

        protected override void OnStart( string[] args )
        {
            launcher.command_reset();
            launcher.command_Up( 250 );

            timer = new Timer();
            timer.Interval = 20000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        } 

        protected override void OnStop()
        {
            timer.Stop();
        }


        void timer_Elapsed( object sender, ElapsedEventArgs e )
        {
            launcher.command_Fire();
        }
    }
}
