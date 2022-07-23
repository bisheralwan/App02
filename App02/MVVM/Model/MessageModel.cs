using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02.MVVM.Model
{
    class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColour { get; set; }
        public string Message { get; set; }
        public string ImageSource { get; set; }
        public DateTime Time { get; set; }
        public bool isNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }

    }
}
