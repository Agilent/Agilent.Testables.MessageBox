// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

using System.Windows;

namespace Agilent.Ace.Testables.MessageBox.Abstractions
{
    /// <summary>
    /// Abstractions for <see cref="System.Windows.MessageBox"/>
    /// </summary>
    public interface IMessageBox
    {
        /// <inheritdoc cref="System.Windows.MessageBox.Show(string)"/>
        MessageBoxResult Show(string messageBoxText);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(string, string)"/>
        MessageBoxResult Show(string messageBoxText, string caption);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string)"/>
        MessageBoxResult Show(Window owner, string messageBoxText);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(string, string, MessageBoxButton)"/>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string, string)"/>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(string, string, MessageBoxButton, MessageBoxImage)"/>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string, string, MessageBoxButton)"/>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(string, string, MessageBoxButton, MessageBoxImage, MessageBoxResult)"/>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string, string, MessageBoxButton, MessageBoxImage)"/>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(string, string, MessageBoxButton, MessageBoxImage, MessageBoxResult, MessageBoxOptions)"/>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string, string, MessageBoxButton, MessageBoxImage, MessageBoxResult)"/>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);

        /// <inheritdoc cref="System.Windows.MessageBox.Show(Window, string, string, MessageBoxButton, MessageBoxImage, MessageBoxResult, MessageBoxOptions)"/>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);
    }
}
