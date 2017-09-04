using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public enum Status
    {
        ConnectionSuccess = 1, //這樣就從1開始編數
        ConnectionError,
        ReadSuccess = 10,
        ReadError
    }
}