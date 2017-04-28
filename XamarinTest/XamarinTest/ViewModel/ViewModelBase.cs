using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTest.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        //#region Debugging Aides

        ///// <summary>
        ///// Warns the developer if this object does not have
        ///// a public property with the specified name. This 
        ///// method does not exist in a Release build.
        ///// </summary>
        //[Conditional("DEBUG")]
        //[DebuggerStepThrough]
        //public void VerifyPropertyName(string propertyName)
        //{
        //    // Verify that the property name matches a real,  
        //    // public, instance property on this object.
        //    if (this.GetType().GetProperties(this)[propertyName] == null)
        //    {
        //        string msg = "Invalid property name: " + propertyName;

        //        if (ThrowOnInvalidPropertyName)
        //            throw new Exception(msg);

        //        Debug.Fail(msg);
        //    }
        //}

        ///// <summary>
        ///// Returns whether an exception is thrown, or if a Debug.Fail() is used
        ///// when an invalid property name is passed to the VerifyPropertyName method.
        ///// The default value is false, but subclasses used by unit tests might 
        ///// override this property's getter to return true.
        ///// </summary>
        //protected virtual bool ThrowOnInvalidPropertyName { get; private set; }


        //#endregion // Debugging Aides

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raised when a property on this object has a new value.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises this object's PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The property that has a new value.</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            //VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        #endregion // INotifyPropertyChanged Members
    }
}
