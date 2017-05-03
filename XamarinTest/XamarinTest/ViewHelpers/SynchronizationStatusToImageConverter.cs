using System;
using System.Globalization;
using Xamarin.Forms;
using XamarinTest.Model;

namespace XamarinTest.ViewHelpers
{
    public class SynchronizationStatusToImageConverter : IValueConverter
    {
        /// <summary>
        /// Convert boolean to visibility array
        /// </summary>
        /// <param name="value">The boolean value</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Visible if true, collapsed if false</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // check if object is the synched enum
            if (value == null || !(value is SynchronizationStatus))
                return ImageSource.FromResource("XamarinTest.Images.notsynched.png");

            if ((SynchronizationStatus)value == SynchronizationStatus.Synched)
            {
                return ImageSource.FromResource("XamarinTest.Images.synched.png");
            }
            if ((SynchronizationStatus)value == SynchronizationStatus.InProgress)
            {
                return ImageSource.FromResource("XamarinTest.Images.synching.png");
            }
            return ImageSource.FromResource("XamarinTest.Images.notsynched.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
