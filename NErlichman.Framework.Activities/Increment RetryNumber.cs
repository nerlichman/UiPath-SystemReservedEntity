using System.Activities;
using System.ComponentModel;

namespace NErlichman.Framework.Activities
{
    [DisplayName("Increment RetryNumber")]
    [Description("Increment RetryNumber")]
    public class IncrementRetryNumber : NativeActivity
    {
        #region Properties

        [Category("Target")]
        [RequiredArgument]
        public InOutArgument<SystemReserved> SystemReserved { get; set; }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Runs the main logic of the activity. Has access to the context, 
        /// which holds the values of properties for this activity and those from the parent scope.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override void Execute(NativeActivityContext context)
        {
            var sysRes = SystemReserved.Get(context);

            sysRes.RetryNumber += 1;

            SystemReserved.Set(context, sysRes);

        }

        #endregion
    }
}
