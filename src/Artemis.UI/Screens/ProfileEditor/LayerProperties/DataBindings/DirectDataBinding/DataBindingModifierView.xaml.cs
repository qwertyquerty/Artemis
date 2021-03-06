﻿using System.Windows;
using System.Windows.Controls;

namespace Artemis.UI.Screens.ProfileEditor.LayerProperties.DataBindings.DirectDataBinding
{
    /// <summary>
    ///     Interaction logic for DataBindingModifierView.xaml
    /// </summary>
    public partial class DataBindingModifierView : UserControl
    {
        public DataBindingModifierView()
        {
            InitializeComponent();
        }

        private void PropertyButton_OnClick(object sender, RoutedEventArgs e)
        {
            // DataContext is not set when using left button, I don't know why but there it is
            if (sender is Button button && button.ContextMenu != null)
            {
                button.ContextMenu.DataContext = button.DataContext;
                button.ContextMenu.IsOpen = true;
            }
        }
    }
}