using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DLL.BaseCode
{
    /// <summary>
    ///BaseCode 的摘要说明
    /// </summary>
    public partial class BaseCode
    {
       
       
        /// <summary>
        /// 状态
        /// </summary>
        public enum state
        {
            库存 = 0,
            使用中 = 1,
            已报废 = 2,
            借出 = 3
        }
        /// <summary>
        /// 部门
        /// </summary>
         public enum department
        {
            请选择 = 0,
            车队 = 1,
            物资室 = 2,
            文印室 = 3,
            收发室=4,
            教科委 = 5,
            秘书处 = 6,
            档案室 = 7,
            群众路线办公室= 8

        }
         /// <summary>
         /// 部门
         /// </summary>
         public enum nettype
         {
             请选择 = 0,
             外 = 1,
             内 = 2,
             单 = 3,
             隔 =4
             
         }
        public enum type
        {
            请选择 = 0,
            笔记本 = 1,
            台式机 = 2,
            其他设备 = 3
        }
      
    }
}