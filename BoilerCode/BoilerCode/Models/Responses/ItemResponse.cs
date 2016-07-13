﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoilerCode.Models.Responses
{
    public class ItemResponse<T> : SuccessResponse
    {

        public T Item { get; set; }

    }
}