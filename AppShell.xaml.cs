﻿using MauiApp1;

namespace MyTasks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
