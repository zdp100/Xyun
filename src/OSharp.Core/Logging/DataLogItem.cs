﻿using OSharp.Core.Data;
using OSharp.Utility.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OSharp.Core.Logging
{
    /// <summary>
    /// 实体操作日志明细
    /// </summary>
    [Description("系统-操作日志明细信息")]
    public class DataLogItem : EntityBase<Guid>
    {
        /// <summary>
        /// 获取或设置 字段
        /// </summary>
        public string Field
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 字段名称
        /// </summary>
        public string FieldName
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 旧值
        /// </summary>
        public string OriginalValue
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 新值
        /// </summary>
        public string NewValue
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 数据类型
        /// </summary>
        public string DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置 所属数据日志
        /// </summary>
        public virtual DataLog DataLog
        {
            get;
            set;
        }

        /// <summary>
        /// 初始化一个<see cref="T:OSharp.Core.Logging.DataLogItem" />类型的新实例
        /// </summary>
        public DataLogItem()
            : this(null, null)
        {
        }

        /// <summary>
        ///             初始化一个<see cref="T:OSharp.Core.Logging.DataLogItem" />类型的新实例
        /// </summary>
        /// <param name="originalValue">旧值</param>
        /// <param name="newValue">新值</param>
        public DataLogItem(string originalValue, string newValue)
        {
            base.Id = CombHelper.NewComb();
            this.OriginalValue = originalValue;
            this.NewValue = newValue;
        }
    }
}
