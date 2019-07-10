
// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;

[assembly: ProvideMetadata(typeof(MyControlFW.Design.Metadata))]
namespace MyControlFW.Design
{
    // Container for any general design-time metadata to initialize.
    // Designers look for a type in the design-time assembly that 
    // implements IProvideAttributeTable. If found, designers instantiate 
    // this class and access its AttributeTable property automatically.
    internal class Metadata : IProvideAttributeTable
    {
        // Accessed by the designer to register any design-time metadata.
        public AttributeTable AttributeTable
        {
            get
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                // Add the providers to the design-time metadata.
                builder.AddCustomAttributes(
                    typeof(MyControlFW.CustomButton),
                    new FeatureAttribute(typeof(CustomButtonDefaultInitializer)));
                builder.AddCustomAttributes(
                    typeof(MyControlFW.CustomButton),
                    new FeatureAttribute(typeof(OpacitySliderAdornerProvider)));
                builder.AddCustomAttributes(
                    typeof(MyControlFW.CustomButton),
                    new FeatureAttribute(typeof(CustomContextMenuProvider)));
                builder.AddCustomAttributes(
                    typeof(MyControlFW.CustomButton),
                    new FeatureAttribute(typeof(CustomButtonParentAdapter)));
                builder.AddCustomAttributes(
                    typeof(MyControlFW.CustomButton),
                    new FeatureAttribute(typeof(CustomButtonPlacementAdapter)));
                return builder.CreateTable();
            }
        }
    }
}
