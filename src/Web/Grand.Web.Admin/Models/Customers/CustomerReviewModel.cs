﻿using Grand.Web.Admin.Models.Common;

namespace Grand.Web.Admin.Models.Customers;

public class CustomerReviewModel
{
    public string CustomerId { get; set; }

    public ReviewModel Review { get; set; }
}