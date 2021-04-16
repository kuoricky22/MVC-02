using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_03_公司練習.Models
{
    public class EmployeeModel
    {
        /// <summary>
        ///  姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 員工代號
        /// </summary>
        public string EmpNo { get; set; }
        /// <summary>
        /// 部門名稱
        /// </summary>
        public string Dept { get; set; }
        /// <summary>
        /// 部門代號
        /// </summary>
        public string DeptNo { get; set; }
        /// <summary>
        /// 單位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 單位代號
        /// </summary>
        public string UnitNo { get; set; }
        /// <summary>
        /// 職稱
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///  Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 分數
        /// </summary>
        public string Score { get; set; }

    }
}