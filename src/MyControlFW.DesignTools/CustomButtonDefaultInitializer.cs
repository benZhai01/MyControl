using Microsoft.Windows.Design.Model;
using System.Windows;
using System.Windows.Media;

namespace MyControlFW.Design
{
    // The following class implements an default initializer for the 
    // custom buttom. Default initializer is invoked when the custom 
    // button is dragged from toolbox to designer.
    public class CustomButtonDefaultInitializer : DefaultInitializer
    {
        public override void InitializeDefaults(ModelItem item)
        {
            // The following method is called when the custom button is dragged
            // from toolbox to designer. It initializes the default settings.
            item.Properties["Name"].SetValue("button1");
            item.Properties["Width"].SetValue("300");
            item.Properties["Content"].SetValue("Custom Button");
            item.Properties["FontFamily"].SetValue(new FontFamily("Arial"));
            item.Properties["Margin"].SetValue(new Thickness(100, 20, 30, 40));
            item.Properties["Background"].SetValue(new LinearGradientBrush(Colors.White, Colors.Black, 45));
            item.Properties["RenderTransform"].SetValue(new RotateTransform(45));
        }
    }
}
