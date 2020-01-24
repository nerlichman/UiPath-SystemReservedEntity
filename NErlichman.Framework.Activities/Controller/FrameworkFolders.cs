using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NErlichman.Framework.Controller
{
    [Serializable]
    public class FrameworkFolders
    {
        public System.String InputFolder { get; set; } = "Data\\Input";
        public System.String OutputFolder { get; set; } = "Data\\Output";
        public System.String TempFolder { get; set; } = "Data\\Temp";
        public System.String ReportsFolder { get; set; } = "Data\\Reports";
        public System.String ExScreenshotsFolder { get; set; } = "Exceptions_Screenshots";

        public FrameworkFolders() { }

        public FrameworkFolders(String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder)
        {
            Initialize(InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder);
        }

        private void Initialize(String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder)
        {
            this.InputFolder = InputFolder;
            this.OutputFolder = OutputFolder;
            this.TempFolder = TempFolder;
            this.ReportsFolder = ReportsFolder;
            this.ExScreenshotsFolder = ExScreenshotsFolder;
        }
    }
}
