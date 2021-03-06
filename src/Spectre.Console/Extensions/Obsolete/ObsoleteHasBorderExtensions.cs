using System;
using System.ComponentModel;

namespace Spectre.Console
{
    /// <summary>
    /// Contains extension methods for <see cref="IHasBorder"/>.
    /// </summary>
    public static class ObsoleteHasBorderExtensions
    {
        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border color for.</param>
        /// <param name="style">The border style to set.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use BorderStyle(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static T SetBorderStyle<T>(this T obj, Style style)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.BorderStyle = style;
            return obj;
        }

        /// <summary>
        /// Sets the border color.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border color for.</param>
        /// <param name="color">The border color to set.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use BorderColor(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static T SetBorderColor<T>(this T obj, Color color)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.BorderStyle = (obj.BorderStyle ?? Style.Plain).Foreground(color);
            return obj;
        }
    }
}
