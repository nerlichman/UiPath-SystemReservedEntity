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
using NErlichman.Framework.Controller;

namespace NErlichman.Framework
{
    [DisplayName("Build Framework Folders")]
    [Description("Build Framework Folders")]
    [Designer(typeof(Design.BuildFrameworkFoldersDesigner))]
    public sealed class BuildFrameworkFolders : CodeActivity
    {
        #region Properties

        [DefaultValue("Data\\Input")]
        [Category("Optional Fields")]
        public InArgument<String> InputFolder { get; set; }
        [DefaultValue("Data\\Output")]
        [Category("Optional Fields")]
        public InArgument<String> OutputFolder { get; set; }
        [DefaultValue("Data\\Temp")]
        [Category("Optional Fields")]
        public InArgument<String> TempFolder { get; set; }
        [DefaultValue("Data\\Reports")]
        [Category("Optional Fields")]
        public InArgument<String> ReportsFolder { get; set; }
        [DefaultValue("Exceptions_Screenshots")]
        [Category("Optional Fields")]
        public InArgument<String> ExScreenshotsFolder { get; set; }
        [RequiredArgument]
        [Category("Output")]
        public OutArgument<FrameworkFolders> FrameworkFolders { get; set; }
        #endregion

        protected override void Execute(CodeActivityContext context)
        {
            FrameworkFolders.Set(context, new FrameworkFolders(InputFolder.Get(context) ?? "Data\\Input", OutputFolder.Get(context) ?? "Data\\Output", TempFolder.Get(context) ?? "Data\\Temp", ReportsFolder.Get(context) ?? "Data\\Reports", ExScreenshotsFolder.Get(context) ?? "Exceptions_Screenshots"));
        }

    }

    [DisplayName("Build SystemReserved")]
    [Description("Build SystemReserved")]
    [Designer(typeof(Design.BuildSystemReservedDesigner))]
    public sealed class BuildSystemReserved : CodeActivity
    {
        #region Properties

        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<Int32> TransactionNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<Int32> RetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<Int32> InitRetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<Int32> ContinuousRetryNumber { get; set; }
        [RequiredArgument]
        [Category("Required Fields")]
        public InArgument<Boolean> IsQueueItem { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<String> RobotFail { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<FrameworkFolders> Folders { get; set; }
        [DefaultValue(null)]
        [Category("Optional Fields")]
        public InArgument<Dictionary<String, Object>> CustomParams { get; set; }
        [RequiredArgument]
        [Category("Output")]
        public OutArgument<SystemReserved> SystemReserved { get; set; }

        #endregion

        protected override void Execute(CodeActivityContext context)
        {
            SystemReserved.Set(context,new SystemReserved(TransactionNumber.Get(context), RetryNumber.Get(context), InitRetryNumber.Get(context), ContinuousRetryNumber.Get(context), Folders.Get(context) ?? new FrameworkFolders(), IsQueueItem.Get(context), RobotFail.Get(context), CustomParams.Get(context) ?? new Dictionary<String, Object>()));
        }

    }

}
