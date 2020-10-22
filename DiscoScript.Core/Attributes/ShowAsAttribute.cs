using System;
using System.Drawing;

namespace DiscoScript.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class ShowAsAttribute : Attribute
    {
        public string? Text { get; }
        public Color Color { get; set; }

        public ShowAsAttribute()
        {
            Color = Color.White;
        }

        public ShowAsAttribute(string text) => Text = text;
    }
}