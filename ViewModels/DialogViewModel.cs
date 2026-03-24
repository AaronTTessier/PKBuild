using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.ViewModels;

public partial class DialogViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isOpen;
    
    protected TaskCompletionSource CloseDialogTask = new ();

    public async Task WaitAsync()
    {
        await CloseDialogTask.Task;
    }

    public void ShowDialog()
    {
        if (CloseDialogTask.Task.IsCompleted)
        {
            CloseDialogTask = new TaskCompletionSource();
        }
        IsOpen = true;
    }

    public void CloseDialog()
    {
        IsOpen = false;
        
        CloseDialogTask?.TrySetResult();
    }
}