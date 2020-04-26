using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using SystemReserved.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace SystemReserved.Activities {
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

        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<Boolean> Result { get; set; }

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
            var result = true;

            ///////////////////////////

            // Create FrameworkFolders entity
            var frameworkFolders = new FrameworkFolders(inputFolder, outputFolder, tempFolder, reportsFolder, exscreenshotsFolder);

            // If argument has value, check if it was correctly assigned
            if (inputFolder != null && frameworkFolders.Input != inputFolder) result = false;
            if (outputFolder != null && frameworkFolders.Output != outputFolder) result = false;
            if (tempFolder != null && frameworkFolders.Temp != tempFolder) result = false;
            if (reportsFolder != null && frameworkFolders.Reports != reportsFolder) result = false;
            if (exscreenshotsFolder != null && frameworkFolders.ExScreenshots != exscreenshotsFolder) result = false;

            ///////////////////////////

            // Outputs
            return (ctx) => {
                FrameworkFolders.Set(ctx, frameworkFolders);
                Result.Set(ctx, result);
            };
        }

        #endregion
    }
}

