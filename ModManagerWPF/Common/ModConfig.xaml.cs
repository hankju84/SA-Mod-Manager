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

namespace ModManagerWPF.Common
{
	/// <summary>
	/// Interaction logic for ModConfig.xaml
	/// </summary>
	public partial class ModConfig : Window
	{
		public ModConfig(SADXModInfo Mod)
		{
			InitializeComponent();
		}
	}
}
