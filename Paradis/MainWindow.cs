using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paradis
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs args)
        {
            // Init Render APIs
            RenderApiSrcs.Add(RenderApi.D3D9);
            RenderApiSrcs.Add(RenderApi.D3D11);
            RenderApiSrcs.Add(RenderApi.OpenGL);
            RenderApiBox.Refresh();

            // Update Program Information Label
            InformationLbl.Text = string.Format(InformationLbl.Text, Environment.OSVersion.VersionString, Constants.PlatformArch, Constants.AppVersion);
            InformationLbl.Refresh();

            // Set Initial Video Mode
            System.Drawing.Rectangle videoMode = Screen.PrimaryScreen.Bounds;
            WidthFld.Value = videoMode.Width;
            HeightFld.Value = videoMode.Height;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Constants.HttpClient.Value.Dispose();
        }

        private void LogInfo(string message)
        {
            AppendToLog($"[INFO] {message}");
        }

        private void LogWarning(string warning)
        {
            AppendToLog($"[WARN] {warning}");
        }

        private void LogError(string error)
        {
            AppendToLog($"[ERR] {error}");
        }

        private void AppendToLog(string message)
        {
            SetLogText($"{LogBox.Text}{message}\n");
        }

        private void SetLogText(string message)
        {
            LogBox.Text = message;
        }

        private void StartGame(bool clearLog)
        {
            if (clearLog)
            {
                SetLogText("Starting AoTTG\n");
            }
            else
            {
                LogInfo("Starting AoTTG");
            }

            LogInfo($"Width: {WidthFld.Value}");
            LogInfo($"Height: {HeightFld.Value}");
            LogInfo($"Fullscreen {FullScreenOpt.Checked}");
            LogInfo($"Rendering API: {RenderApiBox.SelectedItem}");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "Guardian.exe",
                    WorkingDirectory = Constants.InstallDirectory,
                    Arguments = string.Format("-screen-width {0} -screen-height {1} -screen-fullscreen {2} {3}",
                        WidthFld.Value, HeightFld.Value, FullScreenOpt.Checked ? 1 : 0, ((RenderApi)RenderApiBox.SelectedItem).Command)
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                LogInfo("Fetching latest build information");
                await FetchVersionData();

                LogInfo("Creating client install directory");
                if (!CreateClientDirectory()) return;

                LogInfo($"Downloading client for {Constants.PlatformArch}-bit Windows");
                FileInfo clientFile = new FileInfo(Path.Combine(Constants.WorkingDirectory, Constants.BinaryName));
                byte[] clientData = await DownloadGame();
                if (clientData.Length == 0) return;
                if (!await WriteGameData(clientFile, clientData)) return;

                LogInfo($"Extracting {clientFile.FullName} to {Constants.InstallDirectory}");
                ExtractToDirectory(clientFile);

                LogInfo("Cleaning up");
                CleanUp(clientFile);

                if (AutoPlayAfterUpdateOpt.Checked) StartGame(false);
            });
        }

        private async Task FetchVersionData()
        {
            try
            {
                string data = await Constants.HttpClient.Value.GetStringAsync($"{Constants.VersionUrl}?t={Environment.TickCount}");
                LogInfo($"\n{data}");

                foreach (string buildData in data.Split('\n'))
                {
                    string[] buildInfo = buildData.Split(new char[] { '=' }, 2);
                    if (!buildInfo[0].Equals("LAUNCHER")) continue;

                    string latestBuild = buildInfo[1].Trim();
                    if (latestBuild.Equals(Constants.AppVersion)) break;

                    LogWarning("Your copy of Paradis is OUT OF DATE, please UPDATE!");
                    LogWarning("\t- https://aottg.winnpixie.com/");
                }
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
            }
        }

        private bool CreateClientDirectory()
        {
            DirectoryInfo clientDir = new DirectoryInfo(Constants.InstallDirectory);
            if (!clientDir.Exists)
            {
                try
                {
                    clientDir.Create();
                }
                catch (Exception ex)
                {
                    LogError(ex.ToString());
                    return false;
                }
            }

            return true;
        }

        private async Task<byte[]> DownloadGame()
        {
            try
            {
                return await Constants.HttpClient.Value.GetByteArrayAsync($"{Constants.BinaryUrl}?t=" + Environment.TickCount);
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
                return new byte[0];
            }
        }

        private async Task<bool> WriteGameData(FileInfo file, byte[] data)
        {
            try
            {
                using (FileStream fs = file.OpenWrite()) await fs.WriteAsync(data, 0, data.Length);
                return true;
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
                return false;
            }
        }

        private void ExtractToDirectory(FileInfo file)
        {
            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(file.FullName))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string path = Path.Combine(Constants.InstallDirectory, entry.FullName);
                        if (path.EndsWith("\\") || path.EndsWith("/"))
                        {
                            DirectoryInfo di = new DirectoryInfo(path.Substring(0, path.Length - 1));
                            di.Create();
                        }
                        else
                        {
                            LogInfo($"Extracting {entry.FullName}");
                            entry.ExtractToFile(path, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
            }
        }

        private void CleanUp(FileInfo file)
        {
            try
            {
                file.Delete();
            }
            catch (Exception ex)
            {
                LogError(ex.ToString());
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            StartGame(true);
        }
    }
}
