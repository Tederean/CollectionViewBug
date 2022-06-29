using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionViewBug
{

  public partial class MainPageViewModel : ObservableObject
  {

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ExcludeFieldDescriptions))]
    private bool m_IncludeFieldDescriptions;

    public bool ExcludeFieldDescriptions => !IncludeFieldDescriptions;


    [ObservableProperty]
    private ObservableCollection<EntryViewModel>? m_AvailableRows;


    public MainPageViewModel()
    {
      var viewmodel = new EntryViewModel();

      m_AvailableRows = new ObservableCollection<EntryViewModel>() { viewmodel, viewmodel, viewmodel };
    }
  }

  public partial class EntryViewModel : ObservableObject
  {

    [ObservableProperty]
    private string m_Column1 = "Column 1";

    [ObservableProperty]
    private string m_Column2 = "Column 2";
  }
}
