using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace sufrun
{
    class firebaseconnection
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "This is your authsecret",
            BasePath = "This is your BasePath"
        };

        public IFirebaseClient client;
        public FirebaseResponse response;

    }
}
