using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q06
{
    internal class CaptionFormatter
    {
        private int width;

        public string Prefix { get; }
        
        public int Width
        {
            get => width;
            set => width = Math.Clamp(value, 1, 0);
        }

        public CaptionFormatter(string prefix, int width)
        {
            Prefix = prefix;
            Width = width;

        }

        public string Format(string text)
        {
            if(text.Length > Width)
            {
                text = text.Substring(0, Width);
            }
            return $"{Prefix}<{text}>";
        }



    }
}
