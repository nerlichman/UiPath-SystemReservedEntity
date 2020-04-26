using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using SystemReserved.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace SystemReserved.Activities
{
    [LocalizedDisplayName(nameof(Resources.ResetRetryNumber_DisplayName))]
    [LocalizedDescription(nameof(Resources.ResetRetryNumber_Description))]
    public class ResetRetryNumber : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.ResetRetryNumber_SystemReserved_DisplayName))]
        [LocalizedDescription(nameof(Resources.ResetRetryNumber_SystemReserved_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InOutArgument<SystemReserved> SystemReserved { get; set; }

        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<Boolean> Result { get; set; }

        #endregion


        #region Constructors

        public ResetRetryNumber()
        {
        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (SystemReserved == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(SystemReserved)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var systemreserved = SystemReserved.Get(context);
            var result = false;

            ///////////////////////////

            systemreserved.ResetRetryNumber();
            result = systemreserved.RetryNumber == 0;

            ///////////////////////////

            // Outputs
            return (ctx) => {
                SystemReserved.Set(ctx, systemreserved);
                Result.Set(ctx, result);
            };
        }

        #endregion
    }
}

