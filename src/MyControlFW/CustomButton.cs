using System;
using System.Windows.Controls;
using System.ComponentModel;

namespace MyControlFW
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                Content = "Design mode active";
            }
        }

        public void ADD(TempClass2 tempClass)
        {

        }

    }
    [DesignTimeVisible(false)]
    public class TempClass2 : Control { }

}
