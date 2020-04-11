using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using NErlichman.SystemReserved.Activities.Design.Designers;
using NErlichman.SystemReserved.Activities.Design.Properties;

namespace NErlichman.SystemReserved.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(BuildFrameworkFolders), categoryAttribute);
            builder.AddCustomAttributes(typeof(BuildFrameworkFolders), new DesignerAttribute(typeof(BuildFrameworkFoldersDesigner)));
            builder.AddCustomAttributes(typeof(BuildFrameworkFolders), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BuildSystemReserved), categoryAttribute);
            builder.AddCustomAttributes(typeof(BuildSystemReserved), new DesignerAttribute(typeof(BuildSystemReservedDesigner)));
            builder.AddCustomAttributes(typeof(BuildSystemReserved), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IncrementTransactionNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(IncrementTransactionNumber), new DesignerAttribute(typeof(IncrementTransactionNumberDesigner)));
            builder.AddCustomAttributes(typeof(IncrementTransactionNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IncrementRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(IncrementRetryNumber), new DesignerAttribute(typeof(IncrementRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(IncrementRetryNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IncrementInitRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(IncrementInitRetryNumber), new DesignerAttribute(typeof(IncrementInitRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(IncrementInitRetryNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IncrementContinuousRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(IncrementContinuousRetryNumber), new DesignerAttribute(typeof(IncrementContinuousRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(IncrementContinuousRetryNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(ResetRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(ResetRetryNumber), new DesignerAttribute(typeof(ResetRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(ResetRetryNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(ResetInitRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(ResetInitRetryNumber), new DesignerAttribute(typeof(ResetInitRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(ResetInitRetryNumber), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(ResetConinuousRetryNumber), categoryAttribute);
            builder.AddCustomAttributes(typeof(ResetConinuousRetryNumber), new DesignerAttribute(typeof(ResetConinuousRetryNumberDesigner)));
            builder.AddCustomAttributes(typeof(ResetConinuousRetryNumber), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
