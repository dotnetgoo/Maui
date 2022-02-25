﻿using System.Windows.Input;
using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Sample.Models;

namespace CommunityToolkit.Maui.Sample.ViewModels.Views;

public sealed class PopupAnchorViewModel : BaseViewModel
{
	public PopupAnchorViewModel()
	{
		ShowPopup = new Command<View>(OnShowPopup);
	}

	Page Page => Application.Current?.MainPage ?? throw new NullReferenceException();

	public ICommand ShowPopup { get; }

	void OnShowPopup(View anchor)
	{

		// Using the C# version of Popup until this get fixed
		// https://github.com/dotnet/maui/issues/4300

		// This works

		var popup = new TransparentPopupCSharp()
		{
			Anchor = anchor
		};

		// This doesn't work

		//var popup = new TransparentPopup
		//{
		//	Anchor = anchor
		//};

		Page.ShowPopup(popup);
	}
}
