using BlazorAdmin.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorAdmin.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}