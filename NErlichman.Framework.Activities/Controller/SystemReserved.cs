using System;
using System.Collections.Generic;

namespace NErlichman.Framework.Controller
{

    [Serializable]
    public class SystemReserved
    {
        public Int32 TransactionNumber { get; set; } = 1;
        public Int32 RetryNumber { get; set; } = 0;
        public Int32 InitRetryNumber { get; set; } = 0;
        public Int32 ContinuousRetryNumber { get; set; } = 0;
        public Boolean IsQueueItem { get; private set; } = false;
        public String RobotFail { get; set; } = "";
        public FrameworkFolders Folders { get; set; } = new FrameworkFolders();
        public Dictionary<String, Object> CustomParams { get; set; } = new Dictionary<String, Object>();

        public SystemReserved() { }

        public SystemReserved(Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.InputFolder, Folders.OutputFolder, Folders.TempFolder, Folders.ReportsFolder, Folders.ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams ?? this.CustomParams);

        }

        public SystemReserved(Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.InputFolder, Folders.OutputFolder, Folders.TempFolder, Folders.ReportsFolder, Folders.ExScreenshotsFolder,IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.InputFolder, Folders.OutputFolder, Folders.TempFolder, Folders.ReportsFolder, Folders.ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams??this.CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.InputFolder, OutputFolder ?? Folders.OutputFolder, TempFolder ?? Folders.TempFolder,
                ReportsFolder ?? Folders.ReportsFolder, ExScreenshotsFolder ?? Folders.ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);

        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.InputFolder, OutputFolder ?? Folders.OutputFolder, TempFolder ?? Folders.TempFolder,
                    ReportsFolder ?? Folders.ReportsFolder, ExScreenshotsFolder ?? Folders.ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams ?? this.CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders.InputFolder, Folders.OutputFolder, Folders.TempFolder,
                     Folders.ReportsFolder, Folders.ExScreenshotsFolder, IsQueueItem, RobotFail ?? this.RobotFail, CustomParams ?? this.CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, FrameworkFolders Folders, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            if (Folders == null)
            {
                Folders = this.Folders;
            }
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber,  Folders.InputFolder, Folders.OutputFolder, Folders.TempFolder,
                     Folders.ReportsFolder,  Folders.ExScreenshotsFolder, IsQueueItem, RobotFail??this.RobotFail, CustomParams ?? this.CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder ?? Folders.InputFolder, OutputFolder ?? Folders.OutputFolder, TempFolder ?? Folders.TempFolder,
                     ReportsFolder ?? Folders.ReportsFolder, ExScreenshotsFolder ?? Folders.ExScreenshotsFolder, IsQueueItem, RobotFail ?? this.RobotFail, CustomParams ?? this.CustomParams);
        }

            private void Initialize(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            this.TransactionNumber = TransactionNumber;
            this.RetryNumber = RetryNumber;
            this.InitRetryNumber = InitRetryNumber;
            this.ContinuousRetryNumber = ContinuousRetryNumber;
            this.Folders = new FrameworkFolders(InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder);
            this.IsQueueItem = IsQueueItem;
            this.RobotFail = RobotFail;
            this.CustomParams = CustomParams;
        }

    }
}