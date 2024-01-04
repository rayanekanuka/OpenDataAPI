using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataLibrary
{
    public interface IRequest
    {
        string DoRequest(string url);
    }
}
