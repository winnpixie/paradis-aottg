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
            RenderApiSrcs.Add(RenderApi.D3D9);
            RenderApiSrcs.Add(RenderApi.D3D11);
            RenderApiSrcs.Add(RenderApi.OpenGL);
            RenderApiBox.Refresh();

            InformationLbl.Text = string.Format(InformationLbl.Text, Environment.OSVersion.VersionString, Constants.OSArch, Constants.AppVersion);
            InformationLbl.Refresh();

            LogBox.AutoWordSelection = true;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Constants.Web.Value.Dispose();
        }

        private void SetLogText(string message)
        {
            LogBox.Text = message;
        }

        private void AppendToLog(string message)
        {
            LogBox.Text += message;
        }

        private void StartGame(bool clearLog)
        {
            try
            {
                if (clearLog)
                {
                    SetLogText("Starting Guardian...");
                }
                else
                {
                    AppendToLog("Starting Guardian...");
                }


                ProcessStartInfo psi = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "Guardian.exe",
                    WorkingDirectory = Constants.InstallDir
                };

                psi.Arguments = string.Format("-screen-width {0} -screen-height {1} -screen-fullscreen {2} {3}",
                    WidthFld.Value, HeightFld.Value, FullScreenOpt.Checked ? 1 : 0, ((RenderApi)RenderApiBox.SelectedItem).Command);

                Process.Start(psi);
                AppendToLog("\n");

                AppendToLog($"Width: {WidthFld.Value}\n");
                AppendToLog($"Height: {HeightFld.Value}\n");
                AppendToLog($"Fullscreen {FullScreenOpt.Checked}\n");
                AppendToLog($"Rendering API: {RenderApiBox.SelectedItem}\n");
            }
            catch (Exception ex)
            {
                AppendToLog($"\n\n{ex}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SetLogText("!! PLEASE MAKE SURE GUARDIAN MOD IS NOT OPEN !!\n");

            Task.Run(async () =>
            {
                // Download and display build information
                try
                {
                    AppendToLog("\nObtaining latest build information...");

                    string versionData = await GetVersionData();
                    AppendToLog($"\n{versionData}");

                    foreach (string buildData in versionData.Split('\n'))
                    {
                        string[] buildInfo = buildData.Split(new char[] { '=' }, 2);
                        if (!buildInfo[0].Equals("LAUNCHER")) continue;

                        string latestBuild = buildInfo[1].Trim();
                        if (latestBuild.Equals(Constants.AppVersion)) break;

                        AppendToLog("\nYour copy of Paradis is OUT OF DATE, please UPDATE!");
                        AppendToLog("\n\t- https://aottg.winnpixie.com/");
                    }
                }
                catch (Exception ex)
                {
                    AppendToLog($"!! WARNING !! Could not obtain build information!\n\n{ex}\n");
                }

                // Download zipped client
                byte[] zippedClientData;
                try
                {
                    AppendToLog($"\nDownloading client for {Constants.OSArch}-bit Windows...");
                    zippedClientData = await GetGameData();
                }
                catch (Exception ex)
                {
                    SetLogText($"!! ERROR !! Could not download client data!\n\n{ex}");
                    return;
                }

                // Write zipped client data to local file
                FileInfo zippedClientFile = new FileInfo(Constants.InstallDir + $"\\{Constants.BinaryName}");
                try
                {
                    await WriteGameData(zippedClientFile, zippedClientData);
                }
                catch (Exception ex)
                {
                    SetLogText($"!! ERROR !! Could not save client data!\n\n{ex}");
                    return;
                }

                // Extract zipped client contents to current working directory
                try
                {
                    AppendToLog($"\nExtracting {zippedClientFile.FullName} to {Constants.InstallDir}");
                    ExtractToDirectory(zippedClientFile);
                }
                catch (Exception ex)
                {
                    SetLogText($"!! ERROR !! Could not extract client data!\n\n{ex}");
                    return;
                }

                // Delete zipped client since we're (hopefully) done with it
                try
                {
                    AppendToLog("\nCleaning up...");
                    zippedClientFile.Delete();
                    AppendToLog("\n");
                }
                catch (Exception ex)
                {
                    AppendToLog($"!! WARNING !! Could not delete update file! (This is *probably* fine?...)\n\n{ex}");
                }

                if (AutoPlayAfterUpdateOpt.Checked) StartGame(false);
            });
        }

        private async Task<string> GetVersionData()
        {
            return await Constants.Web.Value.GetStringAsync($"{Constants.VersionUrl}?t={Environment.TickCount}");
        }

        private async Task<byte[]> GetGameData()
        {
            return await Constants.Web.Value.GetByteArrayAsync($"{Constants.BinaryUrl}?t=" + Environment.TickCount);
        }

        private async Task WriteGameData(FileInfo file, byte[] data)
        {
            using (FileStream fs = file.OpenWrite())
            {
                await fs.WriteAsync(data, 0, data.Length);
            }
        }

        private void ExtractToDirectory(FileInfo file)
        {
            using (ZipArchive archive = ZipFile.OpenRead(file.FullName))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string path = Constants.InstallDir + "\\" + entry.FullName;
                    if (path.EndsWith("\\") || path.EndsWith("/"))
                    {
                        DirectoryInfo di = new DirectoryInfo(path.Substring(0, path.Length - 1));
                        di.Create();
                    }
                    else
                    {
                        AppendToLog($"\nExtracting {entry.FullName}...");
                        entry.ExtractToFile(path, true);
                    }
                }
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            StartGame(true);
        }
    }
}
