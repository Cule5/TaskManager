using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    interface ICommandHandler<in T> where T : ICommand
    {
        System.Threading.Tasks.Task HandleAsync(T command);
    }
}
