using System;
using System.Collections.Generic;
using System.Activities;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows.Markup;

namespace NErlichman.Framework
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

    [Serializable]
    public class SystemReserved
    {
        public System.Int32 TransactionNumber { get; set; } = 1;
        public System.Int32 RetryNumber { get; set; } = 0;
        public System.Int32 InitRetryNumber { get; set; } = 0;
        public System.Int32 ContinuousRetryNumber { get; set; } = 0;
        public System.Boolean IsQueueItem { get; private set; } = false;
        public System.String RobotFail { get; set; } = "";
        public FrameworkFolders Folders { get; set; } = new FrameworkFolders();
        public Dictionary<String, Object> CustomParams { get; set; } = new Dictionary<String, Object>();

        public SystemReserved() {}

        public SystemReserved(Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.String InputFolder, System.String OutputFolder, System.String TempFolder, System.String ReportsFolder, System.String ExScreenshotsFolder, System.Boolean IsQueueItem)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
        }
        
        public SystemReserved(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.String InputFolder, System.String OutputFolder, System.String TempFolder, System.String ReportsFolder, System.String ExScreenshotsFolder, System.Boolean IsQueueItem, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, FrameworkFolders Folders,System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, Folders, IsQueueItem, RobotFail, CustomParams);
        }

        public SystemReserved(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.String InputFolder, System.String OutputFolder, System.String TempFolder, System.String ReportsFolder, System.String ExScreenshotsFolder, System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
        {
            Initialize(TransactionNumber, RetryNumber, InitRetryNumber, ContinuousRetryNumber, InputFolder, OutputFolder, TempFolder, ReportsFolder, ExScreenshotsFolder, IsQueueItem, RobotFail, CustomParams);
        }

        private void Initialize(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.String InputFolder, System.String OutputFolder, System.String TempFolder, System.String ReportsFolder, System.String ExScreenshotsFolder, System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
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

        private void Initialize(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, FrameworkFolders Folders, System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
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

        private void Initialize(System.Int32 TransactionNumber, System.Int32 RetryNumber, System.Int32 InitRetryNumber, System.Int32 ContinuousRetryNumber, System.Boolean IsQueueItem, System.String RobotFail, Dictionary<String, Object> CustomParams)
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


    public class RegisterMetadata : IRegisterMetadata
    {
        public void Register() { }
    }


}