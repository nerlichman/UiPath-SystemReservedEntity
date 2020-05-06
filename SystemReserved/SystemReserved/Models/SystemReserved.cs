using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReserved {

    [Serializable]
    public class SystemReserved {

        #region Properties

        public Int32 TransactionNumber { get; private set; } = 1;
        public Int32 RetryNumber { get; set; } = 0;
        public Int32 InitRetryNumber { get; private set; } = 0;
        public Int32 ContinuousRetryNumber { get; private set; } = 0;
        public Boolean IsQueueItem { get; set; } = false;
        public String RobotFail { get; set; } = "";
        public FrameworkFolders Folders { get; set; } = new FrameworkFolders();
        public Dictionary<String, Object> CustomParameters { get; set; } = new Dictionary<String, Object>();

        #endregion

        #region Constructors

        public SystemReserved() { }

        public SystemReserved(Boolean IsQueueItem) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.Input, Folders.Output, Folders.Temp, Folders.Reports, Folders.ExScreenshots, IsQueueItem, RobotFail, CustomParameters);
        }

        public SystemReserved(Dictionary<String, Object> CustomParameters) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.Input, Folders.Output, Folders.Temp, Folders.Reports, Folders.ExScreenshots, IsQueueItem, RobotFail, CustomParameters ?? this.CustomParameters);

        }

        public SystemReserved(Boolean IsQueueItem, Dictionary<String, Object> CustomParameters) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.Input, Folders.Output, Folders.Temp, Folders.Reports, Folders.ExScreenshots, IsQueueItem, RobotFail, CustomParameters ?? this.CustomParameters);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.Input, OutputFolder ?? Folders.Output, TempFolder ?? Folders.Temp,
                ReportsFolder ?? Folders.Reports, ExScreenshotsFolder ?? Folders.ExScreenshots, IsQueueItem, RobotFail, CustomParameters);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, Dictionary<String, Object> CustomParameters) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.Input, OutputFolder ?? Folders.Output, TempFolder ?? Folders.Temp,
                    ReportsFolder ?? Folders.Reports, ExScreenshotsFolder ?? Folders.ExScreenshots, IsQueueItem, RobotFail, CustomParameters ?? this.CustomParameters);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParameters) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.Input, Folders.Output, Folders.Temp,
                     Folders.Reports, Folders.ExScreenshots, IsQueueItem, RobotFail ?? this.RobotFail, CustomParameters ?? this.CustomParameters);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, FrameworkFolders Folders, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParameters) {
            if (Folders == null) {
                Folders = this.Folders;
            }
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.Input, Folders.Output, Folders.Temp,
                     Folders.Reports, Folders.ExScreenshots, IsQueueItem, RobotFail ?? this.RobotFail, CustomParameters ?? this.CustomParameters);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParameters) {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.Input, OutputFolder ?? Folders.Output, TempFolder ?? Folders.Temp,
                     ReportsFolder ?? Folders.Reports, ExScreenshotsFolder ?? Folders.ExScreenshots, IsQueueItem, RobotFail ?? this.RobotFail, CustomParameters ?? this.CustomParameters);
        }

        private void Initialize(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParameters) {
            this.TransactionNumber = TransactionNumber;
            this.RetryNumber = RetryNumber;
            this.InitRetryNumber = InitRetryNumber;
            this.ContinuousRetryNumber = ContinuousRetryNumber;
            this.Folders = new FrameworkFolders(InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder);
            this.IsQueueItem = IsQueueItem;
            this.RobotFail = RobotFail;
            this.CustomParameters = CustomParameters;
        }

        #endregion

        #region Protected Methods

        public void IncrementTransactionNumber() {
            this.TransactionNumber += 1;
        }

        public void IncrementRetryNumber() {
            this.RetryNumber += 1;
        }

        public void IncrementInitRetryNumber() {
            this.InitRetryNumber += 1;
        }

        public void IncrementContinuousRetryNumber() {
            this.ContinuousRetryNumber += 1;
        }

        public void ResetRetryNumber() {
            this.RetryNumber = 0;
        }

        public void ResetInitRetryNumber() {
            this.InitRetryNumber = 0;
        }

        public void ResetContinuousRetryNumberr() {
            this.ContinuousRetryNumber = 0;
        }

        #endregion
    }
}
