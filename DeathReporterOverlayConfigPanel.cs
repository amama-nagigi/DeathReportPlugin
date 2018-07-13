﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmamaNagigi.DeathReportPlugin
{
    public partial class DeathReporterOverlayConfigPanel : UserControl
    {
        private DeathReporterOverlay overlay;

        public DeathReporterOverlayConfigPanel(DeathReporterOverlay overlay)
        {
            InitializeComponent();

            this.overlay = overlay;
            this.deathReporterOverlayConfigBindingSource.DataSource = this.overlay.Config;
        }

        /// <summary>
        /// Devツール表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDevTool_Click(object sender, EventArgs e)
        {
            if (this.overlay.Overlay != null && this.overlay.Overlay.Renderer != null && this.overlay.Overlay.Renderer.Browser != null)
            {
                this.overlay.Overlay.Renderer.showDevTools();
            }
        }

        /// <summary>
        /// オーバーレイをリロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.overlay.Overlay.Renderer.Reload();
        }
    }
}