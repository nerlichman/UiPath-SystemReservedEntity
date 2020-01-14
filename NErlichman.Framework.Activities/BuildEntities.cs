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

namespace NErlichman.Framework.Activities
{
    [DisplayName("Build Framework Folders")]
    [Description("Build Framework Folders")]
    public sealed class BuildFrameworkFolders : CodeActivity<FrameworkFolders>
    {
        #region Properties

        [DefaultValue("Data\\Input")]
        [Category("Optional Fields")]
        public InArgument<System.String> InputFolder { get; set; }
        [DefaultValue("Data\\Output")]
        [Category("Optional Fields")]
        public InArgument<System.String> OutputFolder { get; set; }
        [DefaultValue("Data\\Temp")]
        [Category("Optional Fields")]
        public InArgument<System.String> TempFolder { get; set; }
        [DefaultValue("Data\\Reports")]
        [Category("Optional Fields")]
        public InArgument<System.String> ReportsFolder { get; set; }
        [DefaultValue("Exceptions_Screenshots")]
        [Category("Optional Fields")]
        public InArgument<System.String> ExScreenshotsFolder { get; set; }

        #endregion

        protected override FrameworkFolders Execute(CodeActivityContext context)
        {
            return new FrameworkFolders(InputFolder.Get(context) ?? "Data\\Input", OutputFolder.Get(context) ?? "Data\\Output", TempFolder.Get(context) ?? "Data\\Temp", ReportsFolder.Get(context) ?? "Data\\Reports", ExScreenshotsFolder.Get(context) ?? "Exceptions_Screenshots");
        }

    }

    [DisplayName("Build SystemReserved")]
    [Description("Build SystemReserved")]
    public sealed class BuildSystemReserved : CodeActivity<SystemReserved>
    {
        #region Properties

        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<System.Int32> TransactionNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<System.Int32> RetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<System.Int32> InitRetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<System.Int32> ContinuousRetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<System.Boolean> IsQueueItem { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<System.String> RobotFail { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<FrameworkFolders> Folders { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<Dictionary<String, Object>> CustomParams { get; set; }

        #endregion

        protected override SystemReserved Execute(CodeActivityContext context)
        {
            return new SystemReserved(TransactionNumber.Get(context), RetryNumber.Get(context), InitRetryNumber.Get(context), ContinuousRetryNumber.Get(context), Folders.Get(context) ?? new FrameworkFolders(), IsQueueItem.Get(context), RobotFail.Get(context), CustomParams.Get(context) ?? new Dictionary<String, Object>());
        }

    }

    public class RegisterMetadata : IRegisterMetadata
    {
        public void Register() { }
    }


}