﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.BASE;

namespace Blog.Core.Services
{
     public partial class sysUserInfoServices: BaseServices<sysUserInfo>, IsysUserInfoServices
    {
        IsysUserInfoRepository dal;
        public sysUserInfoServices(IsysUserInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}
