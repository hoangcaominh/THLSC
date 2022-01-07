
namespace THLSC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableEventBtn1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableEventBtn2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableInfoPrimary = new System.Windows.Forms.TableLayoutPanel();
            this.infoMiss = new System.Windows.Forms.Label();
            this.infoBomb = new System.Windows.Forms.Label();
            this.tableInfoGame = new System.Windows.Forms.TableLayoutPanel();
            this.infoGame = new System.Windows.Forms.Label();
            this.tableInfoDiff = new System.Windows.Forms.TableLayoutPanel();
            this.infoDiff = new System.Windows.Forms.Label();
            this.tableInfoShot = new System.Windows.Forms.TableLayoutPanel();
            this.infoShot = new System.Windows.Forms.Label();
            this.tableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tableInfoCond = new System.Windows.Forms.TableLayoutPanel();
            this.infoCond4 = new System.Windows.Forms.Label();
            this.infoCond3 = new System.Windows.Forms.Label();
            this.infoCond2 = new System.Windows.Forms.Label();
            this.infoCond1 = new System.Windows.Forms.Label();
            this.mainWorker = new System.ComponentModel.BackgroundWorker();
            this.tableEvent = new System.Windows.Forms.TableLayoutPanel();
            this.tableEventStat = new System.Windows.Forms.TableLayoutPanel();
            this.eventStat = new System.Windows.Forms.Label();
            this.tableEventBtn1.SuspendLayout();
            this.tableEventBtn2.SuspendLayout();
            this.tableInfoPrimary.SuspendLayout();
            this.tableInfoGame.SuspendLayout();
            this.tableInfoDiff.SuspendLayout();
            this.tableInfoShot.SuspendLayout();
            this.tableInfo.SuspendLayout();
            this.tableInfoCond.SuspendLayout();
            this.tableEvent.SuspendLayout();
            this.tableEventStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrigger
            // 
            this.btnTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrigger.Location = new System.Drawing.Point(0, 3);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(320, 24);
            this.btnTrigger.TabIndex = 1;
            this.btnTrigger.Text = "Start";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.MainWork);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Enabled = false;
            this.btnSettings.Location = new System.Drawing.Point(0, 3);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(157, 25);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.Settings);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.Location = new System.Drawing.Point(163, 3);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(157, 25);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.About);
            // 
            // tableEventBtn1
            // 
            this.tableEventBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEventBtn1.ColumnCount = 1;
            this.tableEventBtn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEventBtn1.Controls.Add(this.btnTrigger, 0, 0);
            this.tableEventBtn1.Location = new System.Drawing.Point(0, 29);
            this.tableEventBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.tableEventBtn1.Name = "tableEventBtn1";
            this.tableEventBtn1.RowCount = 1;
            this.tableEventBtn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEventBtn1.Size = new System.Drawing.Size(320, 30);
            this.tableEventBtn1.TabIndex = 4;
            // 
            // tableEventBtn2
            // 
            this.tableEventBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEventBtn2.ColumnCount = 2;
            this.tableEventBtn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEventBtn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEventBtn2.Controls.Add(this.btnSettings, 0, 0);
            this.tableEventBtn2.Controls.Add(this.btnAbout, 1, 0);
            this.tableEventBtn2.Location = new System.Drawing.Point(0, 59);
            this.tableEventBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.tableEventBtn2.Name = "tableEventBtn2";
            this.tableEventBtn2.RowCount = 1;
            this.tableEventBtn2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEventBtn2.Size = new System.Drawing.Size(320, 31);
            this.tableEventBtn2.TabIndex = 5;
            // 
            // tableInfoPrimary
            // 
            this.tableInfoPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoPrimary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoPrimary.ColumnCount = 2;
            this.tableInfoPrimary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoPrimary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoPrimary.Controls.Add(this.infoMiss, 0, 0);
            this.tableInfoPrimary.Controls.Add(this.infoBomb, 1, 0);
            this.tableInfoPrimary.Location = new System.Drawing.Point(0, 150);
            this.tableInfoPrimary.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoPrimary.Name = "tableInfoPrimary";
            this.tableInfoPrimary.RowCount = 1;
            this.tableInfoPrimary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoPrimary.Size = new System.Drawing.Size(322, 50);
            this.tableInfoPrimary.TabIndex = 10;
            // 
            // infoMiss
            // 
            this.infoMiss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoMiss.BackColor = System.Drawing.Color.Transparent;
            this.infoMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoMiss.ForeColor = System.Drawing.Color.Magenta;
            this.infoMiss.Location = new System.Drawing.Point(1, 1);
            this.infoMiss.Margin = new System.Windows.Forms.Padding(0);
            this.infoMiss.Name = "infoMiss";
            this.infoMiss.Size = new System.Drawing.Size(159, 48);
            this.infoMiss.TabIndex = 5;
            this.infoMiss.Text = "Miss";
            this.infoMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoBomb
            // 
            this.infoBomb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBomb.BackColor = System.Drawing.Color.Transparent;
            this.infoBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoBomb.ForeColor = System.Drawing.Color.Lime;
            this.infoBomb.Location = new System.Drawing.Point(161, 1);
            this.infoBomb.Margin = new System.Windows.Forms.Padding(0);
            this.infoBomb.Name = "infoBomb";
            this.infoBomb.Size = new System.Drawing.Size(160, 48);
            this.infoBomb.TabIndex = 6;
            this.infoBomb.Text = "Bomb";
            this.infoBomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableInfoGame
            // 
            this.tableInfoGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoGame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoGame.ColumnCount = 1;
            this.tableInfoGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoGame.Controls.Add(this.infoGame, 0, 0);
            this.tableInfoGame.Location = new System.Drawing.Point(0, 0);
            this.tableInfoGame.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoGame.Name = "tableInfoGame";
            this.tableInfoGame.RowCount = 1;
            this.tableInfoGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoGame.Size = new System.Drawing.Size(322, 50);
            this.tableInfoGame.TabIndex = 11;
            // 
            // infoGame
            // 
            this.infoGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGame.BackColor = System.Drawing.Color.Transparent;
            this.infoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoGame.ForeColor = System.Drawing.Color.White;
            this.infoGame.Location = new System.Drawing.Point(1, 1);
            this.infoGame.Margin = new System.Windows.Forms.Padding(0);
            this.infoGame.Name = "infoGame";
            this.infoGame.Size = new System.Drawing.Size(320, 48);
            this.infoGame.TabIndex = 2;
            this.infoGame.Text = "Game";
            this.infoGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableInfoDiff
            // 
            this.tableInfoDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoDiff.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoDiff.ColumnCount = 1;
            this.tableInfoDiff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoDiff.Controls.Add(this.infoDiff, 0, 0);
            this.tableInfoDiff.Location = new System.Drawing.Point(0, 50);
            this.tableInfoDiff.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoDiff.Name = "tableInfoDiff";
            this.tableInfoDiff.RowCount = 1;
            this.tableInfoDiff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoDiff.Size = new System.Drawing.Size(322, 50);
            this.tableInfoDiff.TabIndex = 11;
            // 
            // infoDiff
            // 
            this.infoDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDiff.BackColor = System.Drawing.Color.Transparent;
            this.infoDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoDiff.ForeColor = System.Drawing.Color.White;
            this.infoDiff.Location = new System.Drawing.Point(1, 1);
            this.infoDiff.Margin = new System.Windows.Forms.Padding(0);
            this.infoDiff.Name = "infoDiff";
            this.infoDiff.Size = new System.Drawing.Size(320, 48);
            this.infoDiff.TabIndex = 3;
            this.infoDiff.Text = "Difficulty";
            this.infoDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableInfoShot
            // 
            this.tableInfoShot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoShot.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoShot.ColumnCount = 1;
            this.tableInfoShot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoShot.Controls.Add(this.infoShot, 0, 0);
            this.tableInfoShot.Location = new System.Drawing.Point(0, 100);
            this.tableInfoShot.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoShot.Name = "tableInfoShot";
            this.tableInfoShot.RowCount = 1;
            this.tableInfoShot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoShot.Size = new System.Drawing.Size(322, 50);
            this.tableInfoShot.TabIndex = 12;
            // 
            // infoShot
            // 
            this.infoShot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoShot.BackColor = System.Drawing.Color.Transparent;
            this.infoShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoShot.ForeColor = System.Drawing.Color.White;
            this.infoShot.Location = new System.Drawing.Point(1, 1);
            this.infoShot.Margin = new System.Windows.Forms.Padding(0);
            this.infoShot.Name = "infoShot";
            this.infoShot.Size = new System.Drawing.Size(320, 48);
            this.infoShot.TabIndex = 4;
            this.infoShot.Text = "Shottype";
            this.infoShot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableInfo
            // 
            this.tableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfo.BackColor = System.Drawing.Color.Black;
            this.tableInfo.ColumnCount = 1;
            this.tableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInfo.Controls.Add(this.tableInfoShot, 0, 2);
            this.tableInfo.Controls.Add(this.tableInfoDiff, 0, 1);
            this.tableInfo.Controls.Add(this.tableInfoGame, 0, 0);
            this.tableInfo.Controls.Add(this.tableInfoPrimary, 0, 3);
            this.tableInfo.Controls.Add(this.tableInfoCond, 0, 4);
            this.tableInfo.Location = new System.Drawing.Point(12, 12);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.RowCount = 5;
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInfo.Size = new System.Drawing.Size(322, 250);
            this.tableInfo.TabIndex = 9;
            // 
            // tableInfoCond
            // 
            this.tableInfoCond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoCond.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoCond.ColumnCount = 4;
            this.tableInfoCond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInfoCond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInfoCond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInfoCond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInfoCond.Controls.Add(this.infoCond4, 3, 0);
            this.tableInfoCond.Controls.Add(this.infoCond3, 2, 0);
            this.tableInfoCond.Controls.Add(this.infoCond2, 1, 0);
            this.tableInfoCond.Controls.Add(this.infoCond1, 0, 0);
            this.tableInfoCond.Location = new System.Drawing.Point(0, 200);
            this.tableInfoCond.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoCond.Name = "tableInfoCond";
            this.tableInfoCond.RowCount = 1;
            this.tableInfoCond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInfoCond.Size = new System.Drawing.Size(322, 50);
            this.tableInfoCond.TabIndex = 13;
            // 
            // infoCond4
            // 
            this.infoCond4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCond4.BackColor = System.Drawing.Color.Transparent;
            this.infoCond4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoCond4.ForeColor = System.Drawing.Color.White;
            this.infoCond4.Location = new System.Drawing.Point(241, 1);
            this.infoCond4.Margin = new System.Windows.Forms.Padding(0);
            this.infoCond4.Name = "infoCond4";
            this.infoCond4.Size = new System.Drawing.Size(80, 48);
            this.infoCond4.TabIndex = 11;
            this.infoCond4.Text = "4";
            this.infoCond4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoCond3
            // 
            this.infoCond3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCond3.BackColor = System.Drawing.Color.Transparent;
            this.infoCond3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoCond3.ForeColor = System.Drawing.Color.White;
            this.infoCond3.Location = new System.Drawing.Point(161, 1);
            this.infoCond3.Margin = new System.Windows.Forms.Padding(0);
            this.infoCond3.Name = "infoCond3";
            this.infoCond3.Size = new System.Drawing.Size(79, 48);
            this.infoCond3.TabIndex = 11;
            this.infoCond3.Text = "3";
            this.infoCond3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoCond2
            // 
            this.infoCond2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCond2.BackColor = System.Drawing.Color.Transparent;
            this.infoCond2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoCond2.ForeColor = System.Drawing.Color.White;
            this.infoCond2.Location = new System.Drawing.Point(81, 1);
            this.infoCond2.Margin = new System.Windows.Forms.Padding(0);
            this.infoCond2.Name = "infoCond2";
            this.infoCond2.Size = new System.Drawing.Size(79, 48);
            this.infoCond2.TabIndex = 11;
            this.infoCond2.Text = "2";
            this.infoCond2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoCond1
            // 
            this.infoCond1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCond1.BackColor = System.Drawing.Color.Transparent;
            this.infoCond1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoCond1.ForeColor = System.Drawing.Color.White;
            this.infoCond1.Location = new System.Drawing.Point(1, 1);
            this.infoCond1.Margin = new System.Windows.Forms.Padding(0);
            this.infoCond1.Name = "infoCond1";
            this.infoCond1.Size = new System.Drawing.Size(79, 48);
            this.infoCond1.TabIndex = 10;
            this.infoCond1.Text = "1";
            this.infoCond1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainWorker
            // 
            this.mainWorker.WorkerSupportsCancellation = true;
            this.mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoWork);
            this.mainWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkCompleted);
            // 
            // tableEvent
            // 
            this.tableEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEvent.ColumnCount = 1;
            this.tableEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEvent.Controls.Add(this.tableEventStat, 0, 0);
            this.tableEvent.Controls.Add(this.tableEventBtn1, 0, 1);
            this.tableEvent.Controls.Add(this.tableEventBtn2, 0, 2);
            this.tableEvent.Location = new System.Drawing.Point(13, 268);
            this.tableEvent.Name = "tableEvent";
            this.tableEvent.RowCount = 3;
            this.tableEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableEvent.Size = new System.Drawing.Size(320, 90);
            this.tableEvent.TabIndex = 10;
            // 
            // tableEventStat
            // 
            this.tableEventStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEventStat.ColumnCount = 1;
            this.tableEventStat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEventStat.Controls.Add(this.eventStat, 0, 0);
            this.tableEventStat.Location = new System.Drawing.Point(0, 0);
            this.tableEventStat.Margin = new System.Windows.Forms.Padding(0);
            this.tableEventStat.Name = "tableEventStat";
            this.tableEventStat.RowCount = 1;
            this.tableEventStat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEventStat.Size = new System.Drawing.Size(320, 29);
            this.tableEventStat.TabIndex = 11;
            // 
            // eventStat
            // 
            this.eventStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventStat.AutoSize = true;
            this.eventStat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventStat.ForeColor = System.Drawing.Color.Red;
            this.eventStat.Location = new System.Drawing.Point(0, 0);
            this.eventStat.Margin = new System.Windows.Forms.Padding(0);
            this.eventStat.Name = "eventStat";
            this.eventStat.Size = new System.Drawing.Size(320, 29);
            this.eventStat.TabIndex = 0;
            this.eventStat.Text = "Status: Not Running";
            this.eventStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 370);
            this.Controls.Add(this.tableEvent);
            this.Controls.Add(this.tableInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(362, 375);
            this.Name = "MainForm";
            this.Text = "Touhou Live Survival Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.tableEventBtn1.ResumeLayout(false);
            this.tableEventBtn2.ResumeLayout(false);
            this.tableInfoPrimary.ResumeLayout(false);
            this.tableInfoGame.ResumeLayout(false);
            this.tableInfoDiff.ResumeLayout(false);
            this.tableInfoShot.ResumeLayout(false);
            this.tableInfo.ResumeLayout(false);
            this.tableInfoCond.ResumeLayout(false);
            this.tableEvent.ResumeLayout(false);
            this.tableEventStat.ResumeLayout(false);
            this.tableEventStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TableLayoutPanel tableEventBtn1;
        private System.Windows.Forms.TableLayoutPanel tableEventBtn2;
        private System.Windows.Forms.TableLayoutPanel tableInfoPrimary;
        private System.Windows.Forms.Label infoMiss;
        private System.Windows.Forms.Label infoBomb;
        private System.Windows.Forms.TableLayoutPanel tableInfoGame;
        private System.Windows.Forms.Label infoGame;
        private System.Windows.Forms.TableLayoutPanel tableInfoDiff;
        private System.Windows.Forms.Label infoDiff;
        private System.Windows.Forms.TableLayoutPanel tableInfoShot;
        private System.Windows.Forms.Label infoShot;
        private System.Windows.Forms.TableLayoutPanel tableInfo;
        private System.Windows.Forms.TableLayoutPanel tableInfoCond;
        private System.ComponentModel.BackgroundWorker mainWorker;
        private System.Windows.Forms.Label infoCond4;
        private System.Windows.Forms.Label infoCond3;
        private System.Windows.Forms.Label infoCond2;
        private System.Windows.Forms.Label infoCond1;
        private System.Windows.Forms.TableLayoutPanel tableEvent;
        private System.Windows.Forms.TableLayoutPanel tableEventStat;
        private System.Windows.Forms.Label eventStat;
    }
}

