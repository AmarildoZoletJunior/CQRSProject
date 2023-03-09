using FrotaApp.Application.Input.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.Input.Receivers.Interfaces
{
    public interface IReceiver<in T,out W> 
        where T : ICommand 
        where W : Task<State>
    {
        W Action(T command);
    }
}
