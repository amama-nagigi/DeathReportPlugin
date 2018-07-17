namespace AmamaNagigi.DeathReportPlugin
{
    partial class DeathReporterOverlayConfigPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.deathReporterOverlayConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDummyData = new System.Windows.Forms.Button();
            this.buttonDevTool = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxClickThru = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxLocked = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMaxCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxClearOnStart = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxIsExpanded = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.deathReporterOverlayConfigBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deathReporterOverlayConfigBindingSource, "IsVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "IsVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxVisible.Location = new System.Drawing.Point(144, 3);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVisible.TabIndex = 0;
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            // 
            // deathReporterOverlayConfigBindingSource
            // 
            this.deathReporterOverlayConfigBindingSource.DataSource = typeof(AmamaNagigi.DeathReportPlugin.DeathReporterOverlayConfig);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.56232F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVisible, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClickThru, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLocked, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMaxCount, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClearOnStart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxIsExpanded, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 315);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "HTMLファイルパス";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "オーバーレイを表示する";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "戦闘不能直前の表示秒数";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deathReporterOverlayConfigBindingSource, "AddonConfig.SecBeforeDeath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(144, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 19);
            this.numericUpDown1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textBoxUrl);
            this.flowLayoutPanel1.Controls.Add(this.buttonReference);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(144, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 29);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deathReporterOverlayConfigBindingSource, "Url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUrl.Location = new System.Drawing.Point(3, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(379, 19);
            this.textBoxUrl.TabIndex = 0;
            // 
            // buttonReference
            // 
            this.buttonReference.Location = new System.Drawing.Point(388, 3);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(75, 23);
            this.buttonReference.TabIndex = 1;
            this.buttonReference.Text = "参照";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "機能";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.buttonDummyData);
            this.flowLayoutPanel2.Controls.Add(this.buttonDevTool);
            this.flowLayoutPanel2.Controls.Add(this.buttonReload);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(144, 183);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(644, 57);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // buttonDummyData
            // 
            this.buttonDummyData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDummyData.Location = new System.Drawing.Point(3, 3);
            this.buttonDummyData.Name = "buttonDummyData";
            this.buttonDummyData.Size = new System.Drawing.Size(206, 51);
            this.buttonDummyData.TabIndex = 2;
            this.buttonDummyData.Text = "ダミーデータを送信";
            this.buttonDummyData.UseVisualStyleBackColor = true;
            this.buttonDummyData.Click += new System.EventHandler(this.buttonDummyData_Click);
            // 
            // buttonDevTool
            // 
            this.buttonDevTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDevTool.Location = new System.Drawing.Point(215, 3);
            this.buttonDevTool.Name = "buttonDevTool";
            this.buttonDevTool.Size = new System.Drawing.Size(206, 51);
            this.buttonDevTool.TabIndex = 0;
            this.buttonDevTool.Text = "Devツール表示";
            this.buttonDevTool.UseVisualStyleBackColor = true;
            this.buttonDevTool.Click += new System.EventHandler(this.buttonDevTool_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReload.Location = new System.Drawing.Point(427, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(206, 51);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "オーバーレイをリロード";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "クリックを透過させる";
            // 
            // checkBoxClickThru
            // 
            this.checkBoxClickThru.AutoSize = true;
            this.checkBoxClickThru.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "IsClickThru", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxClickThru.Location = new System.Drawing.Point(144, 23);
            this.checkBoxClickThru.Name = "checkBoxClickThru";
            this.checkBoxClickThru.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClickThru.TabIndex = 12;
            this.checkBoxClickThru.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "移動とリサイズを制限する";
            // 
            // checkBoxLocked
            // 
            this.checkBoxLocked.AutoSize = true;
            this.checkBoxLocked.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "IsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLocked.Location = new System.Drawing.Point(144, 43);
            this.checkBoxLocked.Name = "checkBoxLocked";
            this.checkBoxLocked.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLocked.TabIndex = 14;
            this.checkBoxLocked.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "最大ログ数";
            // 
            // numericUpDownMaxCount
            // 
            this.numericUpDownMaxCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deathReporterOverlayConfigBindingSource, "AddonConfig.MaxCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownMaxCount.Location = new System.Drawing.Point(144, 163);
            this.numericUpDownMaxCount.Name = "numericUpDownMaxCount";
            this.numericUpDownMaxCount.Size = new System.Drawing.Size(66, 19);
            this.numericUpDownMaxCount.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "戦闘開始時にデータクリア";
            // 
            // checkBoxClearOnStart
            // 
            this.checkBoxClearOnStart.AutoSize = true;
            this.checkBoxClearOnStart.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "AddonConfig.ClearOnStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxClearOnStart.Location = new System.Drawing.Point(144, 88);
            this.checkBoxClearOnStart.Name = "checkBoxClearOnStart";
            this.checkBoxClearOnStart.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClearOnStart.TabIndex = 18;
            this.checkBoxClearOnStart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "ログを初期状態で展開する";
            // 
            // checkBoxIsExpanded
            // 
            this.checkBoxIsExpanded.AutoSize = true;
            this.checkBoxIsExpanded.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "AddonConfig.IsExpanded", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxIsExpanded.Location = new System.Drawing.Point(144, 108);
            this.checkBoxIsExpanded.Name = "checkBoxIsExpanded";
            this.checkBoxIsExpanded.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsExpanded.TabIndex = 20;
            this.checkBoxIsExpanded.UseVisualStyleBackColor = true;
            // 
            // DeathReporterOverlayConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeathReporterOverlayConfigPanel";
            this.Size = new System.Drawing.Size(791, 315);
            ((System.ComponentModel.ISupportInitialize)(this.deathReporterOverlayConfigBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.BindingSource deathReporterOverlayConfigBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonDevTool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxClickThru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxLocked;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxClearOnStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxIsExpanded;
        private System.Windows.Forms.Button buttonDummyData;
    }
}
