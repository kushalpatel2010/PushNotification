﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace PushNotification
{
    public class notificationHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}

        public void Send(string name, string message)
        {
            
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}