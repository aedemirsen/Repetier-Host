﻿namespace RepetierHost
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStartHistory = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEndHistory = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eeprom = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalSlicingParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSDCardManager = new System.Windows.Forms.ToolStripMenuItem();
            this.testCaseGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierHostHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRepetierHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTempReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.toolLoad = new System.Windows.Forms.ToolStripSplitButton();
            this.toolRunJob = new System.Windows.Forms.ToolStripButton();
            this.toolKillJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSDCard = new System.Windows.Forms.ToolStripButton();
            this.toolShowLog = new System.Windows.Forms.ToolStripButton();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.tabGCode = new System.Windows.Forms.TabPage();
            this.splitJob = new System.Windows.Forms.SplitContainer();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.splitContainerPrinterGraphic = new System.Windows.Forms.SplitContainer();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openGCode = new System.Windows.Forms.OpenFileDialog();
            this.saveJobDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitLog = new System.Windows.Forms.SplitContainer();
            this.stlComposer1 = new RepetierHost.view.STLComposer();
            this.editor = new RepetierHost.view.RepetierEditor();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabGCode.SuspendLayout();
            this.splitJob.Panel1.SuspendLayout();
            this.splitJob.SuspendLayout();
            this.tabPrint.SuspendLayout();
            this.splitContainerPrinterGraphic.SuspendLayout();
            this.splitLog.Panel1.SuspendLayout();
            this.splitLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(942, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGCodeToolStripMenuItem,
            this.toolStripStartHistory,
            this.toolStripEndHistory,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadGCodeToolStripMenuItem
            // 
            this.loadGCodeToolStripMenuItem.Name = "loadGCodeToolStripMenuItem";
            this.loadGCodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loadGCodeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadGCodeToolStripMenuItem.Text = "&Load G-Code";
            this.loadGCodeToolStripMenuItem.Click += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolStripStartHistory
            // 
            this.toolStripStartHistory.Name = "toolStripStartHistory";
            this.toolStripStartHistory.Size = new System.Drawing.Size(160, 6);
            // 
            // toolStripEndHistory
            // 
            this.toolStripEndHistory.Name = "toolStripEndHistory";
            this.toolStripEndHistory.Size = new System.Drawing.Size(160, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerSettingsToolStripMenuItem,
            this.eeprom,
            this.skeinforgeSettingsToolStripMenuItem,
            this.threeDSettingsMenu,
            this.repetierSettingsToolStripMenuItem,
            this.internalSlicingParameterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // printerSettingsToolStripMenuItem
            // 
            this.printerSettingsToolStripMenuItem.Name = "printerSettingsToolStripMenuItem";
            this.printerSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printerSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.printerSettingsToolStripMenuItem.Text = "&Printer settings";
            this.printerSettingsToolStripMenuItem.Click += new System.EventHandler(this.printerSettingsToolStripMenuItem_Click);
            // 
            // eeprom
            // 
            this.eeprom.Name = "eeprom";
            this.eeprom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eeprom.Size = new System.Drawing.Size(252, 22);
            this.eeprom.Text = "Firmware EEPROM settings";
            this.eeprom.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // skeinforgeSettingsToolStripMenuItem
            // 
            this.skeinforgeSettingsToolStripMenuItem.Name = "skeinforgeSettingsToolStripMenuItem";
            this.skeinforgeSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.skeinforgeSettingsToolStripMenuItem.Text = "Skeinforge settings";
            this.skeinforgeSettingsToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeSettingsToolStripMenuItem_Click);
            // 
            // threeDSettingsMenu
            // 
            this.threeDSettingsMenu.Name = "threeDSettingsMenu";
            this.threeDSettingsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.threeDSettingsMenu.Size = new System.Drawing.Size(252, 22);
            this.threeDSettingsMenu.Text = "3D settings";
            this.threeDSettingsMenu.Click += new System.EventHandler(this.threeDSettingsMenu_Click);
            // 
            // repetierSettingsToolStripMenuItem
            // 
            this.repetierSettingsToolStripMenuItem.Name = "repetierSettingsToolStripMenuItem";
            this.repetierSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.repetierSettingsToolStripMenuItem.Text = "Repetier settings";
            this.repetierSettingsToolStripMenuItem.Click += new System.EventHandler(this.repetierSettingsToolStripMenuItem_Click);
            // 
            // internalSlicingParameterToolStripMenuItem
            // 
            this.internalSlicingParameterToolStripMenuItem.Name = "internalSlicingParameterToolStripMenuItem";
            this.internalSlicingParameterToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.internalSlicingParameterToolStripMenuItem.Text = "Internal slicing parameter";
            this.internalSlicingParameterToolStripMenuItem.Click += new System.EventHandler(this.internalSlicingParameterToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureMonitorToolStripMenuItem,
            this.printerInformationsToolStripMenuItem,
            this.jobStatusToolStripMenuItem,
            this.skeinforgeToolStripMenuItem,
            this.menuSDCardManager,
            this.testCaseGeneratorToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // temperatureMonitorToolStripMenuItem
            // 
            this.temperatureMonitorToolStripMenuItem.Name = "temperatureMonitorToolStripMenuItem";
            this.temperatureMonitorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.temperatureMonitorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.temperatureMonitorToolStripMenuItem.Text = "Temperature monitor";
            this.temperatureMonitorToolStripMenuItem.Click += new System.EventHandler(this.temperatureMonitorToolStripMenuItem_Click);
            // 
            // printerInformationsToolStripMenuItem
            // 
            this.printerInformationsToolStripMenuItem.Name = "printerInformationsToolStripMenuItem";
            this.printerInformationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printerInformationsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.printerInformationsToolStripMenuItem.Text = "Printer information";
            this.printerInformationsToolStripMenuItem.Click += new System.EventHandler(this.printerInformationsToolStripMenuItem_Click);
            // 
            // jobStatusToolStripMenuItem
            // 
            this.jobStatusToolStripMenuItem.Name = "jobStatusToolStripMenuItem";
            this.jobStatusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.jobStatusToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.jobStatusToolStripMenuItem.Text = "Job status";
            this.jobStatusToolStripMenuItem.Click += new System.EventHandler(this.jobStatusToolStripMenuItem_Click);
            // 
            // skeinforgeToolStripMenuItem
            // 
            this.skeinforgeToolStripMenuItem.Name = "skeinforgeToolStripMenuItem";
            this.skeinforgeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.skeinforgeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.skeinforgeToolStripMenuItem.Text = "Skeinforge";
            this.skeinforgeToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeToolStripMenuItem_Click);
            // 
            // menuSDCardManager
            // 
            this.menuSDCardManager.Name = "menuSDCardManager";
            this.menuSDCardManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.menuSDCardManager.Size = new System.Drawing.Size(225, 22);
            this.menuSDCardManager.Text = "SD card manager";
            this.menuSDCardManager.Click += new System.EventHandler(this.toolStripSDCard_Click);
            // 
            // testCaseGeneratorToolStripMenuItem
            // 
            this.testCaseGeneratorToolStripMenuItem.Name = "testCaseGeneratorToolStripMenuItem";
            this.testCaseGeneratorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.testCaseGeneratorToolStripMenuItem.Text = "Test case generator";
            this.testCaseGeneratorToolStripMenuItem.Click += new System.EventHandler(this.testCaseGeneratorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repetierHostHomepageToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutRepetierHostToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // repetierHostHomepageToolStripMenuItem
            // 
            this.repetierHostHomepageToolStripMenuItem.Name = "repetierHostHomepageToolStripMenuItem";
            this.repetierHostHomepageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.repetierHostHomepageToolStripMenuItem.Text = "Repetier-Host homepage";
            this.repetierHostHomepageToolStripMenuItem.Click += new System.EventHandler(this.repetierHostHomepageToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // aboutRepetierHostToolStripMenuItem
            // 
            this.aboutRepetierHostToolStripMenuItem.Name = "aboutRepetierHostToolStripMenuItem";
            this.aboutRepetierHostToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aboutRepetierHostToolStripMenuItem.Text = "&About Repetier-Host";
            this.aboutRepetierHostToolStripMenuItem.Click += new System.EventHandler(this.aboutRepetierHostToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnection,
            this.toolTempReading,
            this.toolAction,
            this.toolProgress,
            this.fpsLabel});
            this.status.Location = new System.Drawing.Point(0, 505);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(942, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // toolConnection
            // 
            this.toolConnection.Name = "toolConnection";
            this.toolConnection.Size = new System.Drawing.Size(86, 17);
            this.toolConnection.Text = "Not connected";
            // 
            // toolTempReading
            // 
            this.toolTempReading.Name = "toolTempReading";
            this.toolTempReading.Size = new System.Drawing.Size(12, 17);
            this.toolTempReading.Text = "-";
            // 
            // toolAction
            // 
            this.toolAction.Name = "toolAction";
            this.toolAction.Size = new System.Drawing.Size(26, 17);
            this.toolAction.Text = "Idle";
            // 
            // toolProgress
            // 
            this.toolProgress.Name = "toolProgress";
            this.toolProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // fpsLabel
            // 
            this.fpsLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(34, 17);
            this.fpsLabel.Text = "- FPS";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnect,
            this.toolLoad,
            this.toolRunJob,
            this.toolKillJob,
            this.toolStripSDCard,
            this.toolShowLog});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(942, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolConnect
            // 
            this.toolConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolConnect.Image")));
            this.toolConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConnect.Name = "toolConnect";
            this.toolConnect.Size = new System.Drawing.Size(48, 36);
            this.toolConnect.Text = "toolStripButton1";
            this.toolConnect.ToolTipText = "Connect printer";
            this.toolConnect.ButtonClick += new System.EventHandler(this.toolConnect_Click);
            // 
            // toolLoad
            // 
            this.toolLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolLoad.Image")));
            this.toolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoad.Name = "toolLoad";
            this.toolLoad.Size = new System.Drawing.Size(48, 36);
            this.toolLoad.Text = "toolStripSplitButton1";
            this.toolLoad.ToolTipText = "Load file";
            this.toolLoad.ButtonClick += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolRunJob
            // 
            this.toolRunJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRunJob.Image = ((System.Drawing.Image)(resources.GetObject("toolRunJob.Image")));
            this.toolRunJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRunJob.Name = "toolRunJob";
            this.toolRunJob.Size = new System.Drawing.Size(36, 36);
            this.toolRunJob.Text = "Run job";
            this.toolRunJob.Click += new System.EventHandler(this.toolPrintJob_Click);
            // 
            // toolKillJob
            // 
            this.toolKillJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKillJob.Enabled = false;
            this.toolKillJob.Image = ((System.Drawing.Image)(resources.GetObject("toolKillJob.Image")));
            this.toolKillJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKillJob.Name = "toolKillJob";
            this.toolKillJob.Size = new System.Drawing.Size(36, 36);
            this.toolKillJob.Text = "Kill Job";
            this.toolKillJob.Click += new System.EventHandler(this.toolKillJob_Click);
            // 
            // toolStripSDCard
            // 
            this.toolStripSDCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSDCard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSDCard.Image")));
            this.toolStripSDCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSDCard.Name = "toolStripSDCard";
            this.toolStripSDCard.Size = new System.Drawing.Size(36, 36);
            this.toolStripSDCard.Text = "SDCard";
            this.toolStripSDCard.ToolTipText = "SDCard management";
            this.toolStripSDCard.Click += new System.EventHandler(this.toolStripSDCard_Click);
            // 
            // toolShowLog
            // 
            this.toolShowLog.Checked = true;
            this.toolShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShowLog.Image = ((System.Drawing.Image)(resources.GetObject("toolShowLog.Image")));
            this.toolShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShowLog.Name = "toolShowLog";
            this.toolShowLog.Size = new System.Drawing.Size(36, 36);
            this.toolShowLog.Text = "toolShowLog";
            this.toolShowLog.ToolTipText = "Hide log";
            this.toolShowLog.CheckedChanged += new System.EventHandler(this.toolShowLog_CheckedChanged);
            this.toolShowLog.Click += new System.EventHandler(this.toolShowLog_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabModel);
            this.tab.Controls.Add(this.tabGCode);
            this.tab.Controls.Add(this.tabPrint);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(940, 343);
            this.tab.TabIndex = 3;
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.stlComposer1);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(932, 317);
            this.tabModel.TabIndex = 2;
            this.tabModel.Text = "Model";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // tabGCode
            // 
            this.tabGCode.AutoScroll = true;
            this.tabGCode.Controls.Add(this.splitJob);
            this.tabGCode.Location = new System.Drawing.Point(4, 22);
            this.tabGCode.Name = "tabGCode";
            this.tabGCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabGCode.Size = new System.Drawing.Size(934, 319);
            this.tabGCode.TabIndex = 1;
            this.tabGCode.Text = "Job";
            this.tabGCode.UseVisualStyleBackColor = true;
            // 
            // splitJob
            // 
            this.splitJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitJob.BackColor = System.Drawing.Color.Transparent;
            this.splitJob.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitJob.Location = new System.Drawing.Point(3, 3);
            this.splitJob.Name = "splitJob";
            // 
            // splitJob.Panel1
            // 
            this.splitJob.Panel1.Controls.Add(this.editor);
            this.splitJob.Size = new System.Drawing.Size(928, 310);
            this.splitJob.SplitterDistance = 500;
            this.splitJob.TabIndex = 3;
            // 
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.splitContainerPrinterGraphic);
            this.tabPrint.Location = new System.Drawing.Point(4, 22);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(934, 319);
            this.tabPrint.TabIndex = 0;
            this.tabPrint.Text = "Print";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // splitContainerPrinterGraphic
            // 
            this.splitContainerPrinterGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrinterGraphic.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPrinterGraphic.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPrinterGraphic.Name = "splitContainerPrinterGraphic";
            this.splitContainerPrinterGraphic.Size = new System.Drawing.Size(928, 313);
            this.splitContainerPrinterGraphic.SplitterDistance = 465;
            this.splitContainerPrinterGraphic.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "connect.png");
            this.imageList.Images.SetKeyName(1, "disconnect.png");
            // 
            // openGCode
            // 
            this.openGCode.DefaultExt = "gcode";
            this.openGCode.Filter = "GCode/STL-Files|*.gcode;*.stl|All files|*.*";
            this.openGCode.Title = "Import G-Code";
            // 
            // saveJobDialog
            // 
            this.saveJobDialog.DefaultExt = "gcode";
            this.saveJobDialog.Filter = "GCode|*.gcode|All files|*.*";
            this.saveJobDialog.Title = "Save G-Code";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // splitLog
            // 
            this.splitLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLog.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLog.Location = new System.Drawing.Point(0, 63);
            this.splitLog.Name = "splitLog";
            this.splitLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLog.Panel1
            // 
            this.splitLog.Panel1.Controls.Add(this.tab);
            this.splitLog.Size = new System.Drawing.Size(942, 442);
            this.splitLog.SplitterDistance = 345;
            this.splitLog.TabIndex = 4;
            // 
            // stlComposer1
            // 
            this.stlComposer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stlComposer1.Location = new System.Drawing.Point(0, 0);
            this.stlComposer1.Name = "stlComposer1";
            this.stlComposer1.Size = new System.Drawing.Size(932, 317);
            this.stlComposer1.TabIndex = 0;
            // 
            // editor
            // 
            this.editor.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.editor.autopreview = true;
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.MinimumSize = new System.Drawing.Size(150, 140);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(500, 310);
            this.editor.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 527);
            this.Controls.Add(this.splitLog);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Repetier-Host V0.28";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabModel.ResumeLayout(false);
            this.tabGCode.ResumeLayout(false);
            this.splitJob.Panel1.ResumeLayout(false);
            this.splitJob.ResumeLayout(false);
            this.tabPrint.ResumeLayout(false);
            this.splitContainerPrinterGraphic.ResumeLayout(false);
            this.splitLog.Panel1.ResumeLayout(false);
            this.splitLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripEndHistory;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRepetierHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolAction;
        private System.Windows.Forms.ToolStripProgressBar toolProgress;
        private System.Windows.Forms.SplitContainer splitContainerPrinterGraphic;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eeprom;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openGCode;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeDSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem printerInformationsToolStripMenuItem;
        private RepetierHost.view.STLComposer stlComposer1;
        private System.Windows.Forms.ToolStripMenuItem repetierSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetierHostHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripButton toolRunJob;
        public System.Windows.Forms.ToolStripButton toolKillJob;
        public System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem testCaseGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalSlicingParameterToolStripMenuItem;
        public System.Windows.Forms.TabControl tab;
        public System.Windows.Forms.TabPage tabPrint;
        public System.Windows.Forms.TabPage tabModel;
        public System.Windows.Forms.ToolStripButton toolStripSDCard;
        public System.Windows.Forms.ToolStripMenuItem menuSDCardManager;
        public System.Windows.Forms.SaveFileDialog saveJobDialog;
        public System.Windows.Forms.TabPage tabGCode;
        private System.Windows.Forms.SplitContainer splitJob;
        public RepetierHost.view.RepetierEditor editor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSplitButton toolConnect;
        private System.Windows.Forms.SplitContainer splitLog;
        private System.Windows.Forms.ToolStripButton toolShowLog;
        public System.Windows.Forms.ToolStripStatusLabel toolTempReading;
        private System.Windows.Forms.ToolStripSeparator toolStripStartHistory;
        private System.Windows.Forms.ToolStripSplitButton toolLoad;
    }
}

