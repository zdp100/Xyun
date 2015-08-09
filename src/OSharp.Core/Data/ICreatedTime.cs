using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSharp.Core.Data
{
    /// <summary>
    /// 表示实体将包含创建时间，在创建实体时，将自动提取当前时间为创建时间
    /// </summary>
    public interface ICreatedTime
    {
        /// <summary>
        /// 获取设置 信息创建时间
        /// </summary>
        DateTime CreatedTime
        {
            get;
            set;
        }
    }
}
