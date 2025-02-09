﻿//************************************************************************************************
// Copyright © 2021 Steven M Cohn.  All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn.Commands
{
	using Resx = River.OneMoreAddIn.Properties.Resources;


	internal partial class SortListDialog : UI.LocalizableForm
	{
		public SortListDialog()
		{
			InitializeComponent();

			if (NeedsLocalizing())
			{
				Text = Resx.SortListDialog_Text;

				Localize(new string[]
				{
					"introLabel",
					"optionsBox=word_Options",
					"thisListButton",
					"allListsButton",
					"deepBox",
					"typeBox",
					"okButton=word_OK",
					"cancelButton=word_Cancel"
				});
			}
		}


		public bool IncludeAllLists => allListsButton.Checked;


		public bool IncludeChildLists => deepBox.Checked;


		public bool IncludeNumberedLists => typeBox.Checked;


		private void LoadForm(object sender, System.EventArgs e)
		{
			ActiveControl = okButton;
		}
	}
}
