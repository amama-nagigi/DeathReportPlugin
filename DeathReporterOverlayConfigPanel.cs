using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmamaNagigi.DeathReportPlugin.Entities;

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

        /// <summary>
        /// 参照ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReference_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textBoxUrl.Text = new Uri(ofd.FileName).ToString();
            }
        }

        /// <summary>
        /// ダミーデータ送信ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDummyData_Click(object sender, EventArgs e)
        {
            this.overlay.AddDummyDeathReport();
        }
    }
}
