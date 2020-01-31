﻿using System.Activities;
using System.ComponentModel;
using NErlichman.Framework.Controller;

namespace NErlichman.Framework.Activities
{
    [DisplayName("Increment TransactionNumber")]
    [Description("Increment TransactionNumber")]
    [Designer(typeof(Design.SystemResevedInputDesigner))]
    public class IncrementTransactionNumber : NativeActivity
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
            SystemReserved.Get(context).TransactionNumber += 1;
        }

        #endregion
    }
}