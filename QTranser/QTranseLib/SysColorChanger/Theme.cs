﻿
using System;
using System.Windows;
using System.Windows.Media;

namespace QTranser.QTranseLib
{

    public class Theme
    {
        public static Brush GetLogoColor()
        {
            ThemeColor _;
            string color = SystemParameters.WindowGlassBrush.ToString().Remove(0, 1);
            if (Enum.TryParse<ThemeColor>(color, out _))
            {
                return SystemParameters.WindowGlassBrush;
            }
            else
            {
                BrushConverter brushConverter = new BrushConverter();
                return (Brush)brushConverter.ConvertFromString("#FF436059");
            }
        }
    }

    public enum ThemeColor
    {
        FFF4B100,
        FFF18400,
        FFE75C0B,
        FFBB4A0F,
        FFC93601,
        FFE0624B,
        FFC03034,
        FFEC3E3E,
        FFD64350,
        FFD41020,
        FFD50056,
        FFB1004A,
        FFCF007F,
        FFAD006C,
        FFB335A5,
        FF8B007C,
        FF006FC7,
        FF005BA3,
        FF8684CB,
        FF6362C7,
        FF7D5DAB,
        FF6B479C,
        FFA441B4,
        FF7C158A,
        FF008FAF,
        FF2A748F,
        FF00ACB7,
        FF03797D,
        FF00A78B,
        FF017B6B,
        FF00C064,
        FF0F7F39,
        FF726D6C,
        FF565351,
        FF616E80,
        FF4B5563,
        FF50736B,
        FF436059,
        FF447905,
        FF0F720F,
        FF6E6E6E,
        FF464442,
        FF627175,
        FF444D52,
        FF5D735D,
        FF4C574D,
        FF7B6D40,
        FF756B58,
    }


}
