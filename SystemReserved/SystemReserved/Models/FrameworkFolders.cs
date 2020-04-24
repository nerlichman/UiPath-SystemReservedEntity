using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReserved {

    [Serializable]
    public class FrameworkFolders {
        public System.String Input { get; set; } = "Data\\Input";
        public System.String Output { get; set; } = "Data\\Output";
        public System.String Temp { get; set; } = "Data\\Temp";
        public System.String Reports { get; set; } = "Data\\Reports";
        public System.String ExScreenshots { get; set; } = "Exceptions_Screenshots";

        public FrameworkFolders() { }

        public FrameworkFolders(String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder) {
            Initialize(InputFolder ?? this.Input, OutputFolder ?? this.Output, TempFolder ?? this.Temp, ReportsFolder ?? this.Reports, ExScreenshotsFolder ?? this.ExScreenshots);
        }

        private void Initialize(String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder) {

            this.Input = InputFolder;
            this.Output = OutputFolder;
            this.Temp = TempFolder;
            this.Reports = ReportsFolder;
            this.ExScreenshots = ExScreenshotsFolder;
        }
    }
}
