using Prism.Commands;
using Prism.Mvvm;
using System;

namespace SeminarSearch.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		private string message;

		public string Message
		{ 
			get { return this.message; }
			set { this.SetProperty(ref this.message, value); }
		}

		public DelegateCommand UpdateMessageCommand { get; }

		public MainPageViewModel()
		{
			this.UpdateMessageCommand = new DelegateCommand(() => this.Message = DateTime.Now.ToString());
		}	
	}
}
