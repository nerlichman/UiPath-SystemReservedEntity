using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using NErlichman.SystemReserved.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace NErlichman.SystemReserved.Activities {
    [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_DisplayName))]
    [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_Description))]
    public class BuildFrameworkFolders : ContinuableAsyncCodeActivity {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_InputFolder_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_InputFolder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Input { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_OutputFolder_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_OutputFolder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Output { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_TempFolder_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_TempFolder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Temp { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_ReportsFolder_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_ReportsFolder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Reports { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_ExScreenshotsFolder_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_ExScreenshotsFolder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> ExScreenshots { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildFrameworkFolders_FrameworkFolders_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildFrameworkFolders_FrameworkFolders_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<FrameworkFolders> FrameworkFolders { get; set; }

        #endregion


        #region Constructors

        public BuildFrameworkFolders() { }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata) {
            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken) {
            // Inputs
            var inputFolder = Input.Get(context);
            var outputFolder = Output.Get(context);
            var tempFolder = Temp.Get(context);
            var reportsFolder = Reports.Get(context);
            var exscreenshotsFolder = ExScreenshots.Get(context);

            ///////////////////////////

            var frameworkFolders = new FrameworkFolders(inputFolder, outputFolder, tempFolder, reportsFolder, exscreenshotsFolder);

            ///////////////////////////

            // Outputs
            return (ctx) => {
                FrameworkFolders.Set(ctx, frameworkFolders);
            };
        }

        #endregion
    }
}

