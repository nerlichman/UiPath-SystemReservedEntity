using System.Activities;
using System.ComponentModel;

namespace NErlichman.Framework.Activities
{
    [DisplayName("Reset InitRetryNumber")]
    [Description("Reset InitRetryNumber")]
    public class ResetInitRetryNumber : NativeActivity
    {
        #region Properties

        [Category("Target")]
        [DisplayName("SystemReserved")]
        [RequiredArgument]
        public InOutArgument<SystemReserved> SysRes { get; set; }

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
            var sysRes = SysRes.Get(context);

            sysRes.InitRetryNumber = 0;

            SysRes.Set(context, sysRes);

        }

        #endregion
    }
}
