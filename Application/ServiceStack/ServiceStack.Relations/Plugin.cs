﻿using ServiceStack;
using ServiceStack.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Relations
{
    public class Plugin : IPlugin
    {
        public void Register(IAppHost appHost)
        {
            appHost.RegisterService<Store.Service>();

            //appHost.GetContainer().RegisterAutoWiredType(typeof(Users.Service));

            //appHost.GetContainer().Register<Users.Service>((c) => new Users.Service(c.Resolve<IBus>()));
            appHost.GetContainer().RegisterValidators(typeof(Plugin).Assembly);
        }
    }
}