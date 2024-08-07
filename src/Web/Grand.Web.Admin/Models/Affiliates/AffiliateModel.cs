﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Grand.Web.Admin.Models.Common;

namespace Grand.Web.Admin.Models.Affiliates;

public class AffiliateModel : BaseEntityModel
{
    [GrandResourceDisplayName("Admin.Affiliates.Fields.ID")]
    public override string Id { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.Fields.Name")]
    public string Name { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.Fields.URL")]
    public string Url { get; set; }


    [GrandResourceDisplayName("Admin.Affiliates.Fields.AdminComment")]

    public string AdminComment { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.Fields.FriendlyUrlName")]

    public string FriendlyUrlName { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.Fields.Active")]
    public bool Active { get; set; }

    public AddressModel Address { get; set; } = new();

    #region Nested classes

    public class AffiliatedOrderModel : BaseEntityModel
    {
        [GrandResourceDisplayName("Admin.Affiliates.Orders.Order")]
        public override string Id { get; set; }

        public int OrderNumber { get; set; }

        public string OrderCode { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public string OrderStatus { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
        public string OrderTotal { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }

    public class AffiliatedCustomerModel : BaseEntityModel
    {
        [GrandResourceDisplayName("Admin.Affiliates.Customers.Name")]
        public string Name { get; set; }
    }

    #endregion
}