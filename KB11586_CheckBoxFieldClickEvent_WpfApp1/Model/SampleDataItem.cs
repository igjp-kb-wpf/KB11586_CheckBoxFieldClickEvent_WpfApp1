using KB11586_CheckBoxFieldClickEvent_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB11586_CheckBoxFieldClickEvent_WpfApp1.Model;
internal class SampleDataItem : ObservableObject
{
	private bool _isChecked;

	public bool IsChecked
	{
		get { return _isChecked; }
		set { _isChecked = value; OnPropertyChanged(); }
	}

	private String _col1 = "";

	public String Col1
	{
		get { return _col1; }
		set { _col1 = value; OnPropertyChanged(); }
	}

    public SampleDataItem()
    {
        
    }
}
