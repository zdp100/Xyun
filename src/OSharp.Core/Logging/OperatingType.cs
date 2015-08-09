
namespace OSharp.Core.Logging
{
    /// <summary>
    /// 实体数据日志操作类型
    /// </summary>
    public enum OperatingType
    {
        /// <summary>
        /// 查询
        /// </summary>
        Query,
        /// <summary>
        /// 新建
        /// </summary>
        Insert = 10,
        /// <summary>
        /// 更新
        /// </summary>
        Update = 20,
        /// <summary>
        /// 删除
        /// </summary>
        Delete = 30
    }
}
