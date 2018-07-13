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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDevTool = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxClickThru = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.deathReporterOverlayConfigBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deathReporterOverlayConfigBindingSource, "IsVisible", true));
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "IsVisible", true));
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
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVisible, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClickThru, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 224);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
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
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "戦闘不能直前の表示秒数";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deathReporterOverlayConfigBindingSource, "SecBeforeDeath", true));
            this.numericUpDown1.Location = new System.Drawing.Point(144, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 19);
            this.numericUpDown1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.buttonReference);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(144, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(543, 29);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deathReporterOverlayConfigBindingSource, "Url", true));
            this.textBox1.Location = new System.Drawing.Point(3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 19);
            this.textBox1.TabIndex = 0;
            // 
            // buttonReference
            // 
            this.buttonReference.Location = new System.Drawing.Point(388, 3);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(75, 23);
            this.buttonReference.TabIndex = 1;
            this.buttonReference.Text = "参照";
            this.buttonReference.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "機能";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.buttonDevTool);
            this.flowLayoutPanel2.Controls.Add(this.buttonReload);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(144, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(543, 57);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // buttonDevTool
            // 
            this.buttonDevTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDevTool.Location = new System.Drawing.Point(3, 3);
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
            this.buttonReload.Location = new System.Drawing.Point(215, 3);
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
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "クリックを透過する";
            // 
            // checkBoxClickThru
            // 
            this.checkBoxClickThru.AutoSize = true;
            this.checkBoxClickThru.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deathReporterOverlayConfigBindingSource, "IsClickThru", true));
            this.checkBoxClickThru.Location = new System.Drawing.Point(144, 23);
            this.checkBoxClickThru.Name = "checkBoxClickThru";
            this.checkBoxClickThru.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClickThru.TabIndex = 12;
            this.checkBoxClickThru.UseVisualStyleBackColor = true;
            // 
            // DeathReporterOverlayConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeathReporterOverlayConfigPanel";
            this.Size = new System.Drawing.Size(690, 224);
            ((System.ComponentModel.ISupportInitialize)(this.deathReporterOverlayConfigBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.BindingSource deathReporterOverlayConfigBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}
