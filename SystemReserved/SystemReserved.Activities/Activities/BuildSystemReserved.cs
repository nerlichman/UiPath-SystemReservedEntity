using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using SystemReserved.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using System.Collections.Generic;

namespace SystemReserved.Activities {
    [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_DisplayName))]
    [LocalizedDescription(nameof(Resources.BuildSystemReserved_Description))]
    public class BuildSystemReserved : ContinuableAsyncCodeActivity {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_TransactionNumber_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_TransactionNumber_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<int> TransactionNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_RetryNumber_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_RetryNumber_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<int> RetryNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_InitRetryNumber_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_InitRetryNumber_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<int> InitRetryNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_ContinuousRetryNumber_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_ContinuousRetryNumber_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<int> ContinuousRetryNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_IsQueueItem_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_IsQueueItem_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<bool> IsQueueItem { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_Folders_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_Folders_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<FrameworkFolders> Folders { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_CustomParameters_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_CustomParameters_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<Dictionary<string, object>> CustomParameters { get; set; }

        [LocalizedDisplayName(nameof(Resources.BuildSystemReserved_SystemReserved_DisplayName))]
        [LocalizedDescription(nameof(Resources.BuildSystemReserved_SystemReserved_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<SystemReserved> SystemReserved { get; set; }

        #endregion


        #region Constructors

        public BuildSystemReserved() { }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata) {
            if (TransactionNumber == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(TransactionNumber)));
            if (RetryNumber == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(RetryNumber)));
            if (InitRetryNumber == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(InitRetryNumber)));
            if (ContinuousRetryNumber == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ContinuousRetryNumber)));
            if (IsQueueItem == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(IsQueueItem)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken) {
            // Inputs
            var transactionNumber = TransactionNumber.Get(context);
            var retryNumber = RetryNumber.Get(context);
            var initRetryNumber = InitRetryNumber.Get(context);
            var continuousRetryNumber = ContinuousRetryNumber.Get(context);
            var isQueueItem = IsQueueItem.Get(context);
            var folders = Folders.Get(context);
            var customParameters = CustomParameters.Get(context);

            ///////////////////////////

            var sysRes = new SystemReserved(transactionNumber, retryNumber, initRetryNumber, continuousRetryNumber, folders, isQueueItem, "", customParameters);

            ///////////////////////////

            // Outputs
            return (ctx) => {
                SystemReserved.Set(ctx, sysRes);
            };
        }

        #endregion
    }
}

