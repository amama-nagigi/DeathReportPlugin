using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmamaNagigi.DeathReportPlugin
{
    public partial class DeathReportEventSourceConfigPanel : UserControl
    {
        private DeathReportEventSourceConfig config;
        private DeathReportEventSource source;
        public DeathReportEventSourceConfigPanel(DeathReportEventSource source)
        {
            InitializeComponent();

            this.source = source;
            this.config = source.Config;

            SetupControlProperties();
            SetupConfigEventHandlers();
        }
        private void SetupControlProperties()
        {
            
        }

        private void SetupConfigEventHandlers()
        {
        }

        private void InvokeIfRequired(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
