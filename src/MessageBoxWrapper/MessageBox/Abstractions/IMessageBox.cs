// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

using System.Windows.Forms;

namespace Agilent.Ace.Testables.MessageBox.Abstractions
{
    /// <summary>
    /// Abstractions for <see cref="System.Windows.Forms.MessageBox"/>
    /// </summary>
    public interface IMessageBox
    {
        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string)" />
        DialogResult Show(string text);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string, string)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string, HelpNavigator, object)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string, HelpNavigator)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string, string)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, bool)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string)" />
        DialogResult Show(IWin32Window owner, string text, string caption);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string)" />
        DialogResult Show(IWin32Window owner, string text);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string)" />
        DialogResult Show(string text, string caption);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions)" />
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options);

        /// <inheritdoc cref="System.Windows.Forms.MessageBox.Show(IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, MessageBoxOptions, string, HelpNavigator, object)" />
        DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param);
    }
}
