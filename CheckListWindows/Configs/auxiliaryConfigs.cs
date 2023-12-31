﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text;

namespace CheckListWindows.Configs
{
    class auxiliaryConfigs
    {
        public static bool isConfigChanged { get; set; }
        public static String shadownTimerValue { get; set; } 
        public static String refreshTimerValue { get; set; } 

        public static Color getBackGroundColor()
        {
            return ColorTranslator.FromHtml(ConfigurationManager.AppSettings.Get("backgroundColor")); 
        }

        public static Color getTextColorConfig()
        {
            return ColorTranslator.FromHtml(ConfigurationManager.AppSettings.Get("textColor")); 
        }


        public static Color getDarkerBackgroundColor()
        {
            return getDarkerColor(getBackGroundColor(), 25);
        }

        public static Color getLighterTextColor()
        {
            return getDarkerColor(getBackGroundColor(), -25);
        }

        public static Color getDarkerBorderColor()
        {
            return getDarkerColor(getBackGroundColor(), 75);
        }

        private static Color getDarkerColor(Color originalColor, int ton)
        {

                int red = (int)originalColor.R;
                int green = (int)originalColor.G;
                int blue = (int)originalColor.B;

                red = validateLimits(red - ton);
                green = validateLimits(green - ton);
                blue = validateLimits(blue - ton); 

                return Color.FromArgb(originalColor.A, (int)red, (int)green, (int)blue);

        }




        private static int validateLimits(int value)
        {   
            if(value < 0) { value = 0; }
            if(value > 255) { value = 255; }
            return value;
        }

    }
}
