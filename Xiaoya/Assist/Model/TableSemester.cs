﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaoya.Assist.Model
{
    public class TableSemester
    {
        /// <summary>
        /// 学期代码
        /// </summary>
        [JsonProperty]
        public string Code { get; private set; }
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty]
        public string Name { get; private set; }
        /// <summary>
        /// 学年
        /// </summary>
        public string Year { get; private set; }
        /// <summary>
        /// 学期
        /// </summary>
        public string Semester { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Semester code</param>
        /// <param name="name">Semester name</param>
        [JsonConstructor]
        public TableSemester(string code, string name)
        {
            Code = code.Trim();
            Name = name.Trim();

            Year = Code.Substring(0, Code.IndexOf(",")).Trim();
            Semester = Code.Substring( Code.IndexOf(",") + 1).Trim();
        }
    }
}
