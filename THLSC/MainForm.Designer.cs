
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
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableBtn1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableBtn2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableBtn1.SuspendLayout();
            this.tableBtn2.SuspendLayout();
            this.tableInfoPrimary.SuspendLayout();
            this.tableInfoGame.SuspendLayout();
            this.tableInfoDiff.SuspendLayout();
            this.tableInfoShot.SuspendLayout();
            this.tableInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttach.Location = new System.Drawing.Point(0, 4);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(322, 25);
            this.btnAttach.TabIndex = 1;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.Attach);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Location = new System.Drawing.Point(0, 3);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(158, 25);
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
            this.btnAbout.Location = new System.Drawing.Point(164, 3);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(158, 25);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.About);
            // 
            // tableBtn1
            // 
            this.tableBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableBtn1.ColumnCount = 1;
            this.tableBtn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBtn1.Controls.Add(this.btnAttach, 0, 0);
            this.tableBtn1.Location = new System.Drawing.Point(12, 265);
            this.tableBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.tableBtn1.Name = "tableBtn1";
            this.tableBtn1.RowCount = 1;
            this.tableBtn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBtn1.Size = new System.Drawing.Size(322, 32);
            this.tableBtn1.TabIndex = 4;
            // 
            // tableBtn2
            // 
            this.tableBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableBtn2.ColumnCount = 2;
            this.tableBtn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBtn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBtn2.Controls.Add(this.btnSettings, 0, 0);
            this.tableBtn2.Controls.Add(this.btnAbout, 1, 0);
            this.tableBtn2.Location = new System.Drawing.Point(12, 296);
            this.tableBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.tableBtn2.Name = "tableBtn2";
            this.tableBtn2.RowCount = 1;
            this.tableBtn2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBtn2.Size = new System.Drawing.Size(322, 31);
            this.tableBtn2.TabIndex = 5;
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
            this.tableInfo.Size = new System.Drawing.Size(322, 250);
            this.tableInfo.TabIndex = 9;
            // 
            // tableInfoCond
            // 
            this.tableInfoCond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoCond.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInfoCond.ColumnCount = 1;
            this.tableInfoCond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoCond.Location = new System.Drawing.Point(0, 200);
            this.tableInfoCond.Margin = new System.Windows.Forms.Padding(0);
            this.tableInfoCond.Name = "tableInfoCond";
            this.tableInfoCond.RowCount = 1;
            this.tableInfoCond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInfoCond.Size = new System.Drawing.Size(322, 50);
            this.tableInfoCond.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 336);
            this.Controls.Add(this.tableInfo);
            this.Controls.Add(this.tableBtn2);
            this.Controls.Add(this.tableBtn1);
            this.MinimumSize = new System.Drawing.Size(362, 375);
            this.Name = "MainForm";
            this.Text = "Touhou Live Survival Counter";
            this.tableBtn1.ResumeLayout(false);
            this.tableBtn2.ResumeLayout(false);
            this.tableInfoPrimary.ResumeLayout(false);
            this.tableInfoGame.ResumeLayout(false);
            this.tableInfoDiff.ResumeLayout(false);
            this.tableInfoShot.ResumeLayout(false);
            this.tableInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TableLayoutPanel tableBtn1;
        private System.Windows.Forms.TableLayoutPanel tableBtn2;
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
    }
}

