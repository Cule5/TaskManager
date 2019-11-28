using System;
using System.Collections.Generic;
using System.Text;
using Services.WorkItem.Dto;

namespace Services.WorkItem
{
    public interface IWorkItemService
    {
        System.Threading.Tasks.Task CreateWorkItemAsync(CreateWorkItemDto createWorkItemDto);
    }
}
