﻿namespace micdah.LrControlApi.Modules.LrDevelopController.Parameters
{
    public class SplitToningPanelParameter : Parameter<SplitToningPanelParameter>, IDevelopControllerParameter
    {
        public static readonly SplitToningPanelParameter SplitToningHighlightHue        = new SplitToningPanelParameter("SplitToningHighlightHue", "Highlights: Hue");
        public static readonly SplitToningPanelParameter SplitToningHighlightSaturation = new SplitToningPanelParameter("SplitToningHighlightSaturation", "Highlights: Saturation");
        public static readonly SplitToningPanelParameter SplitToningBalance             = new SplitToningPanelParameter("SplitToningBalance", "Balance");
        public static readonly SplitToningPanelParameter SplitToningShadowHue           = new SplitToningPanelParameter("SplitToningShadowHue", "Shadows: Hue");
        public static readonly SplitToningPanelParameter SplitToningShadowSaturation    = new SplitToningPanelParameter("SplitToningShadowSaturation", "Shadows: Saturation");

        private SplitToningPanelParameter(string value, string name) : base(name, value, typeof(int))
        {
        }
    }
}