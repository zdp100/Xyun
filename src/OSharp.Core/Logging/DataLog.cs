// -----------------------------------------------------------------------
//  <copyright file="OperatingLog.cs" company="OSharp开源团队">
//      Copyright (c) 2014 OSharp. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2014-08-13 15:48</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OSharp.Core.Context;
using OSharp.Core.Data;
using OSharp.Utility.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OSharp.Core.Logging
{
    /// <summary>
    /// 数据日志信息类
    /// </summary>
    [Description("系统-数据日志信息")]
    public class DataLog : EntityBase<int>
    {
        /// <summary>
        /// 获取或设置 类型名称
        /// </summary>
        [Display(Name = "类型名称"), StringLength(500)]
        public string EntityName
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 实体名称
        /// </summary>
        [Display(Name = "实体名称")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 数据编号
        /// </summary>
        [StringLength(150), DisplayName("主键值")]
        public string EntityKey
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 操作类型
        /// </summary>
        [Description("操作类型")]
        public OperatingType OperateType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 操作日志信息
        /// </summary>
        public virtual OperateLog OperateLog
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 操作明细
        /// </summary>
        public virtual ICollection<DataLogItem> LogItems
        {
            get;
            set;
        }

        /// <summary>
        /// 初始化一个<see cref="T:OSharp.Core.Logging.DataLog" />类型的新实例
        /// </summary>
        public DataLog()
            : this(null, null, OperatingType.Query)
        {
        }

        /// <summary>
        /// 初始化一个<see cref="T:OSharp.Core.Logging.DataLog" />类型的新实例
        /// </summary>
        public DataLog(string entityName, string name, OperatingType operatingType)
        {
            this.EntityName = entityName;
            this.Name = name;
            this.OperateType = operatingType;
            this.LogItems = new List<DataLogItem>();
        }
    }
}