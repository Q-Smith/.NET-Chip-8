namespace Emulator.WinForms {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuContainer = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpenROM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuKeyboard = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tbarContainer = new System.Windows.Forms.ToolStrip();
			this.tbarRun = new System.Windows.Forms.ToolStripButton();
			this.tbarPause = new System.Windows.Forms.ToolStripButton();
			this.tbarReset = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbarDebugStart = new System.Windows.Forms.ToolStripButton();
			this.tbarDebugStepOver = new System.Windows.Forms.ToolStripButton();
			this.tbarDebugStop = new System.Windows.Forms.ToolStripButton();
			this.sbarContainer = new System.Windows.Forms.StatusStrip();
			this.sbarStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabContainer = new System.Windows.Forms.TabControl();
			this.tabGame = new System.Windows.Forms.TabPage();
			this.otkGLGame = new OpenTK.GLControl();
			this.tabCPU = new System.Windows.Forms.TabPage();
			this.txtCpuCycles = new System.Windows.Forms.TextBox();
			this.lblHertzs = new System.Windows.Forms.Label();
			this.lblCpuCycles = new System.Windows.Forms.Label();
			this.txtVI = new System.Windows.Forms.TextBox();
			this.lblVI = new System.Windows.Forms.Label();
			this.lblIndexRegister = new System.Windows.Forms.Label();
			this.tlpDataRegisters = new System.Windows.Forms.TableLayoutPanel();
			this.lblVC = new System.Windows.Forms.Label();
			this.txtVC = new System.Windows.Forms.TextBox();
			this.lblVD = new System.Windows.Forms.Label();
			this.txtVD = new System.Windows.Forms.TextBox();
			this.lblVE = new System.Windows.Forms.Label();
			this.txtVE = new System.Windows.Forms.TextBox();
			this.lblVF = new System.Windows.Forms.Label();
			this.txtVF = new System.Windows.Forms.TextBox();
			this.lblVB = new System.Windows.Forms.Label();
			this.txtVB = new System.Windows.Forms.TextBox();
			this.lblVA = new System.Windows.Forms.Label();
			this.txtVA = new System.Windows.Forms.TextBox();
			this.lblV9 = new System.Windows.Forms.Label();
			this.txtV9 = new System.Windows.Forms.TextBox();
			this.lblV8 = new System.Windows.Forms.Label();
			this.txtV8 = new System.Windows.Forms.TextBox();
			this.lblV7 = new System.Windows.Forms.Label();
			this.txtV7 = new System.Windows.Forms.TextBox();
			this.lblV6 = new System.Windows.Forms.Label();
			this.txtV6 = new System.Windows.Forms.TextBox();
			this.lblV5 = new System.Windows.Forms.Label();
			this.txtV5 = new System.Windows.Forms.TextBox();
			this.lblV4 = new System.Windows.Forms.Label();
			this.txtV4 = new System.Windows.Forms.TextBox();
			this.lblV0 = new System.Windows.Forms.Label();
			this.txtV0 = new System.Windows.Forms.TextBox();
			this.lblV1 = new System.Windows.Forms.Label();
			this.txtV1 = new System.Windows.Forms.TextBox();
			this.lblV2 = new System.Windows.Forms.Label();
			this.txtV2 = new System.Windows.Forms.TextBox();
			this.lblV3 = new System.Windows.Forms.Label();
			this.txtV3 = new System.Windows.Forms.TextBox();
			this.lblDataRegisters = new System.Windows.Forms.Label();
			this.tabMemory = new System.Windows.Forms.TabPage();
			this.spltMemoryContainer = new System.Windows.Forms.SplitContainer();
			this.lblMemoryData = new System.Windows.Forms.Label();
			this.rtbMemoryBytes = new System.Windows.Forms.RichTextBox();
			this.lblStackData = new System.Windows.Forms.Label();
			this.lstbStack = new System.Windows.Forms.ListBox();
			this.tabFontSet = new System.Windows.Forms.TabPage();
			this.otkGLFontSet = new OpenTK.GLControl();
			this.tabASM = new System.Windows.Forms.TabPage();
			this.rtbASM = new System.Windows.Forms.RichTextBox();
			this.mnuContainer.SuspendLayout();
			this.tbarContainer.SuspendLayout();
			this.sbarContainer.SuspendLayout();
			this.tabContainer.SuspendLayout();
			this.tabGame.SuspendLayout();
			this.tabCPU.SuspendLayout();
			this.tlpDataRegisters.SuspendLayout();
			this.tabMemory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spltMemoryContainer)).BeginInit();
			this.spltMemoryContainer.Panel1.SuspendLayout();
			this.spltMemoryContainer.Panel2.SuspendLayout();
			this.spltMemoryContainer.SuspendLayout();
			this.tabFontSet.SuspendLayout();
			this.tabASM.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuContainer
			// 
			this.mnuContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuHelp});
			this.mnuContainer.Location = new System.Drawing.Point(0, 0);
			this.mnuContainer.Name = "mnuContainer";
			this.mnuContainer.Size = new System.Drawing.Size(530, 24);
			this.mnuContainer.TabIndex = 0;
			this.mnuContainer.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenROM,
            this.toolStripMenuItem1,
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "&File";
			// 
			// mnuOpenROM
			// 
			this.mnuOpenROM.Name = "mnuOpenROM";
			this.mnuOpenROM.Size = new System.Drawing.Size(112, 22);
			this.mnuOpenROM.Text = "&Open...";
			this.mnuOpenROM.Click += new System.EventHandler(this.mnuOpenROM_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(112, 22);
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuView
			// 
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKeyboard});
			this.mnuView.Name = "mnuView";
			this.mnuView.Size = new System.Drawing.Size(44, 20);
			this.mnuView.Text = "&View";
			// 
			// mnuKeyboard
			// 
			this.mnuKeyboard.Name = "mnuKeyboard";
			this.mnuKeyboard.Size = new System.Drawing.Size(124, 22);
			this.mnuKeyboard.Text = "&Keyboard";
			this.mnuKeyboard.Click += new System.EventHandler(this.mnuKeyboard_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "&Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(107, 22);
			this.mnuAbout.Text = "&About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// tbarContainer
			// 
			this.tbarContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbarRun,
            this.tbarPause,
            this.tbarReset,
            this.toolStripSeparator1,
            this.tbarDebugStart,
            this.tbarDebugStepOver,
            this.tbarDebugStop});
			this.tbarContainer.Location = new System.Drawing.Point(0, 24);
			this.tbarContainer.Name = "tbarContainer";
			this.tbarContainer.Size = new System.Drawing.Size(530, 25);
			this.tbarContainer.TabIndex = 1;
			this.tbarContainer.Text = "toolStrip1";
			// 
			// tbarRun
			// 
			this.tbarRun.Enabled = false;
			this.tbarRun.Image = ((System.Drawing.Image)(resources.GetObject("tbarRun.Image")));
			this.tbarRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarRun.Name = "tbarRun";
			this.tbarRun.Size = new System.Drawing.Size(48, 22);
			this.tbarRun.Text = "Run";
			this.tbarRun.ToolTipText = "Run the program";
			this.tbarRun.Click += new System.EventHandler(this.tbarRun_Click);
			// 
			// tbarPause
			// 
			this.tbarPause.Enabled = false;
			this.tbarPause.Image = ((System.Drawing.Image)(resources.GetObject("tbarPause.Image")));
			this.tbarPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarPause.Name = "tbarPause";
			this.tbarPause.Size = new System.Drawing.Size(58, 22);
			this.tbarPause.Text = "Pause";
			this.tbarPause.ToolTipText = "Pause the program";
			this.tbarPause.Click += new System.EventHandler(this.tbarPause_Click);
			// 
			// tbarReset
			// 
			this.tbarReset.Enabled = false;
			this.tbarReset.Image = ((System.Drawing.Image)(resources.GetObject("tbarReset.Image")));
			this.tbarReset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarReset.Name = "tbarReset";
			this.tbarReset.Size = new System.Drawing.Size(55, 22);
			this.tbarReset.Text = "Reset";
			this.tbarReset.ToolTipText = "Restart the ROM";
			this.tbarReset.Click += new System.EventHandler(this.tbarReset_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tbarDebugStart
			// 
			this.tbarDebugStart.Enabled = false;
			this.tbarDebugStart.Image = ((System.Drawing.Image)(resources.GetObject("tbarDebugStart.Image")));
			this.tbarDebugStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarDebugStart.Name = "tbarDebugStart";
			this.tbarDebugStart.Size = new System.Drawing.Size(62, 22);
			this.tbarDebugStart.Text = "Debug";
			this.tbarDebugStart.ToolTipText = "Start Debugging";
			// 
			// tbarDebugStepOver
			// 
			this.tbarDebugStepOver.Enabled = false;
			this.tbarDebugStepOver.Image = ((System.Drawing.Image)(resources.GetObject("tbarDebugStepOver.Image")));
			this.tbarDebugStepOver.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarDebugStepOver.Name = "tbarDebugStepOver";
			this.tbarDebugStepOver.Size = new System.Drawing.Size(78, 22);
			this.tbarDebugStepOver.Text = "Step Over";
			// 
			// tbarDebugStop
			// 
			this.tbarDebugStop.Enabled = false;
			this.tbarDebugStop.Image = ((System.Drawing.Image)(resources.GetObject("tbarDebugStop.Image")));
			this.tbarDebugStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbarDebugStop.Name = "tbarDebugStop";
			this.tbarDebugStop.Size = new System.Drawing.Size(51, 22);
			this.tbarDebugStop.Text = "Stop";
			this.tbarDebugStop.ToolTipText = "Stop Debugging";
			// 
			// sbarContainer
			// 
			this.sbarContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbarStatus});
			this.sbarContainer.Location = new System.Drawing.Point(0, 359);
			this.sbarContainer.Name = "sbarContainer";
			this.sbarContainer.Size = new System.Drawing.Size(530, 22);
			this.sbarContainer.TabIndex = 2;
			this.sbarContainer.Text = "statusStrip1";
			// 
			// sbarStatus
			// 
			this.sbarStatus.Name = "sbarStatus";
			this.sbarStatus.Size = new System.Drawing.Size(42, 17);
			this.sbarStatus.Text = "Ready!";
			// 
			// tabContainer
			// 
			this.tabContainer.Controls.Add(this.tabGame);
			this.tabContainer.Controls.Add(this.tabCPU);
			this.tabContainer.Controls.Add(this.tabMemory);
			this.tabContainer.Controls.Add(this.tabFontSet);
			this.tabContainer.Controls.Add(this.tabASM);
			this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabContainer.Location = new System.Drawing.Point(0, 49);
			this.tabContainer.Name = "tabContainer";
			this.tabContainer.SelectedIndex = 0;
			this.tabContainer.Size = new System.Drawing.Size(530, 310);
			this.tabContainer.TabIndex = 3;
			this.tabContainer.SelectedIndexChanged += new System.EventHandler(this.tabContainer_SelectedIndexChanged);
			// 
			// tabGame
			// 
			this.tabGame.Controls.Add(this.otkGLGame);
			this.tabGame.Location = new System.Drawing.Point(4, 22);
			this.tabGame.Name = "tabGame";
			this.tabGame.Padding = new System.Windows.Forms.Padding(3);
			this.tabGame.Size = new System.Drawing.Size(522, 284);
			this.tabGame.TabIndex = 0;
			this.tabGame.Text = "Game";
			this.tabGame.UseVisualStyleBackColor = true;
			// 
			// otkGLGame
			// 
			this.otkGLGame.BackColor = System.Drawing.Color.Black;
			this.otkGLGame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.otkGLGame.Location = new System.Drawing.Point(3, 3);
			this.otkGLGame.Name = "otkGLGame";
			this.otkGLGame.Size = new System.Drawing.Size(516, 278);
			this.otkGLGame.TabIndex = 0;
			this.otkGLGame.VSync = false;
			this.otkGLGame.Load += new System.EventHandler(this.otkGLControl_Load);
			this.otkGLGame.Paint += new System.Windows.Forms.PaintEventHandler(this.otkGLControl_Paint);
			this.otkGLGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.otkGLControl_KeyDown);
			this.otkGLGame.KeyUp += new System.Windows.Forms.KeyEventHandler(this.otkGLControl_KeyUp);
			this.otkGLGame.Resize += new System.EventHandler(this.otkGLControl_Resize);
			// 
			// tabCPU
			// 
			this.tabCPU.Controls.Add(this.txtCpuCycles);
			this.tabCPU.Controls.Add(this.lblHertzs);
			this.tabCPU.Controls.Add(this.lblCpuCycles);
			this.tabCPU.Controls.Add(this.txtVI);
			this.tabCPU.Controls.Add(this.lblVI);
			this.tabCPU.Controls.Add(this.lblIndexRegister);
			this.tabCPU.Controls.Add(this.tlpDataRegisters);
			this.tabCPU.Controls.Add(this.lblDataRegisters);
			this.tabCPU.Location = new System.Drawing.Point(4, 22);
			this.tabCPU.Name = "tabCPU";
			this.tabCPU.Padding = new System.Windows.Forms.Padding(3);
			this.tabCPU.Size = new System.Drawing.Size(522, 284);
			this.tabCPU.TabIndex = 1;
			this.tabCPU.Text = "CPU";
			this.tabCPU.UseVisualStyleBackColor = true;
			// 
			// txtCpuCycles
			// 
			this.txtCpuCycles.BackColor = System.Drawing.Color.Black;
			this.txtCpuCycles.ForeColor = System.Drawing.Color.Lime;
			this.txtCpuCycles.Location = new System.Drawing.Point(329, 12);
			this.txtCpuCycles.Name = "txtCpuCycles";
			this.txtCpuCycles.Size = new System.Drawing.Size(60, 20);
			this.txtCpuCycles.TabIndex = 9;
			this.txtCpuCycles.Text = "60";
			// 
			// lblHertzs
			// 
			this.lblHertzs.AutoSize = true;
			this.lblHertzs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHertzs.Location = new System.Drawing.Point(395, 14);
			this.lblHertzs.Name = "lblHertzs";
			this.lblHertzs.Size = new System.Drawing.Size(22, 13);
			this.lblHertzs.TabIndex = 8;
			this.lblHertzs.Text = "Hz";
			// 
			// lblCpuCycles
			// 
			this.lblCpuCycles.AutoSize = true;
			this.lblCpuCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpuCycles.Location = new System.Drawing.Point(266, 12);
			this.lblCpuCycles.Name = "lblCpuCycles";
			this.lblCpuCycles.Size = new System.Drawing.Size(59, 16);
			this.lblCpuCycles.TabIndex = 7;
			this.lblCpuCycles.Text = "Cycles:";
			// 
			// txtVI
			// 
			this.txtVI.BackColor = System.Drawing.Color.Black;
			this.txtVI.ForeColor = System.Drawing.Color.Lime;
			this.txtVI.Location = new System.Drawing.Point(149, 12);
			this.txtVI.Name = "txtVI";
			this.txtVI.Size = new System.Drawing.Size(60, 20);
			this.txtVI.TabIndex = 4;
			this.txtVI.Text = "0x0000";
			// 
			// lblVI
			// 
			this.lblVI.AutoSize = true;
			this.lblVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVI.Location = new System.Drawing.Point(126, 15);
			this.lblVI.Name = "lblVI";
			this.lblVI.Size = new System.Drawing.Size(19, 13);
			this.lblVI.TabIndex = 3;
			this.lblVI.Text = "VI";
			// 
			// lblIndexRegister
			// 
			this.lblIndexRegister.AutoSize = true;
			this.lblIndexRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIndexRegister.Location = new System.Drawing.Point(8, 12);
			this.lblIndexRegister.Name = "lblIndexRegister";
			this.lblIndexRegister.Size = new System.Drawing.Size(112, 16);
			this.lblIndexRegister.TabIndex = 2;
			this.lblIndexRegister.Text = "Index Register:";
			// 
			// tlpDataRegisters
			// 
			this.tlpDataRegisters.ColumnCount = 8;
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDataRegisters.Controls.Add(this.lblVC, 0, 3);
			this.tlpDataRegisters.Controls.Add(this.txtVC, 1, 3);
			this.tlpDataRegisters.Controls.Add(this.lblVD, 2, 3);
			this.tlpDataRegisters.Controls.Add(this.txtVD, 3, 3);
			this.tlpDataRegisters.Controls.Add(this.lblVE, 4, 3);
			this.tlpDataRegisters.Controls.Add(this.txtVE, 5, 3);
			this.tlpDataRegisters.Controls.Add(this.lblVF, 6, 3);
			this.tlpDataRegisters.Controls.Add(this.txtVF, 7, 3);
			this.tlpDataRegisters.Controls.Add(this.lblVB, 6, 2);
			this.tlpDataRegisters.Controls.Add(this.txtVB, 7, 2);
			this.tlpDataRegisters.Controls.Add(this.lblVA, 4, 2);
			this.tlpDataRegisters.Controls.Add(this.txtVA, 5, 2);
			this.tlpDataRegisters.Controls.Add(this.lblV9, 2, 2);
			this.tlpDataRegisters.Controls.Add(this.txtV9, 3, 2);
			this.tlpDataRegisters.Controls.Add(this.lblV8, 0, 2);
			this.tlpDataRegisters.Controls.Add(this.txtV8, 1, 2);
			this.tlpDataRegisters.Controls.Add(this.lblV7, 6, 1);
			this.tlpDataRegisters.Controls.Add(this.txtV7, 7, 1);
			this.tlpDataRegisters.Controls.Add(this.lblV6, 4, 1);
			this.tlpDataRegisters.Controls.Add(this.txtV6, 5, 1);
			this.tlpDataRegisters.Controls.Add(this.lblV5, 2, 1);
			this.tlpDataRegisters.Controls.Add(this.txtV5, 3, 1);
			this.tlpDataRegisters.Controls.Add(this.lblV4, 0, 1);
			this.tlpDataRegisters.Controls.Add(this.txtV4, 1, 1);
			this.tlpDataRegisters.Controls.Add(this.lblV0, 0, 0);
			this.tlpDataRegisters.Controls.Add(this.txtV0, 1, 0);
			this.tlpDataRegisters.Controls.Add(this.lblV1, 2, 0);
			this.tlpDataRegisters.Controls.Add(this.txtV1, 3, 0);
			this.tlpDataRegisters.Controls.Add(this.lblV2, 4, 0);
			this.tlpDataRegisters.Controls.Add(this.txtV2, 5, 0);
			this.tlpDataRegisters.Controls.Add(this.lblV3, 6, 0);
			this.tlpDataRegisters.Controls.Add(this.txtV3, 7, 0);
			this.tlpDataRegisters.Location = new System.Drawing.Point(11, 70);
			this.tlpDataRegisters.Name = "tlpDataRegisters";
			this.tlpDataRegisters.RowCount = 4;
			this.tlpDataRegisters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpDataRegisters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpDataRegisters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpDataRegisters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpDataRegisters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpDataRegisters.Size = new System.Drawing.Size(471, 100);
			this.tlpDataRegisters.TabIndex = 1;
			// 
			// lblVC
			// 
			this.lblVC.AutoSize = true;
			this.lblVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVC.Location = new System.Drawing.Point(3, 78);
			this.lblVC.Name = "lblVC";
			this.lblVC.Size = new System.Drawing.Size(23, 13);
			this.lblVC.TabIndex = 30;
			this.lblVC.Text = "VC";
			// 
			// txtVC
			// 
			this.txtVC.BackColor = System.Drawing.Color.Black;
			this.txtVC.ForeColor = System.Drawing.Color.Lime;
			this.txtVC.Location = new System.Drawing.Point(32, 81);
			this.txtVC.Name = "txtVC";
			this.txtVC.Size = new System.Drawing.Size(60, 20);
			this.txtVC.TabIndex = 31;
			this.txtVC.Text = "0x0000";
			// 
			// lblVD
			// 
			this.lblVD.AutoSize = true;
			this.lblVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVD.Location = new System.Drawing.Point(98, 78);
			this.lblVD.Name = "lblVD";
			this.lblVD.Size = new System.Drawing.Size(24, 13);
			this.lblVD.TabIndex = 28;
			this.lblVD.Text = "VD";
			// 
			// txtVD
			// 
			this.txtVD.BackColor = System.Drawing.Color.Black;
			this.txtVD.ForeColor = System.Drawing.Color.Lime;
			this.txtVD.Location = new System.Drawing.Point(128, 81);
			this.txtVD.Name = "txtVD";
			this.txtVD.Size = new System.Drawing.Size(60, 20);
			this.txtVD.TabIndex = 29;
			this.txtVD.Text = "0x0000";
			// 
			// lblVE
			// 
			this.lblVE.AutoSize = true;
			this.lblVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVE.Location = new System.Drawing.Point(194, 78);
			this.lblVE.Name = "lblVE";
			this.lblVE.Size = new System.Drawing.Size(23, 13);
			this.lblVE.TabIndex = 26;
			this.lblVE.Text = "VE";
			// 
			// txtVE
			// 
			this.txtVE.BackColor = System.Drawing.Color.Black;
			this.txtVE.ForeColor = System.Drawing.Color.Lime;
			this.txtVE.Location = new System.Drawing.Point(223, 81);
			this.txtVE.Name = "txtVE";
			this.txtVE.Size = new System.Drawing.Size(60, 20);
			this.txtVE.TabIndex = 27;
			this.txtVE.Text = "0x0000";
			// 
			// lblVF
			// 
			this.lblVF.AutoSize = true;
			this.lblVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVF.Location = new System.Drawing.Point(289, 78);
			this.lblVF.Name = "lblVF";
			this.lblVF.Size = new System.Drawing.Size(22, 13);
			this.lblVF.TabIndex = 24;
			this.lblVF.Text = "VF";
			// 
			// txtVF
			// 
			this.txtVF.BackColor = System.Drawing.Color.Black;
			this.txtVF.ForeColor = System.Drawing.Color.Lime;
			this.txtVF.Location = new System.Drawing.Point(318, 81);
			this.txtVF.Name = "txtVF";
			this.txtVF.Size = new System.Drawing.Size(60, 20);
			this.txtVF.TabIndex = 25;
			this.txtVF.Text = "0x0000";
			// 
			// lblVB
			// 
			this.lblVB.AutoSize = true;
			this.lblVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVB.Location = new System.Drawing.Point(289, 52);
			this.lblVB.Name = "lblVB";
			this.lblVB.Size = new System.Drawing.Size(23, 13);
			this.lblVB.TabIndex = 22;
			this.lblVB.Text = "VB";
			// 
			// txtVB
			// 
			this.txtVB.BackColor = System.Drawing.Color.Black;
			this.txtVB.ForeColor = System.Drawing.Color.Lime;
			this.txtVB.Location = new System.Drawing.Point(318, 55);
			this.txtVB.Name = "txtVB";
			this.txtVB.Size = new System.Drawing.Size(60, 20);
			this.txtVB.TabIndex = 23;
			this.txtVB.Text = "0x0000";
			// 
			// lblVA
			// 
			this.lblVA.AutoSize = true;
			this.lblVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVA.Location = new System.Drawing.Point(194, 52);
			this.lblVA.Name = "lblVA";
			this.lblVA.Size = new System.Drawing.Size(23, 13);
			this.lblVA.TabIndex = 20;
			this.lblVA.Text = "VA";
			// 
			// txtVA
			// 
			this.txtVA.BackColor = System.Drawing.Color.Black;
			this.txtVA.ForeColor = System.Drawing.Color.Lime;
			this.txtVA.Location = new System.Drawing.Point(223, 55);
			this.txtVA.Name = "txtVA";
			this.txtVA.Size = new System.Drawing.Size(60, 20);
			this.txtVA.TabIndex = 21;
			this.txtVA.Text = "0x0000";
			// 
			// lblV9
			// 
			this.lblV9.AutoSize = true;
			this.lblV9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV9.Location = new System.Drawing.Point(98, 52);
			this.lblV9.Name = "lblV9";
			this.lblV9.Size = new System.Drawing.Size(22, 13);
			this.lblV9.TabIndex = 18;
			this.lblV9.Text = "V9";
			// 
			// txtV9
			// 
			this.txtV9.BackColor = System.Drawing.Color.Black;
			this.txtV9.ForeColor = System.Drawing.Color.Lime;
			this.txtV9.Location = new System.Drawing.Point(128, 55);
			this.txtV9.Name = "txtV9";
			this.txtV9.Size = new System.Drawing.Size(60, 20);
			this.txtV9.TabIndex = 19;
			this.txtV9.Text = "0x0000";
			// 
			// lblV8
			// 
			this.lblV8.AutoSize = true;
			this.lblV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV8.Location = new System.Drawing.Point(3, 52);
			this.lblV8.Name = "lblV8";
			this.lblV8.Size = new System.Drawing.Size(22, 13);
			this.lblV8.TabIndex = 16;
			this.lblV8.Text = "V8";
			// 
			// txtV8
			// 
			this.txtV8.BackColor = System.Drawing.Color.Black;
			this.txtV8.ForeColor = System.Drawing.Color.Lime;
			this.txtV8.Location = new System.Drawing.Point(32, 55);
			this.txtV8.Name = "txtV8";
			this.txtV8.Size = new System.Drawing.Size(60, 20);
			this.txtV8.TabIndex = 17;
			this.txtV8.Text = "0x0000";
			// 
			// lblV7
			// 
			this.lblV7.AutoSize = true;
			this.lblV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV7.Location = new System.Drawing.Point(289, 26);
			this.lblV7.Name = "lblV7";
			this.lblV7.Size = new System.Drawing.Size(22, 13);
			this.lblV7.TabIndex = 14;
			this.lblV7.Text = "V7";
			// 
			// txtV7
			// 
			this.txtV7.BackColor = System.Drawing.Color.Black;
			this.txtV7.ForeColor = System.Drawing.Color.Lime;
			this.txtV7.Location = new System.Drawing.Point(318, 29);
			this.txtV7.Name = "txtV7";
			this.txtV7.Size = new System.Drawing.Size(60, 20);
			this.txtV7.TabIndex = 15;
			this.txtV7.Text = "0x0000";
			// 
			// lblV6
			// 
			this.lblV6.AutoSize = true;
			this.lblV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV6.Location = new System.Drawing.Point(194, 26);
			this.lblV6.Name = "lblV6";
			this.lblV6.Size = new System.Drawing.Size(22, 13);
			this.lblV6.TabIndex = 12;
			this.lblV6.Text = "V6";
			// 
			// txtV6
			// 
			this.txtV6.BackColor = System.Drawing.Color.Black;
			this.txtV6.ForeColor = System.Drawing.Color.Lime;
			this.txtV6.Location = new System.Drawing.Point(223, 29);
			this.txtV6.Name = "txtV6";
			this.txtV6.Size = new System.Drawing.Size(60, 20);
			this.txtV6.TabIndex = 13;
			this.txtV6.Text = "0x0000";
			// 
			// lblV5
			// 
			this.lblV5.AutoSize = true;
			this.lblV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV5.Location = new System.Drawing.Point(98, 26);
			this.lblV5.Name = "lblV5";
			this.lblV5.Size = new System.Drawing.Size(22, 13);
			this.lblV5.TabIndex = 10;
			this.lblV5.Text = "V5";
			// 
			// txtV5
			// 
			this.txtV5.BackColor = System.Drawing.Color.Black;
			this.txtV5.ForeColor = System.Drawing.Color.Lime;
			this.txtV5.Location = new System.Drawing.Point(128, 29);
			this.txtV5.Name = "txtV5";
			this.txtV5.Size = new System.Drawing.Size(60, 20);
			this.txtV5.TabIndex = 11;
			this.txtV5.Text = "0x0000";
			// 
			// lblV4
			// 
			this.lblV4.AutoSize = true;
			this.lblV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV4.Location = new System.Drawing.Point(3, 26);
			this.lblV4.Name = "lblV4";
			this.lblV4.Size = new System.Drawing.Size(22, 13);
			this.lblV4.TabIndex = 8;
			this.lblV4.Text = "V4";
			// 
			// txtV4
			// 
			this.txtV4.BackColor = System.Drawing.Color.Black;
			this.txtV4.ForeColor = System.Drawing.Color.Lime;
			this.txtV4.Location = new System.Drawing.Point(32, 29);
			this.txtV4.Name = "txtV4";
			this.txtV4.Size = new System.Drawing.Size(60, 20);
			this.txtV4.TabIndex = 9;
			this.txtV4.Text = "0x0000";
			// 
			// lblV0
			// 
			this.lblV0.AutoSize = true;
			this.lblV0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV0.Location = new System.Drawing.Point(3, 0);
			this.lblV0.Name = "lblV0";
			this.lblV0.Size = new System.Drawing.Size(22, 13);
			this.lblV0.TabIndex = 0;
			this.lblV0.Text = "V0";
			// 
			// txtV0
			// 
			this.txtV0.BackColor = System.Drawing.Color.Black;
			this.txtV0.ForeColor = System.Drawing.Color.Lime;
			this.txtV0.Location = new System.Drawing.Point(32, 3);
			this.txtV0.Name = "txtV0";
			this.txtV0.Size = new System.Drawing.Size(60, 20);
			this.txtV0.TabIndex = 1;
			this.txtV0.Text = "0x0000";
			// 
			// lblV1
			// 
			this.lblV1.AutoSize = true;
			this.lblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV1.Location = new System.Drawing.Point(98, 0);
			this.lblV1.Name = "lblV1";
			this.lblV1.Size = new System.Drawing.Size(22, 13);
			this.lblV1.TabIndex = 2;
			this.lblV1.Text = "V1";
			// 
			// txtV1
			// 
			this.txtV1.BackColor = System.Drawing.Color.Black;
			this.txtV1.ForeColor = System.Drawing.Color.Lime;
			this.txtV1.Location = new System.Drawing.Point(128, 3);
			this.txtV1.Name = "txtV1";
			this.txtV1.Size = new System.Drawing.Size(60, 20);
			this.txtV1.TabIndex = 3;
			this.txtV1.Text = "0x0000";
			// 
			// lblV2
			// 
			this.lblV2.AutoSize = true;
			this.lblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV2.Location = new System.Drawing.Point(194, 0);
			this.lblV2.Name = "lblV2";
			this.lblV2.Size = new System.Drawing.Size(22, 13);
			this.lblV2.TabIndex = 4;
			this.lblV2.Text = "V2";
			// 
			// txtV2
			// 
			this.txtV2.BackColor = System.Drawing.Color.Black;
			this.txtV2.ForeColor = System.Drawing.Color.Lime;
			this.txtV2.Location = new System.Drawing.Point(223, 3);
			this.txtV2.Name = "txtV2";
			this.txtV2.Size = new System.Drawing.Size(60, 20);
			this.txtV2.TabIndex = 5;
			this.txtV2.Text = "0x0000";
			// 
			// lblV3
			// 
			this.lblV3.AutoSize = true;
			this.lblV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblV3.Location = new System.Drawing.Point(289, 0);
			this.lblV3.Name = "lblV3";
			this.lblV3.Size = new System.Drawing.Size(22, 13);
			this.lblV3.TabIndex = 6;
			this.lblV3.Text = "V3";
			// 
			// txtV3
			// 
			this.txtV3.BackColor = System.Drawing.Color.Black;
			this.txtV3.ForeColor = System.Drawing.Color.Lime;
			this.txtV3.Location = new System.Drawing.Point(318, 3);
			this.txtV3.Name = "txtV3";
			this.txtV3.Size = new System.Drawing.Size(60, 20);
			this.txtV3.TabIndex = 7;
			this.txtV3.Text = "0x0000";
			// 
			// lblDataRegisters
			// 
			this.lblDataRegisters.AutoSize = true;
			this.lblDataRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataRegisters.Location = new System.Drawing.Point(8, 51);
			this.lblDataRegisters.Name = "lblDataRegisters";
			this.lblDataRegisters.Size = new System.Drawing.Size(116, 16);
			this.lblDataRegisters.TabIndex = 0;
			this.lblDataRegisters.Text = "Data Registers:";
			// 
			// tabMemory
			// 
			this.tabMemory.Controls.Add(this.spltMemoryContainer);
			this.tabMemory.Location = new System.Drawing.Point(4, 22);
			this.tabMemory.Name = "tabMemory";
			this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
			this.tabMemory.Size = new System.Drawing.Size(522, 284);
			this.tabMemory.TabIndex = 2;
			this.tabMemory.Text = "Memory";
			this.tabMemory.UseVisualStyleBackColor = true;
			// 
			// spltMemoryContainer
			// 
			this.spltMemoryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spltMemoryContainer.Location = new System.Drawing.Point(3, 3);
			this.spltMemoryContainer.Name = "spltMemoryContainer";
			// 
			// spltMemoryContainer.Panel1
			// 
			this.spltMemoryContainer.Panel1.Controls.Add(this.lblMemoryData);
			this.spltMemoryContainer.Panel1.Controls.Add(this.rtbMemoryBytes);
			// 
			// spltMemoryContainer.Panel2
			// 
			this.spltMemoryContainer.Panel2.Controls.Add(this.lblStackData);
			this.spltMemoryContainer.Panel2.Controls.Add(this.lstbStack);
			this.spltMemoryContainer.Size = new System.Drawing.Size(516, 278);
			this.spltMemoryContainer.SplitterDistance = 375;
			this.spltMemoryContainer.TabIndex = 0;
			// 
			// lblMemoryData
			// 
			this.lblMemoryData.AutoSize = true;
			this.lblMemoryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemoryData.Location = new System.Drawing.Point(5, 3);
			this.lblMemoryData.Name = "lblMemoryData";
			this.lblMemoryData.Size = new System.Drawing.Size(104, 16);
			this.lblMemoryData.TabIndex = 3;
			this.lblMemoryData.Text = "Memory Data:";
			// 
			// rtbMemoryBytes
			// 
			this.rtbMemoryBytes.BackColor = System.Drawing.Color.Black;
			this.rtbMemoryBytes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rtbMemoryBytes.ForeColor = System.Drawing.Color.Lime;
			this.rtbMemoryBytes.Location = new System.Drawing.Point(0, 22);
			this.rtbMemoryBytes.Name = "rtbMemoryBytes";
			this.rtbMemoryBytes.Size = new System.Drawing.Size(375, 256);
			this.rtbMemoryBytes.TabIndex = 0;
			this.rtbMemoryBytes.Text = "";
			// 
			// lblStackData
			// 
			this.lblStackData.AutoSize = true;
			this.lblStackData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStackData.Location = new System.Drawing.Point(3, 3);
			this.lblStackData.Name = "lblStackData";
			this.lblStackData.Size = new System.Drawing.Size(51, 16);
			this.lblStackData.TabIndex = 4;
			this.lblStackData.Text = "Stack:";
			// 
			// lstbStack
			// 
			this.lstbStack.BackColor = System.Drawing.Color.Black;
			this.lstbStack.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstbStack.ForeColor = System.Drawing.Color.Lime;
			this.lstbStack.FormattingEnabled = true;
			this.lstbStack.Location = new System.Drawing.Point(0, 27);
			this.lstbStack.Name = "lstbStack";
			this.lstbStack.Size = new System.Drawing.Size(137, 251);
			this.lstbStack.TabIndex = 0;
			// 
			// tabFontSet
			// 
			this.tabFontSet.Controls.Add(this.otkGLFontSet);
			this.tabFontSet.Location = new System.Drawing.Point(4, 22);
			this.tabFontSet.Name = "tabFontSet";
			this.tabFontSet.Padding = new System.Windows.Forms.Padding(3);
			this.tabFontSet.Size = new System.Drawing.Size(522, 284);
			this.tabFontSet.TabIndex = 3;
			this.tabFontSet.Text = "Font Set";
			this.tabFontSet.UseVisualStyleBackColor = true;
			// 
			// otkGLFontSet
			// 
			this.otkGLFontSet.BackColor = System.Drawing.Color.Black;
			this.otkGLFontSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.otkGLFontSet.Location = new System.Drawing.Point(3, 3);
			this.otkGLFontSet.Name = "otkGLFontSet";
			this.otkGLFontSet.Size = new System.Drawing.Size(516, 278);
			this.otkGLFontSet.TabIndex = 0;
			this.otkGLFontSet.VSync = false;
			this.otkGLFontSet.Load += new System.EventHandler(this.otkGLControl_Load);
			this.otkGLFontSet.Paint += new System.Windows.Forms.PaintEventHandler(this.otkGLControl_Paint);
			this.otkGLFontSet.Resize += new System.EventHandler(this.otkGLControl_Resize);
			// 
			// tabASM
			// 
			this.tabASM.Controls.Add(this.rtbASM);
			this.tabASM.Location = new System.Drawing.Point(4, 22);
			this.tabASM.Name = "tabASM";
			this.tabASM.Padding = new System.Windows.Forms.Padding(3);
			this.tabASM.Size = new System.Drawing.Size(522, 284);
			this.tabASM.TabIndex = 4;
			this.tabASM.Text = "Pseudo-Assembly";
			this.tabASM.UseVisualStyleBackColor = true;
			// 
			// rtbASM
			// 
			this.rtbASM.BackColor = System.Drawing.Color.Black;
			this.rtbASM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbASM.ForeColor = System.Drawing.Color.Lime;
			this.rtbASM.Location = new System.Drawing.Point(3, 3);
			this.rtbASM.Name = "rtbASM";
			this.rtbASM.Size = new System.Drawing.Size(516, 278);
			this.rtbASM.TabIndex = 0;
			this.rtbASM.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(530, 381);
			this.Controls.Add(this.tabContainer);
			this.Controls.Add(this.sbarContainer);
			this.Controls.Add(this.tbarContainer);
			this.Controls.Add(this.mnuContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chip-8";
			this.mnuContainer.ResumeLayout(false);
			this.mnuContainer.PerformLayout();
			this.tbarContainer.ResumeLayout(false);
			this.tbarContainer.PerformLayout();
			this.sbarContainer.ResumeLayout(false);
			this.sbarContainer.PerformLayout();
			this.tabContainer.ResumeLayout(false);
			this.tabGame.ResumeLayout(false);
			this.tabCPU.ResumeLayout(false);
			this.tabCPU.PerformLayout();
			this.tlpDataRegisters.ResumeLayout(false);
			this.tlpDataRegisters.PerformLayout();
			this.tabMemory.ResumeLayout(false);
			this.spltMemoryContainer.Panel1.ResumeLayout(false);
			this.spltMemoryContainer.Panel1.PerformLayout();
			this.spltMemoryContainer.Panel2.ResumeLayout(false);
			this.spltMemoryContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spltMemoryContainer)).EndInit();
			this.spltMemoryContainer.ResumeLayout(false);
			this.tabFontSet.ResumeLayout(false);
			this.tabASM.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuContainer;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStrip tbarContainer;
		private System.Windows.Forms.ToolStripButton tbarRun;
		private System.Windows.Forms.ToolStripButton tbarPause;
		private System.Windows.Forms.ToolStripButton tbarReset;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tbarDebugStepOver;
		private System.Windows.Forms.StatusStrip sbarContainer;
		private System.Windows.Forms.ToolStripStatusLabel sbarStatus;
		private System.Windows.Forms.TabControl tabContainer;
		private System.Windows.Forms.TabPage tabGame;
		private System.Windows.Forms.TabPage tabCPU;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenROM;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.TabPage tabMemory;
		private System.Windows.Forms.TabPage tabFontSet;
		private System.Windows.Forms.TabPage tabASM;
		private OpenTK.GLControl otkGLGame;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripMenuItem mnuKeyboard;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripButton tbarDebugStart;
		private System.Windows.Forms.ToolStripButton tbarDebugStop;
		private System.Windows.Forms.TextBox txtVI;
		private System.Windows.Forms.Label lblVI;
		private System.Windows.Forms.Label lblIndexRegister;
		private System.Windows.Forms.TableLayoutPanel tlpDataRegisters;
		private System.Windows.Forms.Label lblVC;
		private System.Windows.Forms.TextBox txtVC;
		private System.Windows.Forms.Label lblVD;
		private System.Windows.Forms.TextBox txtVD;
		private System.Windows.Forms.Label lblVE;
		private System.Windows.Forms.TextBox txtVE;
		private System.Windows.Forms.Label lblVF;
		private System.Windows.Forms.TextBox txtVF;
		private System.Windows.Forms.Label lblVB;
		private System.Windows.Forms.TextBox txtVB;
		private System.Windows.Forms.Label lblVA;
		private System.Windows.Forms.TextBox txtVA;
		private System.Windows.Forms.Label lblV9;
		private System.Windows.Forms.TextBox txtV9;
		private System.Windows.Forms.Label lblV8;
		private System.Windows.Forms.TextBox txtV8;
		private System.Windows.Forms.Label lblV7;
		private System.Windows.Forms.TextBox txtV7;
		private System.Windows.Forms.Label lblV6;
		private System.Windows.Forms.TextBox txtV6;
		private System.Windows.Forms.Label lblV5;
		private System.Windows.Forms.TextBox txtV5;
		private System.Windows.Forms.Label lblV4;
		private System.Windows.Forms.TextBox txtV4;
		private System.Windows.Forms.Label lblV0;
		private System.Windows.Forms.TextBox txtV0;
		private System.Windows.Forms.Label lblV1;
		private System.Windows.Forms.TextBox txtV1;
		private System.Windows.Forms.Label lblV2;
		private System.Windows.Forms.TextBox txtV2;
		private System.Windows.Forms.Label lblV3;
		private System.Windows.Forms.TextBox txtV3;
		private System.Windows.Forms.Label lblDataRegisters;
		private System.Windows.Forms.TextBox txtCpuCycles;
		private System.Windows.Forms.Label lblHertzs;
		private System.Windows.Forms.Label lblCpuCycles;
		private System.Windows.Forms.SplitContainer spltMemoryContainer;
		private System.Windows.Forms.RichTextBox rtbMemoryBytes;
		private System.Windows.Forms.ListBox lstbStack;
		private OpenTK.GLControl otkGLFontSet;
		private System.Windows.Forms.RichTextBox rtbASM;
		private System.Windows.Forms.Label lblMemoryData;
		private System.Windows.Forms.Label lblStackData;


	}
}