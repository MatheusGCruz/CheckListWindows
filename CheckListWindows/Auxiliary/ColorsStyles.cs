using CheckListWindows.Configs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CheckListWindows.Auxiliary
{
    class ColorsStyles
    {
        public static Label setLabelColors(Label colorObject)
        {
            colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
            colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();

            return colorObject;
        }

        public static TextBox setTextBoxColors(TextBox colorObject)
        {
            colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
            colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();

            return colorObject;
        }

        public static ComboBox setComboBoxColors(ComboBox colorObject)
        {
            colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
            colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();

            return colorObject;
        }

        public static Panel setPanelColors(Panel colorObject, bool isContrast)
        {
            if (isContrast)
            {
                colorObject.BackColor = auxiliaryConfigs.getDarkerBackgroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getLighterTextColor();
            }
            else
            {
                colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();
            }

            return colorObject;

        }
    }
}
