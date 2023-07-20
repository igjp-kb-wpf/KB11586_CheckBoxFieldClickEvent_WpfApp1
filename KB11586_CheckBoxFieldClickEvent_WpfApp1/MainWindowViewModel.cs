using KB11586_CheckBoxFieldClickEvent_WpfApp1.Infrastructure;
using KB11586_CheckBoxFieldClickEvent_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB11586_CheckBoxFieldClickEvent_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
	private ObservableCollection<SampleDataItem> _sampleData;

	public ObservableCollection<SampleDataItem> SampleData
	{
		get { return _sampleData; }
		set { _sampleData = value; OnPropertyChanged(); }
	}

    public MainWindowViewModel()
    {
		_sampleData = new()
		{
			new() { IsChecked = false, Col1 = "aaa"},
			new() { IsChecked = false, Col1 = "aaa"},
			new() { IsChecked = false, Col1 = "aaa"},
			new() { IsChecked = false, Col1 = "aaa"}
		};
    }
}
