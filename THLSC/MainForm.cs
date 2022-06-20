using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SharpTori;

namespace THLSC
{
    public partial class MainForm : Form
    {
        private const int DELAY = 10;

        private delegate void DelUpdateInfo();
        private DelUpdateInfo UpdateInfo;
        private Dictionary<string, DelUpdateInfo> _updateInfoTable;
        private THWarper _thwarper;
        private string _id;
        private bool _closePending;

        private StreamWriter _log;

        public MainForm()
        {
            InitializeComponent();

            _thwarper = new THWarper();
            _updateInfoTable = new Dictionary<string, DelUpdateInfo>
            {
                { "th06", UpdateInfoTH06 },
                { "th07", UpdateInfoTH07 },
                { "th08", UpdateInfoTH08 },
                { "th09", UpdateInfoTH09 },
                { "th10", UpdateInfoTH10 },
                { "th11", UpdateInfoTH11 },
                { "th12", UpdateInfoTH12 },
                { "th128", UpdateInfoTH128 },
                { "th13", UpdateInfoTH13 },
                { "th14", UpdateInfoTH14 },
                { "th15", UpdateInfoTH15 },
                { "th16", UpdateInfoTH16 },
                { "th17", UpdateInfoTH17 },
                { "th18", UpdateInfoTH18 },
            };

            if (!Directory.Exists("logs"))
                Directory.CreateDirectory("logs");
            _log = new StreamWriter(string.Format("logs/thlsc-{0}.txt", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")));
            _log.WriteLine("Touhou Live Survival Calculator");
            _log.WriteLine("Version 1.0.1");
            _log.WriteLine("The time is {0}", DateTime.Now);
#if DEBUG
            _log.WriteLine("----------------------------------------------------------------");
            _log.WriteLine("Directing all console outputs to this file...");
            Console.SetOut(_log);
#endif
            _log.WriteLine("Logging system initialized successfully");
            _log.WriteLine("----------------------------------------------------------------");
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Touhou Live Survival Counter by Cao Minh\n" + 
                "Version 1.0.1\n\n" +
                "This is a tool that reads in-game information to keep track of the status of the survival run.\n" + 
                "This tool is the descendant of RealTimeDRCPointsDisplayer, with many bugs fixed and the internal works separated in the library SharpTori.\n" +
                "For the time being THLSC supports Touhou 6, 7, 8, 10, 11, 12, 12.8, 13, 14, 15, 16, 17 and 18.\n" +
                "", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Settings(object sender, EventArgs e)
        {

        }

        private void MainWork(object sender, EventArgs e)
        {
            if (!mainWorker.IsBusy)
            {
                UpdateEventWorkStarting();
                mainWorker.RunWorkerAsync();
            }
            else
            {
                mainWorker.CancelAsync();
            }
        }

        private void InitWork()
        {
            infoGame.Text = "Game: " + GameNameEn.ResourceManager.GetString(_id);
            UpdateInfo = _updateInfoTable[_id];

            // arrange cells for 3rd condition data
            tableInfoCond.Visible = true;
            switch (_id)
            {
                case "th07":
                    tableInfoCond.ColumnCount = 1;
                    infoCond1.ForeColor = Color.Violet;
                    infoCond1.Text = "Border break";
                    break;
                case "th08":
                    tableInfoCond.ColumnCount = 1;
                    infoCond1.ForeColor = Color.White;
                    infoCond1.Text = "Spell captured";
                    break;
                case "th12":
                    tableInfoCond.ColumnCount = 4;
                    infoCond1.ForeColor = Color.Red;
                    infoCond2.ForeColor = Color.Lime;
                    infoCond3.ForeColor = Color.FromArgb(255, 102, 156, 255);
                    infoCond4.ForeColor = Color.Yellow;
                    infoCond1.Text = "1";
                    infoCond2.Text = "2";
                    infoCond3.Text = "3";
                    infoCond4.Text = "4";
                    break;
                case "th128":
                    tableInfoCond.ColumnCount = 3;
                    infoCond1.ForeColor = Color.Gold;
                    infoCond2.ForeColor = Color.Silver;
                    infoCond3.ForeColor = Color.FromArgb(255, 192, 64, 0);
                    infoCond1.Text = "1";
                    infoCond2.Text = "2";
                    infoCond3.Text = "3";
                    break;
                case "th13":
                    tableInfoCond.ColumnCount = 1;
                    infoCond1.ForeColor = Color.Silver;
                    infoCond1.Text = "Trance";
                    break;
                case "th16":
                    tableInfoCond.ColumnCount = 1;
                    infoCond1.ForeColor = Color.Yellow;
                    infoCond1.Text = "Release";
                    break;
                case "th17":
                    tableInfoCond.ColumnCount = 4;
                    infoCond1.ForeColor = Color.Red;
                    infoCond2.ForeColor = Color.Lime;
                    infoCond3.ForeColor = Color.FromArgb(255, 138, 13, 255);
                    infoCond4.ForeColor = Color.Yellow;
                    infoCond1.Text = "1";
                    infoCond2.Text = "2";
                    infoCond3.Text = "3";
                    infoCond4.Text = "4";
                    break;
                default:
                    tableInfoCond.Visible = false;
                    break;
            }

            _log.WriteLine(infoGame.Text);
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Find the game
                _log.WriteLine("Finding the game process in the process list...");
                Invoke(new Action(() => _id = _thwarper.Scan()));
                if (_id == "")
                {
                    string prompt = "Game not found. Please run the game and try again.";
                    MessageBox.Show(prompt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _log.WriteLine("Error: " + prompt);
                    return;
                }

                _log.WriteLine("Initializing control for this game...");
                // Update the control
                Invoke(new Action(InitWork));

                _log.WriteLine("Displayer initialized successfully. Start reading memory...");
#if DEBUG
                _log.WriteLine("Log will now receive output from the SharpTori library.");
#endif
                // Do all memory reading works
                UpdateInfo();
            }
            catch (Exception ex)
            {
                _log.WriteLine(ex.Message);
            }
        }

        private void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateEventWorkStopped();
            // Properly dispose objects after finishing the background worker
            if (_closePending)
            {
                Close();
            }
        }

        private void UpdateEventWorkStarting()
        {
            btnTrigger.Text = "Stop";
            eventStat.ForeColor = Color.Green;
            eventStat.Text = "Status: Running";

            _log.WriteLine("The background worker is starting...");
        }

        private void UpdateEventWorkStopped()
        {
            btnTrigger.Text = "Start";
            eventStat.ForeColor = Color.Red;
            eventStat.Text = "Status: Not Running";

            _log.WriteLine("The background worker has stopped.");
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _log.WriteLine("Application closing event has been raised.");
            if (mainWorker.IsBusy)
            {
                _log.WriteLine("Attempting to stop the background worker...");
                _closePending = true;
                e.Cancel = true;
                mainWorker.CancelAsync();
            }
            else
            {
                _log.WriteLine("Attempting to close this file...");
                _log.Close();
            }
        }

        //
        // delegate functions
        //

        private void UpdateInfoTH06()
        {
            TH06 th06 = (TH06)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa" };
            string[] subShotList = new string[] { "A", "B" };
            
            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th06.IsInGame())
                    continue;

                if (th06.IsNewGame())
                    th06.Reset();

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[th06.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th06.GetMainShot()] + subShotList[th06.GetSubShot()];
                    infoMiss.Text = "Miss: " + th06.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th06.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH07()
        {
            TH07 th07 = (TH07)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra", "Phantasm" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sakuya" };
            string[] subShotList = new string[] { "A", "B" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th07.IsInGame())
                    continue;

                if (th07.IsNewGame())
                    th07.Reset();

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[th07.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th07.GetMainShot()] + subShotList[th07.GetSubShot()];
                    infoMiss.Text = "Miss: " + th07.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th07.GetBombCount().ToString();
                    infoCond1.Text = "Border break: " + th07.GetBorderBreakCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH08()
        {
            TH08 th08 = (TH08)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Border Team", "Magic Team", "Scarlet Team", "Ghost Team",
                "Solo Reimu", "Solo Yukari", "Solo Marisa", "Solo Alice", "Solo Sakuya", "Solo Remilia", "Solo Youmu", "Solo Yuyuko" };
            byte difficulty, stage;
            int? totalSpells;

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th08.IsInGame())
                    continue;

                if (th08.IsNewGame())
                    th08.Reset();

                difficulty = th08.GetDifficulty();
                stage = th08.GetStage();
                if (difficulty == 4) // Extra
                    totalSpells = 14;
                else if (stage == 6) // 6A
                    totalSpells = (difficulty == 0) ? 28 : 33; // Easy mode has 5 fewer spells
                else if (stage == 7) // 6B
                    totalSpells = (difficulty == 0) ? 32 : 37; // Easy mode has 5 fewer spells
                else
                    totalSpells = null;

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[difficulty];
                    infoShot.Text = "Shottype: " + mainShotList[th08.GetMainShot()];
                    infoMiss.Text = "Miss: " + th08.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th08.GetBombCount().ToString();
                    infoCond1.Text = "Spell captured: " + th08.GetSpellCapturedCount().ToString() + "/" + ((totalSpells != null) ? totalSpells : "?");
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH09()
        {
            TH09 th09 = (TH09)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sakuya", "Youmu", "Reisen", "Cirno", "Lyrica", "Mystia",
                "Tewi", "Yuuka", "Aya", "Medicine", "Komachi", "Eiki", "Merlin", "Lunasa" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th09.IsInGame())
                    continue;

                if (th09.IsNewGame())
                    th09.Reset();

                Invoke(new Action(() =>
                {
                    /*
                    infoDiff.Text = difficultyList[th09.GetDifficulty()];
                    infoShot.Text = mainShotList[th09.GetMainShot()];
                    infoMiss.Text = th09.GetMissCount().ToString();
                    infoBomb.Text = th09.GetBombCount().ToString();
                    */
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH10()
        {
            TH10 th10 = (TH10)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa" };
            string[] subShotList = new string[] { "A", "B", "C" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th10.IsInGame())
                    continue;

                if (th10.IsNewGame())
                    th10.Reset();

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[th10.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th10.GetMainShot()] + subShotList[th10.GetSubShot()];
                    infoMiss.Text = "Miss: " + th10.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th10.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH11()
        {
            TH11 th11 = (TH11)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa" };
            string[] subShotList = new string[] { "A", "B", "C" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th11.IsInGame())
                    continue;

                if (th11.IsNewGame())
                    th11.Reset();

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[th11.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th11.GetMainShot()] + subShotList[th11.GetSubShot()];
                    infoMiss.Text = "Miss: " + th11.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th11.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH12()
        {
            TH12 th12 = (TH12)_thwarper.Game;
            TH12.UFOCount ufoCount;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sanae" };
            string[] subShotList = new string[] { "A", "B" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th12.IsInGame())
                    continue;

                if (th12.IsNewGame())
                    th12.Reset();

                Invoke(new Action(() =>
                {
                    infoDiff.Text = "Difficulty: " + difficultyList[th12.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th12.GetMainShot()] + subShotList[th12.GetSubShot()];
                    infoMiss.Text = "Miss: " + th12.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th12.GetBombCount().ToString();
                    ufoCount = th12.GetUFOCount();
                    infoCond1.Text = ufoCount.Red.ToString();
                    infoCond2.Text = ufoCount.Green.ToString();
                    infoCond3.Text = ufoCount.Blue.ToString();
                    infoCond4.Text = ufoCount.Rainbow.ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH128()
        {
            TH128 th128 = (TH128)_thwarper.Game;
            TH128.MedalCount medalCount;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] routeList = { "-", "A1", "A1", "A1", "A2", "A2", "B1", "B1", "B1", "B2", "B2", "C1", "C1", "C1", "C2", "C2", "Extra" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th128.IsInGame())
                    continue;

                if (th128.IsNewGame())
                    th128.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th128.GetDifficulty()];
                    infoShot.Text = "Route: " + routeList[th128.GetStage()];
                    infoMiss.Text = "Miss: " + th128.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th128.GetBombCount().ToString();
                    medalCount = th128.GetMedalCount();
                    infoCond1.Text = "G: " + medalCount.Gold.ToString();
                    infoCond2.Text = "S: " + medalCount.Silver.ToString();
                    infoCond3.Text = "B: " + medalCount.Bronze.ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH13()
        {
            TH13 th13 = (TH13)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra", "Overdrive" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sanae", "Youmu" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th13.IsInGame())
                    continue;

                if (th13.IsNewGame())
                    th13.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th13.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th13.GetMainShot()];
                    infoMiss.Text = "Miss: " + th13.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th13.GetBombCount().ToString();
                    infoCond1.Text = "Trance: " + th13.GetTranceCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH14()
        {
            TH14 th14 = (TH14)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Maisa", "Sakuya" };
            string[] subShotList = new string[] { "A", "B" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th14.IsInGame())
                    continue;

                if (th14.IsNewGame())
                    th14.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th14.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th14.GetMainShot()] + subShotList[th14.GetSubShot()];
                    infoMiss.Text = "Miss: " + th14.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th14.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH15()
        {
            TH15 th15 = (TH15)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sanae", "Reisen" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th15.IsInGame())
                    continue;

                if (th15.IsNewGame())
                    th15.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th15.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th15.GetMainShot()];
                    infoMiss.Text = "Miss: " + th15.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th15.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH16()
        {
            TH16 th16 = (TH16)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Cirno", "Aya", "Marisa" };
            string[] subShotList = new string[] { "Spring", "Summer", "Autumn", "Winter" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th16.IsInGame())
                    continue;

                if (th16.IsNewGame())
                    th16.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th16.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th16.GetMainShot()] + subShotList[th16.GetSubShot()];
                    infoMiss.Text = "Miss: " + th16.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th16.GetBombCount().ToString();
                    infoCond1.Text = "Release: " + th16.GetReleaseCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH17()
        {
            TH17 th17 = (TH17)_thwarper.Game;
            TH17.HyperCount hyperCount;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Youmu" };
            string[] subShotList = new string[] { "Wolf", "Otter", "Eagle" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th17.IsInGame())
                    continue;

                if (th17.IsNewGame())
                    th17.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th17.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th17.GetMainShot()] + subShotList[th17.GetSubShot()];
                    infoMiss.Text = "Miss: " + th17.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th17.GetBombCount().ToString();
                    hyperCount = th17.GetHyperCount();
                    infoCond1.Text = hyperCount.Wolf.ToString();
                    infoCond2.Text = hyperCount.Otter.ToString();
                    infoCond3.Text = hyperCount.Eagle.ToString();
                    infoCond4.Text = hyperCount.Break.ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }

        private void UpdateInfoTH18()
        {
            TH18 th18 = (TH18)_thwarper.Game;
            string[] difficultyList = new string[] { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
            string[] mainShotList = new string[] { "Reimu", "Marisa", "Sakuya", "Sanae" };

            while (_thwarper.IsRunning)
            {
                if (mainWorker.CancellationPending)
                    break;

                if (!th18.IsInGame())
                    continue;

                if (th18.IsNewGame())
                    th18.Reset();

                Invoke(new Action(() => {
                    infoDiff.Text = "Difficulty: " + difficultyList[th18.GetDifficulty()];
                    infoShot.Text = "Shottype: " + mainShotList[th18.GetMainShot()];
                    infoMiss.Text = "Miss: " + th18.GetMissCount().ToString();
                    infoBomb.Text = "Bomb: " + th18.GetBombCount().ToString();
                }));

                Thread.Sleep(DELAY);
            }
        }
    }
}
