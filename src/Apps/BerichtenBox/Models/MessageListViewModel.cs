using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BerichtenBox.Models;

public class MessageListViewModel
{
    public IEnumerable<string> Teams { get; set; }

    public IEnumerable<MessageViewModel>? Messages { get; set; }

    [DisplayName("Team")]
    public string Team { get; set; } = string.Empty;

    public MessageListViewModel()
    {
        var list = new List<string>();
        for (var i = 0; i < 20; i++)
        {
            list.Add($"team-{i + 1:D2}");
        }

        Teams = list.ToArray();
    }
}