﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIA.WebFresher052023.DL_Repositories.Entity
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Ngày tạo
        /// </summary>
        /// Created by: ldtuan (12/07/2023)
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        /// Created by: ldtuan (12/07/2023)
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày cập nhật
        /// </summary>
        /// Created by: ldtuan (12/07/2023)
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người cập nhật
        /// </summary>
        /// Created by: ldtuan (12/07/2023)
        public string ModifiedBy { get; set; }
    }
}
