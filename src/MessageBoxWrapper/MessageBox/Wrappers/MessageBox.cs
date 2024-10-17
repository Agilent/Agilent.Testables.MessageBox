using System.Diagnostics.CodeAnalysis;
using System.Windows;
using Agilent.Testables.MessageBox.Abstractions;
using MessageBoxOptions = System.Windows.MessageBoxOptions;

namespace Agilent.Testables.MessageBox.Wrappers
{
    [ExcludeFromCodeCoverage]
    public class MessageBox : IMessageBox
    {
        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText)
        {
            return System.Windows.MessageBox.Show(messageBoxText);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption)
        {
            return System.Windows.MessageBox.Show(messageBoxText, caption);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            return System.Windows.MessageBox.Show(messageBoxText, caption, button);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText, caption);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText, caption, button);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon,
            MessageBoxResult defaultResult)
        {
            return System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button,
            MessageBoxImage icon)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText, caption, button, icon);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon,
            MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, defaultResult, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button,
            MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button,
            MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return System.Windows.MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult, options);
        }
    }
}
