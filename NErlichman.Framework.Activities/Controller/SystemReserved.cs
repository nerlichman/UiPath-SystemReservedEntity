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
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, FrameworkFolders Folders, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, String InputFolder, String OutputFolder, String TempFolder, String ReportsFolder, String ExScreenshotsFolder, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
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

        private void Initialize(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, FrameworkFolders Folders, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            this.TransactionNumber = TransactionNumber;
            this.RetryNumber = RetryNumber;
            this.InitRetryNumber = InitRetryNumber;
            this.ContinuousRetryNumber = ContinuousRetryNumber;
            this.Folders = Folders;
            this.IsQueueItem = IsQueueItem;
            this.RobotFail = RobotFail;
            this.CustomParams = CustomParams;
        }

        private void Initialize(Int32 TransactionNumber, Int32 RetryNumber, Int32 InitRetryNumber, Int32 ContinuousRetryNumber, Boolean IsQueueItem, String RobotFail, Dictionary<String, Object> CustomParams)
        {
            this.TransactionNumber = TransactionNumber;
            this.RetryNumber = RetryNumber;
            this.InitRetryNumber = InitRetryNumber;
            this.ContinuousRetryNumber = ContinuousRetryNumber;
            this.IsQueueItem = IsQueueItem;
            this.RobotFail = RobotFail;
            this.CustomParams = CustomParams;
        }
    }
}