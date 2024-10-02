// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

using System.Windows.Forms;
using Agilent.Ace.Testables.MessageBox.Abstractions;

namespace Agilent.Ace.Testables.MessageBox.Wrappers
{
    public class MessageBox : IMessageBox
    {
        /// <inheritdoc />
        public DialogResult Show(string text)
        {
            return System.Windows.Forms.MessageBox.Show(text);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath, keyword);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator,
            object param)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator, param);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, keyword);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options, displayHelpButton);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption);
        }

        /// <inheritdoc />
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            return System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton, options);
        }

        /// <inheritdoc />
        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator,
            object param)
        {
            return System.Windows.Forms.MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options,
                helpFilePath, navigator, param);
        }
    }
}
