﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BilibiliVideoFetcher.Views
{
    /// <summary>
    /// CreatMultiTaskWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CreatMultiTaskWindow : Window
    {
        public CreatMultiTaskWindow()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {            
            new Action(delegate {
                if (tbPartStart.Text.Trim() == string.Empty && tbPartEnd.Text.Trim() == string.Empty)
                {
                    Process.FetchingCore.NewMultiTask(tbUrl.Text);
                    return;
                }
                Process.FetchingCore.NewMultiTask(tbUrl.Text,tbPartStart.Text, tbPartEnd.Text);
            })();
            this.Close();
        }
    }
}
