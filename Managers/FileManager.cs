using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessScreenBuilder.Managers
{
    public class FileManager
    {
        public static string ExecutionFolder = string.Empty;
        public static FileManager? _Instance;
        public List<SuccessScreen> Success = new List<SuccessScreen>();
        private Dictionary<string, string> files = new Dictionary<string, string>();
        public FileManager()
        {
            if (_Instance == null)
                _Instance = this;
            ExecutionFolder = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\'));
        }
        public static FileManager? Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new FileManager();
                return _Instance;
            }
        }

        public List<string> GetSuccessImage(string Path) => Directory.GetFiles(Path).ToList();

        public void Init()
        {
            Success.Clear();
            Form1.Instance!.gettingFilesStatusBar.MaxValue = ScreenNumber() * 1000;
            if (Directory.Exists($@"{ExecutionFolder}\SavedRessources"))
            {
                foreach (string DirectoryPath in Directory.GetDirectories($@"{ExecutionFolder}\SavedRessources"))
                {
                    foreach (string DirectoryLevels in sortedList(Directory.GetDirectories(DirectoryPath).ToList()))
                    {
                        foreach (string screenPath in Directory.GetFiles(DirectoryLevels))
                        {
                            int category = -1;
                            if (DirectoryLevels.Contains("1 - 50"))
                                category = 0;
                            if (DirectoryLevels.Contains("51 - 100"))
                                category = 1;
                            else if (DirectoryLevels.Contains("101 - 150"))
                                category = 2;
                            else if (DirectoryLevels.Contains("151 - 190"))
                                category = 3;
                            else if (DirectoryLevels.Contains("191 - 200"))
                                category = 4;
                            if (category == -1)
                            {
                                MessageBox.Show("Une erreur est survenue, remplacez le dossier des screens !", "Dossier screen corrompu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(-1);
                            }
                            Success.Add(new SuccessScreen(category, Image.FromFile(screenPath)));
                            Form1.Instance?.Invoke(() => Form1.Instance.gettingFilesStatusBar.Value += 1000);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Le dossier des screens est manquant, placez le dans le même repetoire que l'executable !", "Dossier screen manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }
        private int ScreenNumber()
        {
            int filesNumber = 0;
            if (Directory.Exists($@"{ExecutionFolder}\SavedRessources"))
            {
                foreach (string DirectoryPath in Directory.GetDirectories($@"{ExecutionFolder}\SavedRessources"))
                    foreach (string DirectoryLevels in Directory.GetDirectories(DirectoryPath))
                        foreach (string screenPath in Directory.GetFiles(DirectoryLevels))
                            filesNumber++;
            }
            return filesNumber;
        }

        private List<string> sortedList(List<string> toTreat)
        {
            List<string> toReturn = new List<string>();
            foreach (string str in toTreat)
            {
                DirectoryInfo DI = new DirectoryInfo(str);
                int t = 0;
                if (!int.TryParse(DI.Name, out t))
                    return toTreat;
            }

            while (toReturn.Count < toTreat.Count)
            {

                int latestLowValue = 1000000000;
                int indexOf = 100000000;

                foreach (string str in toTreat)
                {
                    if(!toReturn.Contains(str))
                    {
                        DirectoryInfo DI = new DirectoryInfo(str);
                        int buff = -1;
                        if (int.TryParse(DI.Name, out buff))
                        {
                            if(int.Parse(DI.Name) < latestLowValue)
                            {
                                latestLowValue = int.Parse(DI.Name);
                                indexOf = toTreat.IndexOf(str);
                            }
                        }
                    }
                }
                toReturn.Add(toTreat[indexOf]);
            }
            return toReturn;
        }
    }
}
